using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.Backend.Data;
using Web.Backend.Models;

namespace Web.Backend
{
    public static class DatabaseAccess
    {
        private static readonly AssignmentContext _context = new AssignmentContext(new DbContextOptions<AssignmentContext>());

        public static List<Document> GetDocuments(string? searchString = null)
        {
            var query = _context.Documents
                .Include(d => d.UploadedBy) // Include the UploadedBy navigation property
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                string searchLower = searchString.ToLower(); // Convert search string to lower case

                // Check if the search string is a valid date
                if (DateTime.TryParse(searchLower, out DateTime searchDate))
                {
                    // If it's a valid date, filter by UploadedDate
                    query = query.Where(d => d.UploadedDate.Date == searchDate.Date);
                }
                else
                {
                    // Otherwise, perform text search on FileName, FirstName, and LastName
                    query = query.Where(d =>
                        EF.Functions.Like(d.FileName.ToLower(), "%" + searchLower + "%") ||
                        EF.Functions.Like(d.UploadedBy.FirstName.ToLower(), "%" + searchLower + "%") ||
                        EF.Functions.Like(d.UploadedBy.LastName.ToLower(), "%" + searchLower + "%"));
                }
            }

            return query.ToList();
        }
        public static void DeleteDocument(int id)
        {
            var documentToDelete = _context.Documents.Find(id);

            if (documentToDelete != null)
            {
                _context.Documents.Remove(documentToDelete);
                _context.SaveChanges();
            }
        }
        public static void EditDocument(int id, string newFileName)
        {
            var documentToEdit = _context.Documents.Find(id);

            if (documentToEdit != null)
            {
                documentToEdit.FileName = newFileName;

                _context.SaveChanges();
            }
        }

    }
}