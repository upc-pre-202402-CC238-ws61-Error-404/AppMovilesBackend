﻿using ChaquitacllaError404.API.Crops.Domain.Model.Aggregates;
using ChaquitacllaError404.API.Crops.Domain.Model.Queries;

namespace ChaquitacllaError404.API.Crops.Domain.Services;

public interface ICropQueryService
{
    Task<Crop?> Handle(GetCropByIdQuery query);
 
    /**
     * Return all products
     */
    Task<IEnumerable<Crop>> Handle(GetAllCropsQuery query);
}