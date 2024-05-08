using System;
using System.Collections.Generic;
using Web.Backend.Models;

namespace Web.Backend
{
    public static class DatabaseAccess
    {
        public static List<Document>? GetDocuments(string? searchString = null)
        {
            return new List<Document>()
            {
                new() 
                {
                    Id = 174, 
                    FileName = "The Caves of Steel.pdf", 
                    UploadedDate = DateTime.Parse("2024-03-29"),
                    UploadedBy = new User(){Id = 101, FirstName = "Isaac", LastName = "Asimov"}
                },
                new() 
                {
                    Id = 192, 
                    FileName = "Refactoring.pdf", 
                    UploadedDate = DateTime.Parse("2024-04-01"),
                    UploadedBy = new User(){Id = 108, FirstName = "Martin", LastName = "Fowler"}
                }
            }.Where(x => searchString == null || x.FileName.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }
    }
}