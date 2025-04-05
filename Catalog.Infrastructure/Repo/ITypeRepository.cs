using Catalog.Core.Entities;

namespace Catalog.Infrastructure.Repo
{
    public interface ITypeRepository
    {
        Task<IEnumerable<ProductType>> GetAllTypes();
    }
}