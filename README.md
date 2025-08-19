# Kafka + Redis: Building Scalable and Robust Architectures.
[![](https://img.shields.io/badge/-Apache%20Kafka-333333?style=flat&logo=visual-studio-code&logoColor=007ACC)](https://docs.confluent.io/kafka-clients/dotnet/current/overview.html)
[![](https://img.shields.io/badge/-Redis-333333?style=flat&logo=visual-studio-code&logoColor=007ACC)](https://redis.io/docs/latest/develop/clients/dotnet/)

Robust application with Clean Architecture, following Domain-Driven Design principles, implementing Kafka as a messaging service and Redis for caching. This project demonstrates a scalable and maintainable system design, capable of handling high-throughput data streams efficiently. Kafka is used for reliable asynchronous communication, while Redis provides fast, in-memory caching to improve performance.

## Key features:
- Kafka integration for high-throughput event streaming.
- Redis caching for fast data retrieval and improved application performance.
- Clean Architecture Designed for scalability and extensibility.
- Domain-Driven Design principles.
- SQL Server

## Technologies Used
- .NET
- Apache Kafka
- Redis
- Docker & Docker Compose
- SQL Server

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
