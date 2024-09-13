﻿using ChaquitacllaError404.API.Crops.Domain.Model.Entities;
using ChaquitacllaError404.API.Shared.Domain.Repositories;

namespace ChaquitacllaError404.API.Crops.Domain.Repositories
{
    public interface IControlRepository : IBaseRepository<Control>
    {
        Task<IEnumerable<Control>> FindBySowingIdAsync(int sowingId);
        
        Task<IEnumerable<Control>> FindByIdAndSowingIdAsync(int id, int sowingId);
    }
}