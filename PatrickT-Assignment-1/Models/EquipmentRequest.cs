using System.ComponentModel.DataAnnotations;

namespace PatrickT_Assignment_1.Models
{
    public enum UserRole
    {
        Student,
        Professor
    }

    public enum Equipment
    {
        Laptop,
        Phone,
        Tablet,
        Another
    }

    public class EquipmentRequest
    {
        private static int _id = 1;

        public EquipmentRequest()
        {
            Id = _id++;
        }

        public int Id { get; private set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a vaild email address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx.")]
        public string? PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public Equipment EquipmentType { get; set; }
        [Required(ErrorMessage = "Please enter request details")]
        public string? RequestDetails { get; set; }
        [Required(ErrorMessage = "Please enter the duration")]
        [Range(0, int.MaxValue, ErrorMessage = "Duration must be a positive number")]
        public int? Duration { get; set; }

    }
}