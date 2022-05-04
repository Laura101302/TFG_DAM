using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PParticularesController : ControllerBase
{
    private readonly ILogger<PParticularesController> _logger;
    private readonly IPParticularService _pparticularService;

    /// <summary>
    /// It creates a pparticularController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="pparticularService">used for dealing with the pparticular data</param>
    public PParticularesController(ILogger<PParticularesController> logger, IPParticularService pparticularService)
    {
        _logger = logger;
        _pparticularService = pparticularService;
    }

    /// <summary>
    /// Returns all the pparticulars
    /// </summary>
    /// <returns>Returns a list of <see cref="PParticularDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Get()
    {
        return Ok(_pparticularService.GetAll());
    }

    /// <summary>
    /// It returns a pparticular by id 
    /// </summary>
    /// <param name="ID">the id of the pparticular</param>
    /// <returns>Returns a pparticular <see cref="PParticularDTO"/></returns>
    [HttpGet("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PParticularDTO> Get(int ID)
    {
        PParticularDTO result = _pparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// it deletes a pparticular
    /// </summary>
    /// <param name="ID">the id of the pparticular that is going to be deleted</param>
    /// <returns>Returns the deleted pparticular <see cref="PParticularDTO"/></returns>
    [HttpDelete("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PParticularDTO> Delete(int ID)
    {
        PParticularDTO result = _pparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        _pparticularService.Delete(ID);

        return Ok(result);

    }


    /// <summary>
    /// It creates a pparticular
    /// </summary>
    /// <param name="basePParticular">the created pparticular <see cref="BasePParticularDTO"/></param>
    /// <returns>Returns the created pparticular <see cref="PParticularDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Post([FromBody] BasePParticularDTO basePParticular)
    {

        return Ok(_pparticularService.Add(basePParticular));
    }

    /// <summary>
    /// it modifies a pparticular
    /// </summary>
    /// <param name="basePParticular">the created pparticular <see cref="BasePParticularDTO"/></param>
    /// <param name="ID">the id of the modified pparticular</param>
    /// <returns>Returns the modified pparticular <see cref="PParticularDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Put([FromBody] BasePParticularDTO basePParticular, int ID)
    {

        return Ok(_pparticularService.Modify(basePParticular, ID));
    }

}
