using System.ComponentModel;

namespace PracticeApplication.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string CountryOfStay { get; set; }
        public int Age { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime Dob { get; set; }
        public bool IsMarried { get; set; }
    }
    public enum Gender
    {
        None,
        Male,
        Female,
        Other
    }
}
