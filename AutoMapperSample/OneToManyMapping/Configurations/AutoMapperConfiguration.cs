using AutoMapper;
using AutoMapperSample.OneToManyMapping.Dto;
using AutoMapperSample.OneToManyMapping.Entities;
using AutoMapperSample.OneToManyMapping.ReadModel;

namespace AutoMapperSample.OneToManyMapping.Configurations
{
    internal class AutoMapperConfiguration
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Left, LeftResponseDto>();
                cfg.CreateMap<Right, RightResponseDto>();
                cfg.CreateMap<List<Right>, List<RightResponseDto>>();
                cfg.CreateMap<LeftRights, LeftRightsResponseDto>();
            });
        }
    }
}
