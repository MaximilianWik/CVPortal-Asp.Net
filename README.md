# CVPortalen

An ASP.NET Core MVC web application for creating and sharing CVs, personal profiles, and collaborative projects. Built with .NET 8, Entity Framework Core, and ASP.NET Core Identity.

## Features

- **Account management** — registration, login/logout, and password change via ASP.NET Core Identity (`AccountController`)
- **CV builder** — create, view, and edit CVs with education, skills, and experience fields (`CVSidaController`)
- **Profiles** — create/edit a personal profile with photo upload, privacy toggle (public/private), and profile search (`ProfilerController`)
- **Projects** — create projects, join/leave as a participant, and edit/remove project details (`ProjektsidaController`)
- **Messaging** — send messages between users and manage an inbox with read/unread status (`MessageController`)

## Tech Stack

- **Framework**: ASP.NET Core MVC (.NET 8)
- **ORM**: Entity Framework Core 8 (with lazy-loading proxies)
- **Database**: SQL Server (LocalDB by default)
- **Auth**: ASP.NET Core Identity (`Anvandare` extends `IdentityUser`)

## Project Structure

```
CVPortalen/
├── Controllers/     # AccountController, CVSidaController, ProfilerController,
│                     ProjektsidaController, MessageController, HomeController
├── Models/          # Anvandare (User), CV, Profil, Projekt, Message, ProfilContext (DbContext)
├── Views/           # Razor views grouped by controller/feature
├── Migrations/      # EF Core migrations
├── Validering/       # Custom validation logic
├── wwwroot/         # Static assets (CSS, JS, images)
├── appsettings.json # Configuration (connection strings, logging)
└── Program.cs       # App startup and middleware pipeline
```

## Data Model

- `Anvandare` (User) — extends Identity's `IdentityUser`; has one `CV`, one `Profil`, many `Projekt`, and sent/received `Message`s
- `CV` — one-to-one with a user; education, skills, and past experience
- `Profil` — one-to-one with a user; name, address, phone, email, profile picture, and a privacy flag
- `Projekt` — a project with a name, year, and a list of participating users
- `Message` — sender/receiver messages with timestamp and read state

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server (or LocalDB, which is the default)

### Setup

1. Clone the repository
2. Update the connection string in `appsettings.json` if needed (defaults to LocalDB):
   ```json
   "ConnectionStrings": {
     "ProfilContext": "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=aspnet-CVProjekt;Integrated Security=SSPI"
   }
   ```
3. Apply EF Core migrations to create the database:
   ```
   dotnet ef database update
   ```
4. Run the application:
   ```
   dotnet run
   ```
5. Navigate to `https://localhost:<port>` in your browser.

## Notes

- The codebase mixes Swedish and English naming (`Anvandare` = User, `Profil` = Profile, `Projekt` = Project, `Meddelande`/`Message`).
- `Startup.cs` is present but fully commented out and unused — configuration lives in `Program.cs` (minimal hosting model).
- Some migration names and comments in the codebase are informal placeholders from development and should be cleaned up before production use.
