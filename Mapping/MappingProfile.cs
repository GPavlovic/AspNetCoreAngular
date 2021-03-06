using AspNetCoreAngular.Controllers.Resources;
using AspNetCoreAngular.Models;
using AutoMapper;

namespace AspNetCoreAngular.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}