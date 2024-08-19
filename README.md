
# Bus Reservation Management System
Overview
The Bus Reservation Management System is a C# Windows Forms application utilizing Object-Oriented Programming (OOP) principles and integrated with SQL Server. It supports two user roles: Admin and Passenger, each with specific functionalities for managing and booking bus tickets.

# Features
Admin Panel
Manage Passenger Feedback: Update and review feedback from passengers.
Bus Management: Perform CRUD operations for bus details.
Route Management: Manage bus routes through CRUD operations.
Customer Information: View and manage customer details.
Passenger Panel
Book/Cancel Booking: Reserve or cancel tickets; account balance is adjusted automatically.
Add Feedback: Submit feedback about the service.
View Feedback: Check feedback submitted by yourself and others.
Account Management: Update account details and monitor balance.
View Routes: Browse available bus routes.
# Installation
Clone the Repository:
git clone https://github.com/yourusername/oopprojectbusreservation.git
Open the Solution:
Open the BusReservationSystem.sln file in Visual Studio.
Connect Database:

Ensure SQL Server is installed and running.
Open the App.config file in your project.
Update the connection string with your SQL Server details:
<connectionStrings>
  <add name="BusReservationDB" connectionString="Server=your_server_name;Database=your_database_name;User Id=your_username;Password=your_password;" providerName="System.Data.SqlClient"/>
</connectionStrings>
Build and Run:
Build the project by selecting Build > Build Solution in Visual Studio.
Run the application by pressing F5 or selecting Debug > Start Debugging.
# Technologies Used
Programming Language: C#
Framework: Windows Forms
Database: SQL Server
Development Environment: Visual Studio
Principles: Object-Oriented Programming (OOP)
