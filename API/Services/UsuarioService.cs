using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class UsuarioService : IUsuarioService
{
    private readonly PopZoneContext _context;
    private readonly IMapper _mapper;

    public UsuarioService(PopZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public UsuarioDTO Add(BaseUsuarioDTO baseUsuario)
    {
        var _mappedUsuario = _mapper.Map<UsuarioEntity>(baseUsuario);
        var entityAdded = _context.Usuarios.Add(_mappedUsuario);
        _context.SaveChanges();
        return _mapper.Map<UsuarioDTO>(entityAdded);
    }

    public void Delete(string guid)
    {
        UsuarioEntity usuario = _context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == guid);

        if (usuario == null)
            throw new ApplicationException($"Usuario with email {guid} not found");

        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();
    }

    public IEnumerable<UsuarioDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<UsuarioDTO>>(_context.Usuarios.Select(x => x));
    }

    public UsuarioDTO GetByEmail(string guid)
    {
        UsuarioDTO usuario = null;
        try{
            usuario = _mapper.Map<UsuarioDTO>(_context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == guid));
        }catch{
            throw new Exception("Este email no existe en la base de datos");
        }

        return usuario;
    }

    public UsuarioDTO Modify(BaseUsuarioDTO usuario, string guid)
    {
        var _mappedUsuario = _mapper.Map<UsuarioEntity>(usuario);
        _mappedUsuario.CorreoElectronico = guid;

        UsuarioEntity modifiedUsuario = _context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == guid);

        if (modifiedUsuario == null)
            return null;

        _context.Entry(modifiedUsuario).CurrentValues.SetValues(_mappedUsuario);

        _context.SaveChanges();

        return _mapper.Map<UsuarioDTO>(_mappedUsuario);
    }

}