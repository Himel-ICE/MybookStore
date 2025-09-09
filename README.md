# MyBookStore

MyBookStore is a sample e-commerce web application for purchasing books online.  
It follows **N-Tier architecture**, implements the **Unit of Work** pattern for clean data handling, and integrates the **Stripe Payment Gateway** for secure checkout.  

---

## Features  

- **N-Tier Architecture** (Presentation, Application, Infrastructure, Domain)  
- **Unit of Work & Repository Pattern** for clean and maintainable data access  
- **Stripe Payment Gateway Integration** for secure transactions  
- Authentication & Authorization with ASP.NET Identity  
- Shopping Cart & Order Management  
- Book Catalog with Search and Filters  
- Admin Dashboard for managing books and orders  

---

## Architecture Overview  

The project uses a **4-tier N-Tier Architecture**:  


---

## Unit of Work Pattern  

The **Unit of Work** ensures all database operations within a transaction are **committed or rolled back together**.  

✔ Prevents partial updates  
✔ Centralized transaction management  
✔ Simplifies repository usage  

---

## Stripe Payment Integration  

- Integrated with **Stripe API** for secure payments  
- Supports credit/debit card checkout  
- Configurable for **test mode** and **production mode**  

---

## Tech Stack  

- **Framework**: .NET 8  
- **Database**: SQL Server (EF Core ORM)  
- **Authentication**: ASP.NET Identity  
- **Payment Gateway**: Stripe  
- **UI**: Razor Pages / MVC with Bootstrap  

---

## Getting Started  

### Prerequisites  

- [.NET 8 SDK](https://dotnet.microsoft.com/download)  
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)  
- [Stripe Account](https://stripe.com/) + API Keys  

### Setup Instructions  
- Update AppSetting.json with proper connection string 
- "Stripe": { "PublishableKey": "your-publishable-key", "SecretKey": "your-secret-key"}

- add- migration

- update database 

### For login

- username: admin@gmail.com

- Password: @Admin123
