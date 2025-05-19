using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.RegisterPet;

public class RegisterPetRequest
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }

    public TypeOfAnimal Animal { get; set; }
}

public class RegisterPetResponse
{
    public string Id = string.Empty;
}

public class RegisterPetUseCase
{
    public static RegisterPetResponse Execute(RegisterPetRequest request)
    {
        return new RegisterPetResponse
        {
            Id = "1",
        };
    }
}
