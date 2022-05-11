using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Usuarios
/// </summary>
public interface IUsuarioService
{
    public IEnumerable<UsuarioDTO> GetAll();

    public UsuarioDTO GetByID(int guid);

    public UsuarioDTO Add(BaseUsuarioDTO guid);

    public void Delete(int guid);

    public UsuarioDTO Modify(BaseUsuarioDTO usuario, int guid);
}