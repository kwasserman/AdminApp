AdminApp

A C#/.NET administrative management application designed to support virtual airline operations through a dedicated Windows desktop application.

Overview

AdminApp was developed to provide a centralized administrative application for managing virtual airline operations. The project uses a modular structure that separates application functionality, business logic, data access, models, configuration, and controllers.

The application is built with C# and .NET and uses Windows Forms for its desktop interface.

Features

* Administrative management functionality for virtual airline operations
* Windows desktop interface built with Windows Forms
* MySQL database integration
* Separated business-logic and data-access layers
* Authentication-related functionality
* Application configuration management
* JSON data serialization
* Structured application logging
* Modular project organization

Technology Stack

Technology	Purpose
C#	Primary programming language
.NET 10	Application framework
Windows Forms	Desktop user interface
MySQL	Database
JWT Bearer Authentication	Authentication support
OpenID Connect	Authentication support
Newtonsoft.Json	JSON serialization
Serilog	Application logging
Git / GitHub	Source control

Architecture

The project is organized into separate components to keep application responsibilities isolated and maintainable.

AdminApp/
├── AdminBL/
│   └── Business logic
├── AdminModels/
│   └── Application models
├── AdminSetting/
│   └── Configuration and settings
├── Application/
│   └── Application and authentication functionality
├── Controllers/
│   └── Application controllers
├── DL/
│   └── Data-access functionality
├── Properties/
│   └── Application resources
├── MenuForm.cs
├── NewsPanel.cs
├── login.cs
├── Program.cs
├── Data.cs
├── AdminApp.csproj
└── AdminApp.sln

Business Logic

The AdminBL component is responsible for application business logic and helps keep business rules separate from the user interface and database implementation.

Data Access

The DL component contains the data-access functionality used by the application. This separation allows database operations to remain independent from the application’s presentation and business-logic layers.

Models

AdminModels contains the models used throughout the application.

Application & Configuration

The Application and AdminSetting components organize application-level functionality and configuration.

Authentication

The project includes authentication-related dependencies for:

* JWT Bearer authentication
* OpenID Connect

Authentication functionality is separated from the core application structure to keep security-related configuration organized.

Database

AdminApp uses MySQL for database connectivity through the MySql.Data package.

Database-related functionality is organized within the data-access portion of the application rather than being tightly coupled to the Windows Forms interface.

Logging

The application uses Serilog for structured logging.

Logging support includes:

* Console logging
* File logging
* Integration with the .NET logging infrastructure

This provides a consistent approach to application monitoring and troubleshooting.

Development Practices

This project demonstrates experience with:

* Object-oriented programming in C#
* .NET application development
* Windows Forms development
* Layered application organization
* Separation of concerns
* Database integration
* Authentication concepts
* Application configuration
* Structured logging
* Git-based source control

Getting Started

Prerequisites

Before running the application, make sure you have:

* Windows
* .NET 10 SDK
* Visual Studio or another compatible .NET development environment
* Access to a MySQL database

Clone the Repository

git clone https://github.com/kwasserman/AdminApp.git
cd AdminApp

Open the Solution

Open:

AdminApp.sln

in Visual Studio.

Configuration

Review the application’s configuration files and database settings before running the application.

Important: Do not commit database passwords, authentication secrets, API keys, or other sensitive credentials to source control.

Build and Run

Restore the project dependencies, build the solution, and run the application from Visual Studio.

Project Goals

The primary goal of AdminApp is to provide a dedicated administrative tool for virtual airline management while maintaining a clean separation between the application’s user interface, business logic, data access, models, and configuration.

Future Improvements

Potential areas for future development include:

* Expanding automated testing
* Improving the desktop user interface
* Expanding administrative functionality
* Further separating application services and dependencies
* Adding additional validation and error handling
* Expanding CI/CD automation

License

See the repository for licensing information.