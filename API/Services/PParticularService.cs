using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class PParticularService : IPParticularService
{
    private readonly PopZoneContext _context;
    private readonly IMapper _mapper;

    public PParticularService(PopZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public PParticularDTO Add(BasePParticularDTO basePParticular)
    {
        var _mappedPParticular = _mapper.Map<PParticularEntity>(basePParticular);
        var entityAdded = _context.PParticulares.Add(_mappedPParticular);
        _context.SaveChanges();
        return _mapper.Map<PParticularDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        PParticularEntity pparticular = _context.PParticulares.FirstOrDefault(x => x.ID == guid);

        if (pparticular == null)
            throw new ApplicationException($"PParticular with id {guid} not found");

        _context.PParticulares.Remove(pparticular);
        _context.SaveChanges();
    }

    public IEnumerable<PParticularDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<PParticularDTO>>(_context.PParticulares.Select(x => x));
    }

    public PParticularDTO GetByID(int guid)
    {
        return _mapper.Map<PParticularDTO>(_context.PParticulares.FirstOrDefault(x => x.ID == guid));
    }

    public PParticularDTO Modify(BasePParticularDTO pparticular, int guid)
    {
        var _mappedPParticular = _mapper.Map<PParticularEntity>(pparticular);
        _mappedPParticular.ID = guid;

        PParticularEntity modifiedPParticular = _context.PParticulares.FirstOrDefault(x => x.ID == guid);

        if (modifiedPParticular == null)
            return null;

        _context.Entry(modifiedPParticular).CurrentValues.SetValues(_mappedPParticular);

        _context.SaveChanges();

        return _mapper.Map<PParticularDTO>(_mappedPParticular);
    }

}