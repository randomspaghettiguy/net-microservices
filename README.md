# net-microservices
This is a .NET microservices from scratch provided by [Dotnet Microservices](https://dotnetmicroservices.com/)

## How to run this project?

- Change directory to Play.Infra folder

```sh
cd code/Play.Infra/
```

- Run `docker compose up -d`

```sh
docker compose up -d
```

- Back to the root folder, change directory to Play.Catalog service folder

```sh
cd code/Play.Catalog/src/Play.Catalog.Service/
```

- Run the Catalog service

```sh
dotnet run
```

- Back to the root folder, change directory to Play.Catalog service folder

```sh
cd code/Play.Inventory/src/Play.Catalog.Service/
```

- Run the Inventory service

```sh
dotnet run
```

## API documentation for Catalog service

[<img src="code/assets/button-view-api-docs.png" alt="ViewAPIDocumentation" width="200">](https://documenter.getpostman.com/view/30368382/2sA3rzHrag)

## API documentation for Inventory service

[<img src="code/assets/button-view-api-docs.png" alt="ViewAPIDocumentation" width="200">](https://documenter.getpostman.com/view/30368382/2sA3rzHrah)