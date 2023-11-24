namespace Programowanie_ASP.NET.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && BirthDate < DateTime.Now;
        }

        public int CalculateAge()
        {
            TimeSpan ageSpan = DateTime.Now - BirthDate;
            int age = (int)(ageSpan.TotalDays / 365.25);
            return age;
        }   
    }
}
