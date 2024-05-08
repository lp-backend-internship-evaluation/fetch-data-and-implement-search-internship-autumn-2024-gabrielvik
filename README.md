[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/3LSv9VRt)
# Backend Internship Challenge

## Assignment Documentation
I began by creating a database context with Entity Framework and hooked it up with my database. However, when I started to query it in DatabaseAccess I stumbled upon a problem where EF likes to name the models in the DBSet in a particular way, namely to put Id after a foreign key "UploadedBy" -> "UploadedById". I found no easy way around this, and I also belive its an unusual practice not to specify its refering to an Id, so I changed it to UploadedById in the FillDatabase.sql.
Other than that, the refactoring of the GetDocuments went pretty smoothly. If a search is inputted, it tries to parse a date and includes it to the query, and the same with Filename, Firstname and Lastname using the EF Like method, derived from SQL LIKE. 
