using Plantify.Domain.Abstractions;

namespace Plantify.Domain.Plants;

public static class PlantErros 
{
    public static Error NotFound = new(
        "Plant.NotFound",
        "The plant with the specified identifier was not found");
}