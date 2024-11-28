# InlandMarinaApp

# CPRG 214 Lab Assignment 1 - README

## To-Do List

- [ ] Set up the **ASP.NET Core MVC application**.
- [ ] Implement the **Entity Framework Code-First approach** to create the database.
- [ ] Create the **Home Page** with general information about Inland Marina.
- [ ] Create the **Contact Page** with contact details and a link back to the Home Page.
- [ ] Create the **Slips Page** to display available boat slips and allow filtering by dock.
- [ ] Set up **database context and entity classes** in a separate class library project.
- [ ] Implement **Bootstrap** and **CSS** for styling the website.
- [ ] Integrate **corporate logo** and **boat/marina images**.
- [ ] Test the application to ensure it meets all requirements and functions correctly.
- [ ] Take **screenshots** of each page and document functionality in a Word file.
- [ ] Zip the entire project folder and submit the assignment.

## Order of Completion

1. **Set up the ASP.NET Core MVC application** and ensure the basic project structure is in place.
2. **Create the Entity Framework Code-First classes** (Dock, Slip, Customer, Lease) and set up the database context in a separate class library project.
3. **Implement database integration** and ensure the connection works properly.
4. **Develop the Home Page** to display general information about Inland Marina.
5. **Create the Contact Page** with contact details and links.
6. **Develop the Slips Page** to display available slips and allow filtering by dock.
7. **Style the application** using Bootstrap and CSS for a corporate look and feel.
8. **Integrate the corporate logo** and any boat/marina images.
9. **Test the application** to ensure it meets all the required functionality.
10. **Document the pages** with screenshots and explanations in a Word file.
11. **Zip and submit** the project folder and Word document.

## Overview

This assignment involves creating a simple web application for Inland Marina Ltd., a marina company located on Inland Lake. The application will be developed using ASP.NET Core MVC and will utilize Entity Framework with the Code-First approach to manage the marina's leasing services. This project will consist of three main pages and will allow customers to view available boat slips and contact the marina for more information.

## Objectives

- **Develop a web application** with three pages using ASP.NET Core MVC.
- **Use Entity Framework (Code-First)** to create a database and retrieve data for managing the marina's slip leasing process.
- **Design the application** to allow users to browse available boat slips and view marina contact information.

## Features

### 1. **Home Page**
   - Display general information about Inland Marina.
   - Include a navigation button/link to the **Contact Us** page.

### 2. **Contact Page**
   - Show contact details for Inland Marina, including address, phone numbers, and email.
   - Include a link back to the **Home** page.

### 3. **Slips Page**
   - Display a list of available (unleased) boat slips.
   - Allow filtering of available slips by selecting a specific dock.

### 4. **Design and Styling**
   - Use **Bootstrap** and **CSS** to ensure a professional, corporate look.
   - Incorporate the supplied corporate logo (800x100 px).
   - Include appropriate boat and marina images.

### 5. **Entity Framework Database**
   - Create an `InlandMarina` database using Entity Framework Code-First.
   - Use provided entity classes and the context class, which should be placed in a **class library project** separate from the MVC application.

## Application Pages

- **Home Page**: Overview of Inland Marina, its history, and a description of the facilities.
- **Contact Page**: Provides marina contact details, including address, phone numbers, and manager information.
- **Slips Page**: Displays available slips and allows filtering by dock.

## Database Schema

The database will include the following entities:

- **Dock**: Contains information about the docks.
- **Slip**: Contains details about individual slips, such as width and length.
- **Customer**: Contains customer information (ID, name, contact info).
- **Lease**: Connects customers to leased slips.

## Marking Scheme

| Component                                                              | Points |
|------------------------------------------------------------------------|--------|
| Entity classes and context class are implemented in a class library    | 10     |
| ASP.NET Core MVC project with specified pages and navigation           | 10     |
| Slips page displays only available slips                               | 10     |
| User can filter available slips by selecting a dock                    | 10     |
| Application has a professional, corporate look with a logo             | 5      |
| Code is well-organized, clear, and uses good naming practices         | 5      |
| **Total**                                                              | **50** |

## Submission

### Required Files

1. A zip file containing the entire project folder.
2. A Word document with:
   - Screenshots of all pages showing required functionality.
   - Short explanations of what each screenshot demonstrates.

### Deadline

- The assignment must be submitted before the due date.
- Late submissions will incur a penalty of 3 points per day unless a valid reason is provided.

## Important Notes

- You can work individually or in pairs. If working in pairs, submit the assignment with both names clearly indicated.
- You may discuss your approach with other students or the instructor, but the work should be done independently.
- You may reuse code created or posted in the course.


