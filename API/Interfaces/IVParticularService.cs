using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// This is the service for VendedoresParticulares
/// </summary>
public interface IVParticularService
{
    public IEnumerable<VParticularDTO> GetAll();

    public VParticularDTO GetByDNI(string dni);

    public VParticularDTO Add(BaseVParticularDTO dni);

    public void Delete(string dni);

    public VParticularDTO Modify(BaseVParticularDTO vparticular, string dni);
}