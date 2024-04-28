using Plantify.Domain.Abstractions;

namespace Plantify.Domain.Orders;

public static class OrderErros 
{
    public static Error NotFound = new(
        "Order.NotFound",
        "The order with the specified identifier was not found");

    public static Error Overlap = new(
        "Booking.Sold",
        "The current products is already all sold");
}