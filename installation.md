# SmartFoods Installation Guide

This guide will help you set up the SmartFoods project from scratch on any machine.

## Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Node.js (for Tailwind CSS)](https://nodejs.org/) (Recommended LTS)
- [Git](https://git-scm.com/)

---

## 1. Clone the Repository

```
git clone <your-repo-url>
cd SmartFoods
```

---

## 2. Restore and Build .NET Solution

```
dotnet restore
```

---

## 3. Install All NuGet Dependencies (if not already restored)

```
dotnet build
```

---

## 4. Install Tailwind CSS (for UI styling)

Navigate to the Web project directory:

```
cd src/SmartFoods.Web
```

Initialize npm and install Tailwind CSS:

```
npm init -y
npm install -D tailwindcss postcss autoprefixer
npx tailwindcss init -p
```

---

## 5. (Optional) Install VS Code Extensions
- C# Dev Kit
- Tailwind CSS IntelliSense
- EditorConfig for VS Code

---

## 6. Run the Application

From the solution root:

```
dotnet run --project src/SmartFoods.Web/SmartFoods.Web.csproj
```

---

## 7. Running Tests

```
dotnet test
```

---

## 8. Additional Notes
- For database setup, see future database configuration steps in the implementation tracker.
- For environment variables and secrets, use `appsettings.Development.json` (not committed to git).

---

You're ready to develop and run SmartFoods!
