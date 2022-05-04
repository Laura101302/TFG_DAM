using AutoMapper;

public class PParticularProfile : Profile
{
    public PParticularProfile()
    {
        CreateMap<PParticularDTO, PParticularEntity>();
        CreateMap<PParticularEntity, PParticularDTO>();
        CreateMap<BasePParticularDTO, PParticularEntity>();
        CreateMap<PParticularEntity, BasePParticularDTO>();
    }
}
