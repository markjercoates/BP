using API.Dtos;

namespace API.Data
{
    public interface ISiteRepository
    {
        public List<SiteDto> GetSites(string searchTerm);
    }
}
