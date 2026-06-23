Smart Eco Campus Management System (SECMSS) 
A 4-Layered OOP Solution for Sustainable Campus Maintenance
 Project Overview
The Smart Eco Campus Management System is a  desktop application built using C# and SQL Server. It aims to digitize the waste management process within a university campus, providing a structured workflow for reporting, tracking, and resolving environmental issues.

The system follows a strict 4-Layer Architecture (Model, Data Access, Business Logic, and Presentation Layer) to ensure maximum maintainability and scalability.

System Architecture
This project is built using 4-Layer Architecture:

Model Layer: Encapsulated Entities.
Data Access Layer (DL): Handles SQL Connection management and  CRUD queries using Interfaces.
Business Logic Layer (BL):  Enforcing validations, ownership rules, and search algorithms.
Presentation Layer (UI): A user-friendly Windows Forms interface driven by events.
 Key Features
 Role-Based Dashboards
Reporter (Student/Staff):
Secure Signup & Login.
Add waste reports with specific categories (Organic, Plastic, etc.).
Update and Delete OWN reports (Ownership verification enforced).
Submit and view personal feedback.
Permanent account deletion with automated data cleanup.
Supervisor:
Global view of campus-wide reports.
Task Assignment logic (Status tracking).
Marking reports as "Completed."
Admin:
Complete system oversight.
Manage all registered users and global reports.
Reverse Cross-Searching: Advanced bidirectional navigation between reports and owners.
Advanced Search Logic
Implemented a custom Reverse Searching Algorithm using manual list iteration (backwards) to prioritize the most recent data, demonstrating a deep understanding of data structures.

OOP Principles Implemented
Encapsulation: All model fields are private, exposed only via public properties with validation.
Inheritance: Used a base UserModel with specialized Admin, Supervisor, and Reporter child classes.
Abstraction: Implemented Abstract Classes for user templates and Interfaces (IUserDL, IReportDL) for the Data Layer to follow SOLID principles.
Polymorphism:
Method Overriding: Role-specific welcome messages using virtual and override.
Method Overloading: Multiple constructors and flexible data retrieval methods.
Composition: Strong life-cycle management between Reporter and Reports. Deleting a user automatically purges associated data via SQL Cascading Deletes.
 Database Schema
The backend is powered by MS SQL Server with the following relational structure:

Users: Managed identity and role-based access.
Reports: Tracked locations, waste types, and statuses.
Feedback: Persistent user-generated system reviews.
 Tech Stack
Language: C# (.NET Framework)
UI: Windows Forms (WinForms)
Database: Microsoft SQL Server
Architecture: 4-Layer 
Tools: Visual Studio 2026, SQL Server Management Studio (SSMS)
 Setup & Installation
Clone the repository.
Open the SQL script provided in the /Database folder and run it in SSMS.
Update the ConnectionString in DbConfig.cs with your local SQL Server instance name.
Open the .sln file in Visual Studio.
Build and Run.
