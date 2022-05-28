using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Usuarios
/// </summary>
public interface IUsuarioService
{
    public IEnumerable<UsuarioDTO> GetAll();

    public UsuarioDTO GetByEmail(string guid);

    public UsuarioDTO Add(BaseUsuarioDTO guid);

    public void Delete(string guid);

    public UsuarioDTO Modify(BaseUsuarioDTO usuario, string guid);
}