using ChaquitacllaError404.API.Crops.Domain.Model.Entities;
using ChaquitacllaError404.API.Shared.Domain.Repositories;

namespace ChaquitacllaError404.API.Crops.Domain.Repositories;

public interface IPestRepository : IBaseRepository<Pest>
{
   Task<IEnumerable<Pest>> FindAllAsync();
   
   Task<IEnumerable<Pest>> GetPestByCropIdQuery(int cropId);

   
}