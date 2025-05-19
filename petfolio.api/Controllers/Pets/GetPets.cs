using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetPets;

namespace Petfolio.API.Controllers.Pets;

public partial class PetsController
{
    [HttpGet]
    [ProducesResponseType(typeof(GetPetsResponse), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = GetPetsUseCase.Execute();
        return Ok(response);
    }
}