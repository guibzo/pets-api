using Petfolio.Communication.Enums;

namespace Petfolio.Application.UseCases.Pets.UpdatePet;

public class UpdatePetRequest
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public TypeOfAnimal Animal { get; set; }
}

public class UpdatePetUseCase
{
    public static string Execute(string id, UpdatePetRequest request)
    {
        return id;
    }
}
