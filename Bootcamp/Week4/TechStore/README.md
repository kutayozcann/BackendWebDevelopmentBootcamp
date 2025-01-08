# TechStore Application

## Overview
The **TechStore** application is a simple console-based program that allows users to create and manage electronic devices, including **Phones** and **PCs**. It demonstrates the use of object-oriented programming (OOP) principles such as **inheritance**, **abstraction**, and **polymorphism**.

## Features
- Allows users to create **Phone** or **PC** objects.
- Collects and displays details about the created products.
- Validates user inputs for fields like **USB ports** and **license status**.
- Implements reusable base class (**BaseMakine**) with common properties and methods.
- Supports extended features for phones and PCs using **inheritance**.

## Files
- **BaseMakine.cs**: Contains the base class and derived classes for products.
- **Program.cs**: Contains the main program logic to interact with the user.

## Example Input/Output
```
Welcome to Tech Store!
Enter 1 to create a Phone
Enter 2 to create a PC
Your Choice: 1
Please enter a serial number: 12345
Please enter a name: Galaxy S23
Please enter a description: Samsung phone
Please enter a operating system: Android
Does this phone have Turkish license?
Enter 'y' for yes or enter 'n' for no
Licence choice: y
Your phone name ===> Galaxy S23
Production Date: 2024-01-09
Name: Galaxy S23
Description: Samsung phone
Serial Number: 12345
Operating System: Android
Tr Licenced: True
```

