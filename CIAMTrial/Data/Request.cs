namespace CIAMTrial.Data
{
    using System.Collections.Generic;
    public class Request : IEntity
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string ShippingClerk { get; set; }

        public ICollection<RequestDetail> RequestDetails { get; set; }
        public Center Center { get; set; }

    }
}
