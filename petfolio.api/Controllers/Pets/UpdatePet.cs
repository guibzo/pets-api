using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.UpdatePet;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers.Pets;

public partial class PetsController
{
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponses), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] string id, [FromBody] UpdatePetRequest request)
    {
        UpdatePetUseCase.Execute(id, request);

        return NoContent();
    }
}