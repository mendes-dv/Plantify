using Plantify.Domain.Plants;
using Plantify.Domain.Shared;

namespace Plantify.Domain.Orders;

public class PricingService
{
    public Money CalculatePrice(Plant plant)
    {
        return plant.Price;
    }
}