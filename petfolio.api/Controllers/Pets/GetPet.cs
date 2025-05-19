using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetPets;
using Petfolio.Communication.DTOs;

namespace Petfolio.API.Controllers.Pets;

public partial class PetsController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(PetDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Exception), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] string id)
    {
        PetDTO response;

        try
        {
            response = GetPetUseCase.Execute(id);
        }
        catch (Exception err)
        {
            return NotFound();
        }


        return Ok(response);
    }
}