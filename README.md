# BreviSite — Clean Architecture CRM System

BreviSite is a business-oriented **CRM application** developed for the Brevi company.  
Built on modern Blazor Web App (.NET 8) using **Clean Architecture**, it integrates Identity, PostgreSQL, AutoMapper, MediatR, and MudBlazor.

---

## 🔧 Technologies & Stack

- Blazor Web App (.NET 8) with interactive components
- MudBlazor UI components (dialogues, tables, forms, notifications)
- Entity Framework Core + PostgreSQL
- ASP.NET Core Identity (custom AppUser)
- AutoMapper
- MediatR (CQRS-ready)
- FluentValidation
- Clean Architecture (modular layers)

---

## 🏗️ Architecture Overview

```
/Web            - UI layer (Blazor components, Pages)
/Application    - UseCases, DTOs, Validators
/Domain         - Business entities and interfaces
/Infrastructure - DbContext, Repositories, Services
```

- One-way dependencies: UI → Application → Domain → Infrastructure  
- Supports interactive UI with Razor components  
- Ready for integration with background services and API

---


## 🔒 License

This source code is private and intended for internal use at Brevi.  
Reproduction or reuse without permission is not allowed.

© 2025 Brevi
