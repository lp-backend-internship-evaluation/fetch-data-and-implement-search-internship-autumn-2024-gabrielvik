# Backend Internship Challenge

This is a selection test for backend developers applying for internship at Learnpoint.

You should extend this website to fetch and search data from a database.

## Get up and running

1. Make sure you have .NET 8.0 SDK installed.
2. Clone and open the solution in your prefered IDE (VS Code, Visual Studio etc.).
4. Build and Run the project Web.
5. You should see a web page with a list of two documents.

## Assignment

The documents are not fetched from a database. You should create a database and fetch documents from that database and implement search. Write the code as simple and lean as you can. Document your toughts and how you solved the assignment in a Markdown (.md) file.

### Preparation

Create a new branch and check it out (commit your changes to this new branch).

Create a MS SQL Server Database. Create it locally on your machine or a Azure SQL Database.

Run the script FillDatabase.sql against your database to create tables and insert data to work with.

### Fetch data from the database

Rewrite the code in DatabaseAccess.cs to fetch the documents from the database. Use your prefered technique for fetching the data (ADO.NET, Entity Framework etc.).

### Implement search

On the web page there is a search textbox that posts the search string to a controller action if you hit Enter. 

* Search in FileName, FirstName and LastName.
* The search should be done on the server (not in the browser).
* Implement search as good as you can. Think about how the user would like the search to work.

### Document your assignment process

Document how your search works and how your thought process went during the assignment in a Markdown (.md) file.

## Submit your contribution

This description describes how you complete the assignment you got from Github Classroom.

* Make sure you have committed your changes to the new branch
* Push changes to the Github Classroom repository
* Create a Pull request to merge you new branch to main

## Extra features

Feel free to implement functionality to add, edit and delete documents.
