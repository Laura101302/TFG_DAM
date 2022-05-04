using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VParticularesController : ControllerBase
{
    private readonly ILogger<VParticularesController> _logger;
    private readonly IVParticularService _vparticularService;

    /// <summary>
    /// It creates a vparticularController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="vparticularService">used for dealing with the vparticular data</param>
    public VParticularesController(ILogger<VParticularesController> logger, IVParticularService vparticularService)
    {
        _logger = logger;
        _vparticularService = vparticularService;
    }

    /// <summary>
    /// Returns all the vparticulars
    /// </summary>
    /// <returns>Returns a list of <see cref="VParticularDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Get()
    {
        return Ok(_vparticularService.GetAll());
    }

    /// <summary>
    /// It returns a vparticular by id 
    /// </summary>
    /// <param name="DNI">the dni of the vparticular</param>
    /// <returns>Returns a vparticular <see cref="VParticularDTO"/></returns>
    [HttpGet("{DNI}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<VParticularDTO> Get(string DNI)
    {
        VParticularDTO result = _vparticularService.GetByDNI(DNI);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a vparticular
    /// </summary>
    /// <param name="DNI">the dni of the vparticular that is going to be deleted</param>
    /// <returns>Returns the deleted vparticular <see cref="VParticularDTO"/></returns>
    [HttpDelete("{DNI}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<VParticularDTO> Delete(string DNI)
    {
        VParticularDTO result = _vparticularService.GetByDNI(DNI);

        if (result == null)
            return NotFound();

        _vparticularService.Delete(DNI);

        return Ok(result);

    }


    /// <summary>
    /// It creates a vparticular
    /// </summary>
    /// <param name="baseVParticular">the created vparticular <see cref="BaseVParticularDTO"/></param>
    /// <returns>Returns the created vparticular <see cref="VParticularDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Post([FromBody] BaseVParticularDTO baseVParticular)
    {

        return Ok(_vparticularService.Add(baseVParticular));
    }

    /// <summary>
    /// it modifies a vparticular
    /// </summary>
    /// <param name="baseVParticular">the created vparticular <see cref="BaseVParticularDTO"/></param>
    /// <param name="DNI">the dni of the modified vparticular</param>
    /// <returns>Returns the modified vparticular <see cref="VParticularDTO"/></returns>
    [HttpPut("{DNI}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Put([FromBody] BaseVParticularDTO baseVParticular, string DNI)
    {

        return Ok(_vparticularService.Modify(baseVParticular, DNI));
    }

}