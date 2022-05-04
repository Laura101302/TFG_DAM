using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Usuarios
/// </summary>
public interface IUsuarioService
{
    public IEnumerable<UsuarioDTO> GetAll();

    public UsuarioDTO GetByEmail(string correo);

    public UsuarioDTO Add(BaseUsuarioDTO correo);

    public void Delete(string correo);

    public UsuarioDTO Modify(BaseUsuarioDTO usuario, string correo);
}