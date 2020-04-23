namespace CIAMTrial.Data
{
    using System.Collections.Generic;

    public class Donation : IEntity
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public string ReceiverEmployee { get; set; }
        public string ReceiverCenter { get; set; }

        public ICollection<DonationDetail>DonationDetails { get; set; }
    }
}
