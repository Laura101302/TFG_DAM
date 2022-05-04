using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for ProductosParticulares
/// </summary>
public interface IPParticularService
{
    public IEnumerable<PParticularDTO> GetAll();

    public PParticularDTO GetByID(int guid);

    public PParticularDTO Add(BasePParticularDTO guid);

    public void Delete(int guid);

    public PParticularDTO Modify(BasePParticularDTO pparticular, int guid);
}