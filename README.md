## Backend Internship Challenge

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/3LSv9VRt)

### Assignment documentation

I started the task by setting up a database context using Entity Framework and establishing a connection to my database. However, during the querying process in `DatabaseAccess`, I ran into a problem with the Entity Framework naming convention for models within a `DBSet`. Specifically, EF prefers to append "Id" after the foreign key name, such as "UploadedBy" -> "UploadedById". As I couldn't find a straightforward solution, I solved this by editing the names in `FillDatabase.sql` to use "UploadedById", also I believe it's common practice to explicitly say it refers to Id.

Apart from that, the refactoring of the `GetDocuments` function went smoothly. When a search term is entered, the function tries to parse the date and integrate it into the query, and the same way it handles Filename, Firstname and Lastname lookups using the EF `Like` method, similar to the `LIKE` operator in SQL.
