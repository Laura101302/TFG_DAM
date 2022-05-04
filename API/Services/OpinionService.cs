using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class OpinionService : IOpinionService
{
    private readonly PopZoneContext _context;
    private readonly IMapper _mapper;

    public OpinionService(PopZoneContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public OpinionDTO Add(BaseOpinionDTO baseOpinion)
    {
        var _mappedOpinion = _mapper.Map<OpinionEntity>(baseOpinion);
        var entityAdded = _context.Opiniones.Add(_mappedOpinion);
        _context.SaveChanges();
        return _mapper.Map<OpinionDTO>(entityAdded);
    }

    public void Delete(string correo)
    {
        OpinionEntity opinion = _context.Opiniones.FirstOrDefault(x => x.CorreoElectronico == correo);

        if (opinion == null)
            throw new ApplicationException($"Opinion with email {correo} not found");

        _context.Opiniones.Remove(opinion);
        _context.SaveChanges();
    }

    public IEnumerable<OpinionDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<OpinionDTO>>(_context.Opiniones.Select(x => x));
    }

    public OpinionDTO GetByEmail(string correo)
    {
        return _mapper.Map<OpinionDTO>(_context.Opiniones.FirstOrDefault(x => x.CorreoElectronico == correo));
    }

    public OpinionDTO Modify(BaseOpinionDTO opinion, string correo)
    {
        var _mappedOpinion = _mapper.Map<OpinionEntity>(opinion);
        _mappedOpinion.CorreoElectronico = correo;

        OpinionEntity modifiedOpinion = _context.Opiniones.FirstOrDefault(x => x.CorreoElectronico == correo);

        if (modifiedOpinion == null)
            return null;

        _context.Entry(modifiedOpinion).CurrentValues.SetValues(_mappedOpinion);

        _context.SaveChanges();

        return _mapper.Map<OpinionDTO>(_mappedOpinion);
    }

}