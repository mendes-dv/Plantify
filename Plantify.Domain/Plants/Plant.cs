using Plantify.Domain.Abstractions;
using Plantify.Domain.Plants.Events;
using Plantify.Domain.Shared;

namespace Plantify.Domain.Plants;

public sealed class Plant : Entity
{
    private Plant(Guid id, 
        Name name, 
        Description description,
        Money price,
        AvailableQuantity availableQuantity
        )
        : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        AvailableQuantity = availableQuantity;
    }

    private Plant()
    {
    }

    public Name Name { get; private set; }

    public Description Description { get; private set; }
    
    public Money Price { get; private set; }
    
    public AvailableQuantity AvailableQuantity { get; private set; }

    public static Plant Create(Name name, Description description, Money price, AvailableQuantity availableQuantity)
    {
        var plant = new Plant(Guid.NewGuid(), name, description, price, availableQuantity);

        plant.RaiseDomainEvent(new PlantCreatedDomainEvent(plant.Id));

        return plant;
    }
}