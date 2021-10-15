using AutoMapper;
using AutoMapperSample.OneToOneMapping.Dto;
using AutoMapperSample.OneToOneMapping.Entities;
using AutoMapperSample.OneToOneMapping.ReadModel;

namespace AutoMapperSample.OneToOneMapping.Configurations
{
    internal class AutoMapperConfiguration
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Left, LeftResponseDto>();
                cfg.CreateMap<Right, RightResponseDto>();
                cfg.CreateMap<LeftRight, LeftRightResponseDto>();
            });
        }
    }
}
