namespace CIAMTrial.Data
{
    using System;
    public class RequestDetail : IEntity
    {
        public int Id { get; set; }
        public int Folio { get; set; }
        public DateTime DepatureTime { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductName { get; set; }

        public Product Product { get; set; }
        public Request Request { get; set; }
    }
}
