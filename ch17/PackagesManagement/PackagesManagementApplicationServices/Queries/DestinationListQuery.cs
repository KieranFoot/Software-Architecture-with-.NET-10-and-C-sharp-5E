using PackagesManagementDomainServices.DTOs;
using PackagesManagementDomainServices.Repositories;

namespace PackagesManagementApplicationServices.Queries
{
    public class DestinationListQuery(IDestinationRepository repo) : 
        IDestinationListQuery
    {
        public async Task<IEnumerable<KeyDisplayPair<int, string>>> AllDestinations()
        {
            return await repo.GetAllShort();
        }
    }
}
