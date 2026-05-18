# Car Rental Management System

A full-stack desktop application for managing car rentals, bookings, clients, payments, and system users.

Built using:

- .NET Framework
- WinForms
- SQL Server
- ADO.NET
- 3-Tier Architecture

---

# Features

## Authentication System

- User login system
- Username & password validation

## Car Management

- Add new cars
- Update existing cars
- Delete cars
- Upload car images
- Filter available cars by date range

## Client Management

- Add and update clients
- Search clients using:
  - ID
  - Phone Number
  - Email
  - National ID

## Booking System

- Create bookings
- Validate booking conflicts
- Calculate total booking price dynamically
- Filter bookings using multiple criteria

## Payment System

- Add payments
- Payment methods management
- Payment tracking

## Database Features

- SQL Server integration
- Foreign key constraints
- Unique constraints
- Business-level validation
- Exception handling using SQL exceptions

---

# Architecture

The project follows a classic 3-Tier Architecture:

- Presentation Layer (WinForms UI)
- Business Logic Layer (BAL)
- Data Access Layer (DAL)

This separation improves:

- Maintainability
- Scalability
- Readability
- Reusability

---

# Technologies Used

- C#
- WinForms
- SQL Server
- ADO.NET
- Guna UI2
- DataTables

---

# Project Structure

```text
Booking_Cars_Project/
│
├── Presentation Layer
├── BusinessAccessLayer
├── DataAccessLayer
├── Database
└── Assets
```

---

# Future Improvements

- Implement password hashing
- Add role-based authorization
- Improve UI/UX
- Add reporting system
- Export invoices and receipts
- Implement Repository Pattern
- Add unit testing

---

# Author

Hisham Elramy

---

# Notes

This project was developed as a practical learning project to improve understanding of:

- Desktop application development
- Database design
- Layered architecture
- Business logic implementation
- SQL Server integration
