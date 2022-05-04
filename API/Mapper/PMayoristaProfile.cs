using AutoMapper;

public class PMayoristaProfile : Profile
{
    public PMayoristaProfile()
    {
        CreateMap<PMayoristaDTO, PMayoristaEntity>();
        CreateMap<PMayoristaEntity, PMayoristaDTO>();
        CreateMap<BasePMayoristaDTO, PMayoristaEntity>();
        CreateMap<PMayoristaEntity, BasePMayoristaDTO>();
    }
}
