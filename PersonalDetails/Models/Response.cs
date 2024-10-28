namespace PersonalDetails.Models
{
    public class ResponseObject
    {
        public int Vowels { get; set; }
        public int Age { get; set; }
        public int DaysUntillBirthday { get; set; }
        public List<string> Days14 { get; set; } = [];
    }
}
