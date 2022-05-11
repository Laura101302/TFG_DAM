using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for VendedoresParticulares
/// </summary>
public interface IVParticularService
{
    public IEnumerable<VParticularDTO> GetAll();

    public VParticularDTO GetByID(int guid);

    public VParticularDTO Add(BaseVParticularDTO guid);

    public void Delete(int guid);

    public VParticularDTO Modify(BaseVParticularDTO vparticular, int guid);
}