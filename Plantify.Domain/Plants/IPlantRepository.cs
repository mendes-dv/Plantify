using Plantify.Domain.Users;

namespace Plantify.Domain.Plants;

public interface IPlantRepository 
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(Plant plant);
}