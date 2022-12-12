using API.Dtos;

namespace API.Data
{
    public interface ISiteRepository
    {
        public Task<List<SiteDto>> GetSites(string searchTerm);
    }
}
