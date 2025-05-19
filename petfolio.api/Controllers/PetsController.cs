using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetPets;
using Petfolio.Application.UseCases.Pets.RegisterPet;
using Petfolio.Application.UseCases.Pets.UpdatePet;
using Petfolio.Communication.DTOs;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpGet()]
    [ProducesResponseType(typeof(GetPetsResponse), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = GetPetsUseCase.Execute();
        
        return Ok(response);
    }
    
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(PetDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Exception), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] string id)
    {
        PetDTO response;

        try { response = GetPetUseCase.Execute(id);}
        catch (Exception err) { return NotFound(); }
        

        return Ok(response);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(RegisterPetResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsResponses), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RegisterPetRequest request)
    {
        var response = RegisterPetUseCase.Execute(request);

        return Created(string.Empty, response);
    }
    
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponses), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] string id, [FromBody] UpdatePetRequest request)
    {
        var response = UpdatePetUseCase.Execute(id, request);

        return NoContent();
    }
}
