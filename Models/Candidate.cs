namespace CourseApp.Models
{
    public class Candidate
    {
        public string? Email { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }

        public Candidate()
        {
            RegistrationDate = DateTime.Now;
        }
    }
}