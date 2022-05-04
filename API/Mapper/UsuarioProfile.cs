using AutoMapper;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<UsuarioDTO, UsuarioEntity>();
        CreateMap<UsuarioEntity, UsuarioDTO>();
        CreateMap<BaseUsuarioDTO, UsuarioEntity>();
        CreateMap<UsuarioEntity, BaseUsuarioDTO>();
    }
}
