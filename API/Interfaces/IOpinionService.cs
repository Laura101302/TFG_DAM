using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for Opiniones
/// </summary>
public interface IOpinionService
{
    public IEnumerable<OpinionDTO> GetAll();

    public OpinionDTO GetByID(int guid);

    public OpinionDTO Add(BaseOpinionDTO guid);

    public void Delete(int guid);

    public OpinionDTO Modify(BaseOpinionDTO opinion, int guid);
}