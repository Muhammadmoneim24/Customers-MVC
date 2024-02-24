using AutoMapper;
using Mvc_Day2.Models;

namespace Mvc_Day2.Utilities
{
    public class MapperProfiles:Profile
    {
        public MapperProfiles()
        {
            CreateMap<Customer, Customer>(); 
        }

    }
}
