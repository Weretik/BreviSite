# 🧩 BreviCRM — Internal Business Management System

**BreviCRM** is a modular CRM/ERP-style application developed for internal operations of the Brevi company.  
It is built using **.NET 8**, **Blazor Web App (Server)**, and follows a **Clean Architecture** approach with strict separation of concerns across layers.

---

## ⚙️ Tech Stack

- **.NET 8**, **Blazor Server**, **ASP.NET Core Identity**
- **CQRS** with **MediatR**
- **AutoMapper**, **FluentValidation**
- **Entity Framework Core** + **PostgreSQL**
- **Tailwind CSS**, **MudBlazor**
- **Modular monolith** architecture

---

## 📐 Project Structure

```
/Web            - Razor UI (Pages, Components)
/Application    - UseCases, CQRS, DTOs, Validators
/Domain         - Core business entities and interfaces
/Infrastructure - Persistence (DbContext), Repositories, Services
```

---

## 🧮 Key Modules

- **Accounting**  
  - Wallets  
  - Income / Expense operations  
  - Cash register / balance tracking

- **Manager’s Workspace**  
  - Clients & leads  
  - Deals and quotes (КП)  
  - Task tracking and statuses

- **Production / Workshop**  
  - Sewing schedule  
  - Salary and payroll tracking  
  - Fabric and materials

- **System modules**  
  - Directory management  
  - Access control (Identity + roles)  
  - Reports & analytics

---

## 📦 Architectural Highlights

- Modular monolith with layered separation
- CQRS flow with MediatR and AutoMapper
- Identity-based authorization with custom roles
- Razor UI + MudBlazor for rich interactions
- GitHub Copilot Agent integrated to speed up boilerplate generation

---

## 📌 Project Status

✅ Base architecture & infrastructure complete  
✅ Wallets module in progress  
🔜 Income/Expense tracking  
🔜 Manager dashboard  
🔜 Role-based permissions  
🔜 Reports and KPIs

---

## 🔒 License

This codebase is private and developed for internal use at Brevi.  
Reproduction or redistribution without explicit permission is prohibited.

© 2025 Brevi
