FROM mcr.microsoft.com/dotnet/sdk AS base

WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish --configuration Debug -o out PizzaBox.Client

FROM mcr.microsoft.com/dotnet/aspnet

WORKDIR /run
COPY --from=base /app/out .
CMD [ "dotnet", "PizzaBox.Client.dll" ]