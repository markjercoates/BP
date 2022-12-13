using API.Dtos;
using API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    /// <summary>
    /// Site Repository to perform crud opertions against the EF DbContext
    /// </summary>
    public class SiteRepository : ISiteRepository
    {
        private DataContext _dataContext;
        public SiteRepository(DataContext context)
        {
            _dataContext= context;
        }

        /// <summary>
        /// Search to return a list of sites with pumps where
        /// site name or town or postcode contains search term.
        /// </summary>
        /// <param name="searchTerm">searchTerm to search for</param>
        /// <returns>A list of up to 10 <see cref="SiteDto"/>Sites</returns>
        public async Task<List<SiteDto>> GetSites(string searchTerm)
        {
            searchTerm = !string.IsNullOrEmpty(searchTerm) ? searchTerm.ToLower() : string.Empty;
            var results = await _dataContext.Sites.Include(s => s.Pumps)
                        .Where(site => site.Name.ToLower().Contains(searchTerm) ||
                               site.Town.ToLower().Contains(searchTerm) ||
                               site.PostCode.ToLower().Contains(searchTerm)
                               )
                        .Take(10)
                        .ToListAsync();

            return results.MapSitesToDtos();
        }
    }
}
