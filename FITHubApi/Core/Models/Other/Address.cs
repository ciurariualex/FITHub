namespace Core.Models.Other
{
    public class Address
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Number { get; set; }
        public Location Location { get; set; }
    }
}