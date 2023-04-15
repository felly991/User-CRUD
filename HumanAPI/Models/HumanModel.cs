namespace HumanAPI.Models
{
    public class HumanModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string FamilyStatus { get; set; } = string.Empty;
        public string Company { get; set;} = string.Empty;
        public DateTime? DateRegistration = DateTime.UtcNow;
        public DateTime? BirthDate { get; set; }
    }
}
