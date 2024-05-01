using Plantify.Domain.Shared;

namespace Plantify.Domain.Orders;

public record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);