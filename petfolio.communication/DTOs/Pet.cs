using Petfolio.Communication.Enums;

namespace Petfolio.Communication.DTOs;

public class PetDTO
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public TypeOfAnimal Animal { get; set; }
}
