using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Opiniones
/// </summary>
public interface IOpinionService
{
    public IEnumerable<OpinionDTO> GetAll();

    public OpinionDTO GetByEmail(string correo);

    public OpinionDTO Add(BaseOpinionDTO correo);

    public void Delete(string correo);

    public OpinionDTO Modify(BaseOpinionDTO opinion, string correo);
}