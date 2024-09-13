using ChaquitacllaError404.API.Crops.Domain.Model.Entities;
using ChaquitacllaError404.API.Crops.Domain.Model.Queries;

namespace ChaquitacllaError404.API.Crops.Domain.Services;

public interface IDiseaseQueryService
{
    Task<Disease?> Handle(GetDiseaseByIdQuery query);
    
    
    Task<IEnumerable<Disease>> Handle(GetAllDiseasesQuery query);
    
    Task<IEnumerable<Disease>> Handle(GetDiseaseByCropIdQuery query);
}