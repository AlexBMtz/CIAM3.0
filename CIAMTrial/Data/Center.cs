namespace CIAMTrial.Data
{
    using System.Collections.Generic;
    public class Center : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string ManagerEmployee { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
