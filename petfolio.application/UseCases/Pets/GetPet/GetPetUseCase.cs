using Petfolio.Communication.DTOs;
using Petfolio.Communication.Enums;

namespace Petfolio.Application.UseCases.Pets.GetPets;

public class GetPetUseCase
{
    public static PetDTO Execute(string id)
    {
        if (id == "5") { throw new Exception("Not found"); }
        
        return new PetDTO()
        {
            Id = id,
            Animal = TypeOfAnimal.Fish,
            Name = "Dourado o peixe magnetico123"
        };
    }
}
