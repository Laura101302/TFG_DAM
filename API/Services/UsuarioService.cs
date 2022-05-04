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

    public void Delete(string correo)
    {
        UsuarioEntity usuario = _context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == correo);

        if (usuario == null)
            throw new ApplicationException($"Usuario with email {correo} not found");

        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();
    }

    public IEnumerable<UsuarioDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<UsuarioDTO>>(_context.Usuarios.Select(x => x));
    }

    public UsuarioDTO GetByEmail(string correo)
    {
        return _mapper.Map<UsuarioDTO>(_context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == correo));
    }

    public UsuarioDTO Modify(BaseUsuarioDTO usuario, string correo)
    {
        var _mappedUsuario = _mapper.Map<UsuarioEntity>(usuario);
        _mappedUsuario.CorreoElectronico = correo;

        UsuarioEntity modifiedUsuario = _context.Usuarios.FirstOrDefault(x => x.CorreoElectronico == correo);

        if (modifiedUsuario == null)
            return null;

        _context.Entry(modifiedUsuario).CurrentValues.SetValues(_mappedUsuario);

        _context.SaveChanges();

        return _mapper.Map<UsuarioDTO>(_mappedUsuario);
    }

}