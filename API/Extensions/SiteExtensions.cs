using API.Domain;
using API.Dtos;

namespace API.Extensions
{
    public static class SiteExtensions
    {
        public static List<SiteDto> MapSitesToDtos(this List<Site> sites)
        {
            return sites.Select(site =>
            {
                return new SiteDto
                {
                    Id = site.Id,
                    Name = site.Name,
                    Street = site.Street,
                    Town = site.Town,
                    PostCode = site.PostCode,
                    Pumps = site.Pumps.Select(item => new PumpDto
                    {
                        Id = item.Id,
                        SiteId = item.SiteId,
                        Name = item.Name,
                        PricePerLitre = item.PricePerLitre,
                        FuelType = item.FuelType,
                        Locked = item.Locked,
                    }).ToList()
                };
            }).ToList();

        }
    }
}
