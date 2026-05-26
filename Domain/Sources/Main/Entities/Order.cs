using Domain.Sources.Main.Common;
using Domain.Sources.Main.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Entities
{
    public class Order :BaseEntity<Guid>, IAggregateRoot
    {
        public string CustomerId { get; private set; }
        public string ShippingAddress { get; private set; }
        public decimal TotalAmount { get; private set; }
        public Order(Guid id, string customerId, string shippingAddress, decimal totalAmount)
        {
            Id = id;
            CustomerId = customerId;
            ShippingAddress = shippingAddress;
            TotalAmount = totalAmount;
        
            AddDomainEvent(new OrderCreatedEvent(id, customerId));
        }

    }

    public class OrderCreatedEvent : BaseEvent
    {
        public Guid OrderId { get; private set; }
        public string CustomerId { get; private set; }
        public OrderCreatedEvent(Guid orderId, string customerId)
        {
            OrderId = orderId;
            CustomerId = customerId;
        }
    }
}
