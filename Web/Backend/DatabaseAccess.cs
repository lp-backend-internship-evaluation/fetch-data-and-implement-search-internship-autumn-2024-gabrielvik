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
                .Include(d => d.UploadedBy) // Assures that the UploadedBy navigation property is included
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(d => d.FileName.Contains(searchString, StringComparison.OrdinalIgnoreCase));
            }

            return query.ToList();
        }
    }
}