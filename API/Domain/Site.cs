namespace API.Domain
{
    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public ICollection<Pump> Pumps { get; set; } = new List<Pump>();
    }
}
