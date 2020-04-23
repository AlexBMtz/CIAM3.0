namespace CIAMTrial.Data
{
    using System;
    public class DonationDetail : IEntity
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public DateTime AdmissionDate { get; set; }
        public double  Quantity { get; set; }
        public string DonationType { get; set; }

        public Donation Donation { get; set; }
        public Product Product { get; set; }
    }
}
