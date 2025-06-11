# Product Search Microservice
This project aims to be a microservice for searching products in a database through a RESTful API.

### Architecture
The architecture used for this project is Clean architecture.
This involves the use of different layers such as Domain, Application, Infrastructure and Presentation.

### Configuration
The project uses a .env file and an appsettings.json file to configure the project.

### PostgreSQL
The database used for the project is PostgreSQL in the version 17.

### Dockerization
The project is totally dockerized, including the PostgreSQL database.
To automate the initialization of the containers, a Docker Compose file is used, "compose.yml".
To run it, use the command
```
docker compose up --build
```