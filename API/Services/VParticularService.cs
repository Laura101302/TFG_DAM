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

    public void Delete(int guid)
    {
        VParticularEntity vparticular = _context.VParticulares.FirstOrDefault(x => x.ID == guid);

        if (vparticular == null)
            throw new ApplicationException($"VParticular with guid {guid} not found");

        _context.VParticulares.Remove(vparticular);
        _context.SaveChanges();
    }

    public IEnumerable<VParticularDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<VParticularDTO>>(_context.VParticulares.Select(x => x));
    }

    public VParticularDTO GetByID(int guid)
    {
        return _mapper.Map<VParticularDTO>(_context.VParticulares.FirstOrDefault(x => x.ID == guid));
    }

    public VParticularDTO Modify(BaseVParticularDTO vparticular, int guid)
    {
        var _mappedVParticular = _mapper.Map<VParticularEntity>(vparticular);
        _mappedVParticular.ID = guid;

        VParticularEntity modifiedVParticular = _context.VParticulares.FirstOrDefault(x => x.ID == guid);

        if (modifiedVParticular == null)
            return null;

        _context.Entry(modifiedVParticular).CurrentValues.SetValues(_mappedVParticular);

        _context.SaveChanges();

        return _mapper.Map<VParticularDTO>(_mappedVParticular);
    }

}