using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for ProductosMayoristas
/// </summary>
public interface IPMayoristaService
{
    public IEnumerable<PMayoristaDTO> GetAll();

    public PMayoristaDTO GetByID(int guid);

    public PMayoristaDTO Add(BasePMayoristaDTO guid);

    public void Delete(int guid);

    public PMayoristaDTO Modify(BasePMayoristaDTO pmayorista, int guid);
}