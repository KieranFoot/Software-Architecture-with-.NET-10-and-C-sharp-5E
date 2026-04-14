using PackagesManagementDomainServices.DTOs;
using PackagesManagementDomainServices.Repositories;


namespace PackagesManagementApplicationServices.Queries
{
    public class PackagesListQuery(IPackageRepository repo): 
        IPackagesListQuery
    {   
        public async Task<IList<PackageInfosDTO>> GetAllPackages()
        {
            return await repo.GetAllInfo();
        }
    }
}
