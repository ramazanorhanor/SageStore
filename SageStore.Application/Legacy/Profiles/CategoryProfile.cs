using AutoMapper;
using SageStore.Application.Legacy.Responses;
using SageStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SageStore.Application.Legacy.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryResponseDTO>();
        }
    }
}
