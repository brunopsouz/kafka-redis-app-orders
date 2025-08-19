# Apache Kafka + Redis: Building Scalable and Robust Architectures.
[![](https://img.shields.io/badge/-Apache%20Kafka-333333?style=flat&logo=visual-studio-code&logoColor=007ACC)](https://docs.confluent.io/kafka-clients/dotnet/current/overview.html)
[![](https://img.shields.io/badge/-Redis-333333?style=flat&logo=visual-studio-code&logoColor=007ACC)](https://redis.io/docs/latest/develop/clients/dotnet/)

Robust application with `Clean Architecture`, following `Domain-Driven Design` principles, implementing `Apache Kafka` as a messaging service and `Redis` for caching. This project demonstrates a scalable and maintainable system design, capable of handling high-throughput data streams efficiently. `Apache Kafka` is used for reliable asynchronous communication, while `Redis` provides fast, in-memory caching to improve performance.

## Key features:
- Kafka integration for high-throughput event streaming.
- Redis caching for fast data retrieval and improved application performance.
- Clean Architecture Designed for scalability and extensibility.
- Domain-Driven Design principles.
- SQL Server

## Technologies:
- .NET
- Apache Kafka
- Redis
- Docker & Docker Compose
- SQL Server

## Architecture Overview:
Domain-Driven Design principles.
- `./src/Backend/App.Api`: Layer for API'.
  - `./Api.Api/Controllers`: Control by Swagger to simulate a products and orders.
    
- `./src/Backend/App.Application`: Orchestrates use cases and application workflows, coordinating between the domain layer and infrastructure services.
  - `./src/Backend/App.Application/DependencyInjectionExtension.cs`: Class responsible for registering and managing dependency injections.
  
- `.src/Backend/App.Domain`: Encapsulates the core business logic and domain entities, following Domain-Driven Design principles. This layer is independent of infrastructure and application concerns, ensuring that the core rules of the system remain isolated and maintainable.
- `.src/Backend/App.Domain/Services`: This layer contains the service interfaces for Apache Kafka and Redis.

- `./src/Backend/App.Infrastructure`: Implements all technical details required by the application, such as database access, external services, messaging systems, and caching. In Domain-Driven Design, this layer supports the domain and application layers without containing business rules, ensuring that technical concerns are separated from core logic.
  
  - `./src/Backend/App.Infrastructure/Services`: Contains the concrete implementations of external services such as Apache Kafka and Redis, handling messaging, caching, and other integration concerns. This layer connects the application and domain logic to the technical infrastructure while keeping business rules isolated.
  -  `./src/Backend/App.Infrastructure/DependencyInjectionExtension.cs`: Class responsible for registering and managing dependency injections.

- `./src/Shared/App.Communication`: Layer for Requests and Responses.
  
- `./tests/Consumer/Kafka/Consumer.Kafka`: "Simple console application to test Kafka message consumption."

## Getting Started:
- Clone the repository:
```bash
https://github.com/brunopsouz/kafka-redis-app-orders.git
```
- Up the Docker containers :
```bash
docker-compose up -d
```
- Configure the appsettings.json file with your database Connection Strings.
```
./scr/Backend/App.Api/appsettings.json
```
- Open the Manage NuGet Packages menu and verify that Confluent.Kafka and StackExchange.Redis are installed:
```bash
dotnet add package Confluent.Kafka
```
```
dotnet add package StackExchange.Redis
```
- Make sure both projects (App.Api & Consumer.Kafka) are configured as Startup Projects:
```bash
Sln > Configure Startup Project > Multiple startup projects > Both Action: Start
```
