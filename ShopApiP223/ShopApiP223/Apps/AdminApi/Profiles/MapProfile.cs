using AutoMapper;
using ShopApiP223.Apps.AdminApi.DTOs.CategoryDtos;
using ShopApiP223.Apps.AdminApi.DTOs.ProductDtos;
using ShopApiP223.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApiP223.Apps.AdminApi.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryGetDto>();
            CreateMap<Category, CategoryInProductGetDto>();

            CreateMap<Product, ProductGetDto>()
                .ForMember(dest => dest.Profit, map => map.MapFrom(src => src.SalePrice - src.CostPrice));

        }
    }
}
