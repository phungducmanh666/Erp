using Domain.Sources.Main.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common
{
    public abstract class BaseEvent : IDomainEvent
    {
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
    }
}
