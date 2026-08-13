DVLD Management System

Driving & Vehicle License Department Management System

A desktop-based Driving & Vehicle License Department Management System built with C# and Windows Forms, designed to simulate and manage the core operations of a driving license department.

The system manages people, users, drivers, applications, licenses, appointments, tests, renewals, replacements, detentions, and international licenses, following a 3-Layer Architecture to maintain a clear separation between presentation, business logic, and data access.

---

Overview

The DVLD Management System is a practical business application developed to simulate the workflows of a driving and vehicle license department.

The project goes beyond basic CRUD operations by implementing interconnected business processes and validation rules across multiple modules.

Main areas covered

- People Management
- User Management
- Drivers Management
- Local Driving License Applications
- Application Types
- Test Appointments
- Driving Tests
- Test Retakes
- License Management
- License Renewal
- Lost & Damaged License Replacement
- License Detention
- License Release
- International Driving Licenses

---

Features

People Management

Manage personal information used throughout the system.

- Add new people
- Update existing records
- Delete eligible records
- Search and filter people
- Manage personal information
- Reuse person records across different modules

---

User Management

Manage users who can interact with the system.

- Create and manage users
- Associate users with people
- Manage usernames
- Manage user activation status
- Search and filter users

---

Drivers Management

Manage drivers and their relationship with the licensing system.

The driver module connects driver information with their licenses and other related licensing records.

---

Applications Management

The application module manages different types of licensing-related applications.

Application Types

Application types and their associated fees can be managed through the system.

Local Driving License Applications

The system manages the process of applying for a new local driving license.

The application goes through the required stages and validations before a license can be issued.

---

Test & Appointment Management

The system manages appointments and results for the required driving tests.

Supported tests include:

- Vision Test
- Written Test
- Street Test

The application validates the current application state and existing appointments before allowing test-related operations.

---

Test Retakes

The system supports retaking failed tests.

Retake operations maintain the relationship between the previous attempt and the new test process while preserving the application's history.

---

License Management

The system provides several license-related operations, including:

- License issuance
- License renewal
- Lost license replacement
- Damaged license replacement
- License detention
- License release
- International license issuance

Each operation is subject to the appropriate business rules and validation.

---

Architecture

The application follows a 3-Layer Architecture.

Presentation Layer — "DVLD"

Responsible for the Windows Forms user interface and user interaction.

Responsibilities include:

- Forms
- User Controls
- Navigation
- UI validation
- Data presentation
- User interaction

---

Business Layer — "DVLD_Business"

Responsible for the application's business logic and rules.

Responsibilities include:

- Business rules
- Validation
- Application workflows
- Domain operations
- Coordinating operations between the UI and data access layer

Keeping these responsibilities in the Business Layer prevents the Presentation Layer from becoming tightly coupled to the application's business logic.

---

Data Access Layer — "DVLD_DataAccess"

Responsible for communicating with the SQL Server database.

Responsibilities include:

- Data retrieval
- Data insertion
- Data updating
- Data deletion
- Database operations
- ADO.NET implementation

The Data Access Layer isolates database-related operations from the Business Layer.

---

Project Structure

The solution is organized into three main projects.

Project| Responsibility
"DVLD"| Windows Forms presentation layer and user interface
"DVLD_Business"| Business logic, validation, and application rules
"DVLD_DataAccess"| SQL Server communication and data access

Presentation Project — "DVLD"

The Presentation Layer is organized around the application's main functional areas:

Folder| Purpose
"Applications"| Application-related forms and operations
"Drivers"| Driver management
"Global"| Shared application functionality
"Licenses"| License-related operations
"Login"| Login and authentication-related UI
"People"| People management
"Properties"| Application properties
"Resources"| Application resources
"Tests"| Test and appointment management
"Users"| User management

The "Applications" area contains functionality related to:

- Application Types
- Local Applications
- International Licenses
- Lost or Damaged Licenses
- License Release
- License Renewal
- Application-related Controls

Business Project — "DVLD_Business"

Contains the business objects and rules responsible for the main system modules, including:

- Applications
- Drivers
- Licenses
- People
- Tests
- Users

Data Access Project — "DVLD_DataAccess"

Contains the database access implementation.

The project includes:

- Data access classes for applications
- Application types
- Countries
- Drivers
- Detained licenses
- International licenses
- License classes
- Licenses
- Local applications
- People
- Test appointments
- Tests
- Test types
- Users
- Shared settings

It also contains DTOs used when a dedicated data-transfer structure is required.

---

Business Rules

A major focus of the project was implementing business rules instead of treating the system as a collection of CRUD screens.

Examples include:

- Validating whether an application is eligible for a specific operation.
- Checking whether an appointment already exists.
- Preventing invalid test scheduling.
- Validating test prerequisites.
- Handling failed tests and retakes.
- Controlling when applications can be cancelled.
- Determining whether records can be deleted.
- Validating license renewal conditions.
- Handling lost or damaged license replacement.
- Managing license detention and release.
- Validating eligibility for international licenses.

These rules are primarily handled within the Business Layer.

---

Data Access

The project uses:

- SQL Server as the relational database.
- ADO.NET for database communication.
- Dedicated Data Access classes for the application's main entities.
- DTOs where specific data structures are required.

The Data Access Layer is responsible for database communication while keeping SQL-related operations isolated from the application's business logic.

---

Technologies

Technology| Usage
C#| Main programming language
.NET| Application framework
Windows Forms| Desktop user interface
SQL Server| Relational database
ADO.NET| Data access
Visual Studio| Development environment
Git| Version control
GitHub| Source code management

---

Technical Highlights

The project provided practical experience with:

- Object-Oriented Programming
- 3-Layer Architecture
- Separation of Concerns
- Encapsulation
- Business Rule Implementation
- Relational Database Design
- SQL Server
- ADO.NET
- DTOs
- CRUD Operations
- Data Binding
- DataGridView
- Search & Filtering
- Reusable Windows Forms Controls
- Validation
- Error Handling
- Application Workflows
- Test & Retake Management
- License Lifecycle Management

---

Challenges & Problem Solving

One of the main challenges was implementing the application's business workflows while keeping responsibilities separated between the different layers.

For example, test scheduling requires more than simply inserting an appointment into the database. The application needs to consider the current application state, previous test attempts, existing appointments, and the rules that determine whether the operation is valid.

Another important challenge was maintaining clean communication between the Presentation, Business, and Data Access layers without placing business decisions directly inside the UI.

This required careful consideration of:

- Where business rules should be implemented.
- Which layer should perform each operation.
- How entities should interact.
- How database operations should be isolated.
- How to keep the UI focused on presentation and interaction.

---

Getting Started

Prerequisites

Before running the project, make sure you have:

- Visual Studio
- The required .NET framework/runtime for the project
- SQL Server
- SQL Server Management Studio (recommended)

Installation

1. Clone the repository.

git clone https://github.com/KMHob-allah/DVLD.git

2. Open the solution in Visual Studio.

3. Create or restore the required SQL Server database.

4. Configure the database connection string according to your local SQL Server instance.

5. Build the solution.

6. Set "DVLD" as the startup project.

7. Run the application.

---

Future Improvements

Possible future improvements include:

- Migrating the application to an ASP.NET Core Web API.
- Introducing Dependency Injection.
- Applying additional SOLID principles.
- Adding automated unit and integration tests.
- Introducing centralized logging.
- Improving authentication and authorization.
- Evaluating Entity Framework Core for selected data-access scenarios.
- Building a modern web frontend.
- Moving toward a more scalable architecture.

---

What I Learned

Building the DVLD Management System helped me move beyond implementing individual features and start thinking about software as a complete system.

The project strengthened my understanding of:

- Designing multi-layer applications.
- Separating responsibilities between layers.
- Translating business requirements into code.
- Working with relational databases.
- Implementing business rules.
- Managing complex application workflows.
- Building reusable components.
- Debugging problems across multiple layers.
- Writing more maintainable and structured code.

The main lesson was that building a real-world application is not only about making features work, but also about deciding where responsibilities belong and how different parts of the system should communicate.

---

Author

Khaled Mohamed

Junior .NET Software Engineer

Technical Focus:
"C#" • ".NET" • "SQL Server" • "ADO.NET" • "Backend Development"

---

Repository

If you find the project useful or interesting, feel free to explore the source code and the repository.

<p align="center">
  Built with C# • .NET • SQL Server • ADO.NET
</p>
