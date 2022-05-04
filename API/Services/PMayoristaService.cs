using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class PMayoristaService : IPMayoristaService
{
    private readonly PopZoneContext _context;
    private readonly IMapper _mapper;

    public PMayoristaService(PopZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public PMayoristaDTO Add(BasePMayoristaDTO basePMayorista)
    {
        var _mappedPMayorista = _mapper.Map<PMayoristaEntity>(basePMayorista);
        var entityAdded = _context.PMayoristas.Add(_mappedPMayorista);
        _context.SaveChanges();
        return _mapper.Map<PMayoristaDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        PMayoristaEntity pmayorista = _context.PMayoristas.FirstOrDefault(x => x.ID == guid);

        if (pmayorista == null)
            throw new ApplicationException($"PMayorista with id {guid} not found");

        _context.PMayoristas.Remove(pmayorista);
        _context.SaveChanges();
    }

    public IEnumerable<PMayoristaDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<PMayoristaDTO>>(_context.PMayoristas.Select(x => x));
    }

    public PMayoristaDTO GetByID(int guid)
    {
        return _mapper.Map<PMayoristaDTO>(_context.PMayoristas.FirstOrDefault(x => x.ID == guid));
    }

    public PMayoristaDTO Modify(BasePMayoristaDTO pmayorista, int guid)
    {
        var _mappedPMayorista = _mapper.Map<PMayoristaEntity>(pmayorista);
        _mappedPMayorista.ID = guid;

        PMayoristaEntity modifiedPMayorista = _context.PMayoristas.FirstOrDefault(x => x.ID == guid);

        if (modifiedPMayorista == null)
            return null;

        _context.Entry(modifiedPMayorista).CurrentValues.SetValues(_mappedPMayorista);

        _context.SaveChanges();

        return _mapper.Map<PMayoristaDTO>(_mappedPMayorista);
    }

}