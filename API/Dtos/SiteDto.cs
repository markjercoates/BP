using API.Domain;

namespace API.Dtos
{
    public class SiteDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public ICollection<PumpDto> Pumps { get; set; } = new List<PumpDto>();
    }
}
