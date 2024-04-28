using Plantify.Domain.Abstractions;
using Plantify.Domain.Orders.Events;
using Plantify.Domain.Plants;
using System;
using Plantify.Domain.Shared;

namespace Plantify.Domain.Orders
{
    public sealed class Order : Entity
    {
        private Order(
            Guid id,
            Guid userId, 
            Guid plantId, 
            Money price,
        DateTimeOffset orderDate)
            : base(id)
        {
            UserId = userId;
            PlantId = plantId;
            Price = price;
            OrderDate = orderDate;
        }
        
        private Order()
        {
        }

        public Guid UserId { get; private set; }

        public Guid PlantId { get; private set; }

        public Money Price { get; private set; }

        public DateTimeOffset OrderDate { get; private set; }

        public static Order Create(Guid userId, Guid plantId, Money price)
        {
            var order = new Order(Guid.NewGuid(), userId, plantId, price, DateTimeOffset.UtcNow);

            order.RaiseDomainEvent(new OrderCreatedDomainEvent(order.Id));

            return order;
        }
    }
}