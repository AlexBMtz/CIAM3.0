namespace CIAMTrial.Data
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Area { get; set; }
        public string ImageUrl { get; set; }

        public Center Center { get; set; }

    }
}
