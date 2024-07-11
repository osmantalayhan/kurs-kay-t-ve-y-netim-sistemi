using System.ComponentModel.DataAnnotations;

namespace MVCProje.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is requireds.")]
        public string? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName is requireds.")]
        public string? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName is requireds.")]
        public string? LastName { get; set; } = String.Empty;

        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate(){
            ApplyAt = DateTime.Now;
        }
    }
}

