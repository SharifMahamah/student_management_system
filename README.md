# 🎓 Student Management System (VB.NET)

A simple Windows Forms application for student registration, course management, grading, and attendance.

This project is built with **VB.NET (Visual Studio 2022)** and uses a **local SQL Server** database with **dummy data**.

---

## 📋 Features

✅ Register students and assign a major (`Programme_id`), which assigns courses based on the specific major  
✅ Edit student records  
✅ Manage and update student grades  
✅ Secure login form (dummy user account)  
✅ Uses SQL Server for local data storage

---

## 🗂️ Project Structure
STUDENT_MANAGEMENT_SYSTEM/
 ├─ Database/
 │   └─ StudentEvalSystem.bak
 ├─ GRPPROJECT/
 │   ├─  [VB.NET project files]
 │   ├─ App.config  
 ├─ STUDENT_MANAGEMENT_SYSTEM.sln
 ├─ README.md
 ├─ .gitignore



---

## 🛠️ Setup Instructions

Follow these steps to get the Student Management System running on your local machine.

---

### 1️⃣ Restore the database

1. Open **SQL Server Management Studio (SSMS)**.  
2. Right-click `Databases` → `Restore Database`.  
3. Choose **Device** → browse to `Database/StudentEvalSystem.bak` in this repository.  
4. Restore it with the name **`StudentEvalSystem`**.

---

### 2️⃣ Update the hardcoded connection string

This project currently uses a **hardcoded SQL Server connection string** located inside the `dbConnection` form.

- **Where it is:**  
  In your Visual Studio project, find the form named **`dbConnection.vb`** (inside `GRPPROJECT/`).

- **What it does:**  
  The `dbConnection` form handles the database connection.  
  Every other form that interacts with the database **creates an instance** of `dbConnection` to reuse this connection.

- **What you must do:**  
  Open `dbConnection.vb` and locate the `SqlConnection` or `connectionString` line.  
  Update the `Server` part to match your local SQL Server instance.

  ```vb
  Private connectionString As String = "Server=YOUR_SERVER;Database=StudentEvalSystem;Integrated Security=True;"



IMPORTANT:
The App.config file included in this repo is for reference only.
By default, the app ignores it — the connection string is hardcoded in dbConnection.vb.

3️⃣ Open and run
Open the solution in Visual Studio 2022.

Build the project.

Run the application.
---

## 🔑 Default login credentials

| Username | Password |
|----------|----------|
| `2020`   | `UPSA2024` |
| `2022`   | `UPSA2024` |

> These dummy users are stored in the database.  
> The login form will authenticate using these records.


## 📜 Notes

This project uses a local dummy database. No sensitive or real-world data is included.

The .bak file can be restored to any SQL Server instance.

If you want to switch to using the App.config connection string, you’ll need to refactor your code to read it like this:
  ```vb
ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
