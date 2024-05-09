using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Backend;
using Web.Backend.Models;

namespace Web.Pages
{
    public class EditDocumentModel : PageModel
    {
        public Document? Document { get; set; }
        public void OnGet(int documentId)
        {
            SetDocument(documentId);
        }

        public void OnPostUpdateDocument(int documentId, string fileName)
        {
            DatabaseAccess.EditDocument(documentId, fileName);
            SetDocument(documentId);
        }

        private void SetDocument(int documentId)
        {
            Document = DatabaseAccess.GetDocuments().FirstOrDefault(d => d.Id == documentId);
        }
    }
}
