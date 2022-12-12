namespace API.Domain
{
    public class Pump
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteId { get; set; }
        public string FuelType { get; set; }
        public decimal PricePerLitre { get; set; }
        public bool Locked { get; set; }
    }
}
