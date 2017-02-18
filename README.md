# SQL Saturday 586 (Guatemala)

### Docker Run
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' -p 1433:1433 -d microsoft/mssql-server-linux:ctp1-2
```

### Docker Run with Volume
```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=<YourStrong!Passw0rd>' -p 1433:1433 -v D:\docker:/var/opt/mssql -d microsoft/mssql-server-linux:ctp1-2
```
