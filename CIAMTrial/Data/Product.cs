namespace CIAMTrial.Data
{
    using System.Collections.Generic;
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductTye { get; set; }
        public double AvaliableQuantity { get; set; }
        public string ProductQuality { get; set; }
        public ICollection<DonationDetail> DonationDetails { get; set; }
        public ICollection<RequestDetail> RequestDetails { get; set; }
    }
}
