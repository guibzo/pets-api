using Petfolio.Communication.DTOs;
using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetPets;

public class GetPetsResponse
{
    public List<PetDTO> Pets { get; set; } = [];
}

public class GetPetsUseCase
{
    public static GetPetsResponse Execute()
    {
        return new GetPetsResponse
        {
            Pets = [
                new PetDTO {
                    Id = "1",
                    Animal = TypeOfAnimal.Cat,
                    Name = "Tarzan rabo quebrado5123"
                }
            ]
        };
    }
}
