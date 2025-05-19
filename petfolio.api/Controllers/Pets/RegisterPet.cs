using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.RegisterPet;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers.Pets;

public partial class PetsController
{
    [HttpPost]
    [ProducesResponseType(typeof(RegisterPetResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsResponses), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RegisterPetRequest request)
    {
        var response = RegisterPetUseCase.Execute(request);

        return Created(string.Empty, response);
    }
}