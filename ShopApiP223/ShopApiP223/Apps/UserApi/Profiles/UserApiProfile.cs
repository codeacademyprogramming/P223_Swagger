using AutoMapper;
using ShopApiP223.Apps.UserApi.DTOs.AccountDtos;
using ShopApiP223.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApiP223.Apps.UserApi.Profiles
{
    public class UserApiProfile:Profile
    {
        public UserApiProfile()
        {
            CreateMap<AppUser, AccountGetDto>();
        }
    }
}
