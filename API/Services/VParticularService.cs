using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class VParticularService : IVParticularService
{
    private readonly PopZoneContext _context;
    private readonly IMapper _mapper;

    public VParticularService(PopZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public VParticularDTO Add(BaseVParticularDTO baseVParticular)
    {
        var _mappedVParticular = _mapper.Map<VParticularEntity>(baseVParticular);
        var entityAdded = _context.VParticulares.Add(_mappedVParticular);
        _context.SaveChanges();
        return _mapper.Map<VParticularDTO>(entityAdded);
    }

    public void Delete(string dni)
    {
        VParticularEntity vparticular = _context.VParticulares.FirstOrDefault(x => x.DNI == dni);

        if (vparticular == null)
            throw new ApplicationException($"VParticular with dni {dni} not found");

        _context.VParticulares.Remove(vparticular);
        _context.SaveChanges();
    }

    public IEnumerable<VParticularDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<VParticularDTO>>(_context.VParticulares.Select(x => x));
    }

    public VParticularDTO GetByDNI(string dni)
    {
        return _mapper.Map<VParticularDTO>(_context.VParticulares.FirstOrDefault(x => x.DNI == dni));
    }

    public VParticularDTO Modify(BaseVParticularDTO vparticular, string dni)
    {
        var _mappedVParticular = _mapper.Map<VParticularEntity>(vparticular);
        _mappedVParticular.DNI = dni;

        VParticularEntity modifiedVParticular = _context.VParticulares.FirstOrDefault(x => x.DNI == dni);

        if (modifiedVParticular == null)
            return null;

        _context.Entry(modifiedVParticular).CurrentValues.SetValues(_mappedVParticular);

        _context.SaveChanges();

        return _mapper.Map<VParticularDTO>(_mappedVParticular);
    }

}