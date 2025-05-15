using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key]
        public int DairyId { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 50 Characters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the description")]
        public string Description { get; set; } = string.Empty ;

        [Required(ErrorMessage = "Please select a date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
