using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Required")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Required")]
        public string? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Required")]
        public string? LastName { get; set; } = string.Empty;
        public string? FullName => $"{FirstName}{LastName?.ToUpper()}";
        public int? Age { get; set; }

        [Required(ErrorMessage = "Select at least one of the courses")]
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }

        public Candidate()
        {
            RegistrationDate = DateTime.Now;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Candidate other = (Candidate)obj;
            return Email == other.Email;
        }
        public override int GetHashCode()
        {
            return Email?.GetHashCode() ?? 0;
        }
    }
}