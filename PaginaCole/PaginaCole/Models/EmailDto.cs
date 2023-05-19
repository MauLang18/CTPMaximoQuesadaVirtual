using System.ComponentModel.DataAnnotations;

namespace PaginaCole.Models
{
    public class EmailDto
    {
        public string Subject { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        [DataType(DataType.MultilineText)]
        public string Body { get; set; } = string.Empty;
        public string Body2 { get; set; }
    }
}
