🚗 DVLD Management System

Driving & Vehicle License Department Management System

A desktop-based Driving & Vehicle License Department Management System built with C# and Windows Forms, designed to simulate and manage the core operations of a driving license department.

The system handles people, users, drivers, applications, licenses, appointments, tests, renewals, replacements, detentions, and international licenses, while following a 3-Layer Architecture to maintain a clear separation between presentation, business logic, and data access.

---

📌 Project Overview

The DVLD Management System is a real-world business application developed to practice designing and implementing a complete multi-layer desktop system.

Instead of being limited to basic CRUD operations, the project implements interconnected workflows and business rules such as:

- Creating and managing people and users
- Managing drivers and their licenses
- Applying for local driving licenses
- Scheduling and managing driving tests
- Handling failed tests and retakes
- Issuing, renewing, and replacing licenses
- Managing lost or damaged licenses
- Detaining and releasing licenses
- Issuing international driving licenses
- Managing application types and license classes

The project focuses on business logic, data consistency, separation of concerns, and maintainable application structure.

---

✨ Features

👤 People Management

Centralized management of people records used throughout the system.

- Add new people
- Update existing people
- Delete eligible records
- Search and filter people
- Manage personal information
- Associate people with users and drivers

"People Management" (docs/screenshots/people-list.png)

---

👨‍💼 User Management

Manage users who can interact with the system.

- Add and manage users
- Associate users with people
- Manage usernames
- Manage user activation status
- Search and filter users

"Users Management" (docs/screenshots/users-list.png)

---

🚘 Drivers Management

Manage drivers and their relationship with the licensing system.

The driver module allows the system to track driver information and connect drivers with their issued licenses and related records.

---

📝 Applications Management

The application module manages different types of licensing-related applications.

Application Types

The system supports managing different application types and their associated fees.

Local Driving License Applications

Handles the workflow of applying for a new local driving license.

The system validates the required conditions at each stage before allowing the application to proceed.

---

🌍 International Licenses

The system supports issuing and managing International Driving Licenses for eligible drivers.

International license records are linked to the driver's existing licensing information.

---

🔄 License Renewal

The system provides functionality for renewing existing driving licenses while applying the required business rules and fees.

---

🪪 Lost or Damaged Licenses

The system handles requests for replacing licenses that have been:

- Lost
- Damaged

The replacement workflow ensures that the required license information and application state are validated before issuing the replacement.

---

📄 Release Licenses

The system supports releasing detained driving licenses after the required conditions have been satisfied.

---

🧪 Tests & Appointments

The system manages the complete driving test process.

Supported tests include:

- 👁️ Vision Test
- 📝 Written Test
- 🚗 Street Test

Each test is associated with an appointment and a specific application.

The system prevents invalid appointment and test operations according to the application's business rules.

---

🔁 Retake Management

Failed tests are handled through a retake workflow.

The system maintains the relationship between the original test attempt and the corresponding retake process.

This allows test history and application progress to remain consistent throughout the licensing workflow.

---

🚔 License Detention

The system supports managing detained licenses.

It allows the department to:

- Detain a license
- Store detention information
- Track detained licenses
- Release licenses when applicable

This functionality demonstrates how the system handles additional business processes around an existing license.

---

🏗️ Architecture

The project follows a 3-Layer Architecture:


Presentation Layer

Responsible for:

- Windows Forms
- User interaction
- UI validation
- Data presentation
- Reusable controls
- Application navigation

Business Layer

Responsible for:

- Business rules
- Validation
- Application workflows
- Domain operations
- Coordinating data access

Data Access Layer

Responsible for:

- Database communication
- SQL operations
- Data retrieval
- Data modification
- ADO.NET implementation

This separation keeps the application's business logic independent from the UI and database implementation.

---

📂 Project Structure

The solution is divided into three main projects:


The structure reflects the separation between:

Presentation → Business → Data Access

and keeps each project's responsibilities focused.

---

🗄️ Data Access

The project uses SQL Server as the database and ADO.NET for communication between the application and the database.

The Data Access Layer contains dedicated data-access classes for the main entities, including:

- Applications
- Application Types
- Countries
- Drivers
- Licenses
- License Classes
- Local Applications
- International Licenses
- People
- Users
- Tests
- Test Appointments
- Test Types
- License Detention

DTOs are also used where a specific data structure is required by the application.

---

🧠 Business Rules

A major focus of the project was implementing business rules, not just database operations.

Examples include:

- Checking whether an application is eligible for a specific operation.
- Preventing duplicate or invalid appointments.
- Validating test prerequisites.
- Handling failed tests and retakes.
- Controlling when applications can be cancelled.
- Determining whether records can be deleted.
- Validating license renewal conditions.
- Handling lost or damaged license replacement.
- Managing license detention and release.
- Validating eligibility for international licenses.

These rules are implemented within the Business Layer rather than being tightly coupled to the Windows Forms UI.

---

🖥️ Screenshots

Main Dashboard

The main dashboard provides access to the major modules of the system.

"DVLD Dashboard" (docs/screenshots/main-dashboard.png)

---

People Management

A centralized interface for managing and filtering people records.

"People Management" (docs/screenshots/people-list.png)

---

Users Management

A dedicated interface for managing application users and their active status.

"Users Management" (docs/screenshots/users-list.png)

---

🛠️ Technologies

Technology| Purpose
C#| Application development
.NET| Application framework
Windows Forms| Desktop UI
SQL Server| Database
ADO.NET| Data access
Visual Studio| Development
Git| Version control
GitHub| Source control & collaboration

---

🔍 Technical Highlights

This project provided practical experience with:

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

🧩 Challenges & Problem Solving

The most challenging part of the project was implementing the business workflows and maintaining consistency between related operations.

For example, a driving license application is not simply a single database record.

Managing these relationships required careful handling of business rules and application state.

Another major challenge was maintaining clean communication between the different architectural layers without allowing the Presentation Layer to become responsible for business decisions.

---

🎯 Project Objectives

The project was built with the following objectives:

- Practice building a complete desktop application.
- Apply 3-Layer Architecture in a real project.
- Improve understanding of relational database design.
- Implement real-world business rules.
- Work with ADO.NET and SQL Server.
- Build reusable and maintainable UI components.
- Understand how different modules interact within a larger system.
- Improve problem-solving and debugging skills.

---

🚀 Future Improvements

Possible future improvements include:

- Migrating the Business Layer to an ASP.NET Core Web API.
- Introducing Dependency Injection.
- Applying additional SOLID principles.
- Adding automated unit and integration tests.
- Introducing centralized logging.
- Improving authentication and authorization.
- Evaluating Entity Framework Core for selected data-access scenarios.
- Building a modern web frontend.
- Moving toward a more scalable architecture.

---

📚 Key Takeaways

The DVLD project was an important step in moving from writing individual features to designing a complete software system.

It strengthened my practical understanding of:

«Architecture, business logic, database relationships, application workflows, and maintainable software design.»

The main lesson was that building a real-world application is not only about making features work, but also about deciding where responsibilities belong, how components communicate, and how business rules are enforced consistently.

---

👨‍💻 Author

Khaled Mohamed

Junior .NET Software Engineer

Technical Focus

"C#" • ".NET" • "SQL Server" • "ADO.NET" • "Backend Development"

---

⭐ Repository

If you find the project useful or interesting, feel free to explore the source code and ⭐ the repository.

---

<p align="center">
  <strong>Built with C# • .NET • SQL Server • ADO.NET</strong>
</p>
