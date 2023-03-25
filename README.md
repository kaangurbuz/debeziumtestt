# Building Test Case Applications Using ASP.NET 7

### Run / Debug
``` 
docker compose up -d
```

###  Urls

- Debezium Connect: http://localhost:8083
- Kafka UI: http://localhost:8090
- Debezium UI: http://localhost:8080
- Write API: http://localhost:7000/swagger

### Requirements
-  .NET Core 7 Runtime 
-  Docker & Docker Compose 
-  PostgreSQL
-  Swaggwer
-  Kafka
-  Debezium

### Example Request

```http
POST - http://localhost:8083/connectors

{
    "name": "test-connector",
    "config": {
        "connector.class": "io.debezium.connector.postgresql.PostgresConnector",
        "tasks.max": "1",
        "topic.prefix" : "datatransfer",
        "database.hostname": "host.docker.internal",
        "database.port": "5432",
        "database.user": "postgres",
        "database.password": "123456",
        "database.dbname": "ProductDB",
        "database.server.name": "host.docker.internal",
        "database.whitelist": "product",
        "plugin.name": "pgoutput"
    }
}
```