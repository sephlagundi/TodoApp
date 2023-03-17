namespace SMSApp.Models
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }  
        public string State { get; set; }
        public string Country  { get; set; }

        public StudentAddress () { }

        public StudentAddress(int studentAddressId, string address, string city, string state, string country)
        {
            StudentAddressId = studentAddressId;
            Address = address;
            City = city;
            State = state;
            Country = country;
        }
    }
}
