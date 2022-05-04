using AutoMapper;

public class VParticularProfile : Profile
{
    public VParticularProfile()
    {
        CreateMap<VParticularDTO, VParticularEntity>();
        CreateMap<VParticularEntity, VParticularDTO>();
        CreateMap<BaseVParticularDTO, VParticularEntity>();
        CreateMap<VParticularEntity, BaseVParticularDTO>();
    }
}
