namespace Web.Backend.Models
{
    public class Document
    {
        public int Id { get; set; }
        public required string FileName { get; set; }
        public DateTime UploadedDate { get; set; }
        public required User UploadedBy { get; set; }
    }
}