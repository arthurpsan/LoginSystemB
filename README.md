# SistemaLoginB

This is a C# Windows Forms application that implements a login system. The application starts with a login screen (LoginScreen). This screen compares user input against username and password credentials hardcoded in the Login.cs file.

If authentication is successful, the login screen is hidden, and a main system screen (System) is displayed. This main screen is an MDI (Multiple Document Interface) container that displays the logged-in user's name and admin status in the window title.

The system screen contains a menu bar with options for "FIle" (Exit) and "Register". The "Register" menu has a "User" option that opens the RegisterUser form as a child window inside the MDI container. The menu also has an "Admin" option that is enabled or disabled based on the logged-in user's admin status (IsAdmin).

The RegisterUser form contains fields to enter a name, user, password, repeat password, and a checkbox to set the user as an admin. The logic to save the new user has not yet been implemented.

The project uses User and Credential classes to model the data. The LoginScreen, System, and RegisterUser forms are implemented using the Singleton design pattern, ensuring only one instance of each form is created.
