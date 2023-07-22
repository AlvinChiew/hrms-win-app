# Setup MSSQL Server

1. Install docker from [link](https://docs.docker.com/get-docker/)
1. `docker pull mcr.microsoft.com/mssql/server`
1. `docker run --name mssql_server -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=.Demoproj" -p 1433:1433 -d mcr.microsoft.com/mssql/server:latest`
1. Optional - status check : `docker exec -it mssql_server /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P .Demoproj`


# Setup dotnet on VSCODE

1. Install latest dotnet sdk from [link](https://dotnet.microsoft.com/en-us/download)
1. `refreshenv`
1. `mkdir src`
1. `cd src`
1. `dotnet new winforms`
1. build cmd : `dotnet run`