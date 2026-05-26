using Domain.Sources.Main.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common
{
    public class BaseEntity<TId> : IEntity<TId>, IHasDomainEvents
    {
        public TId Id { get; protected set; } = default;
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
        public void RemoveDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
        public override bool Equals(object obj)
        {
            if (obj is not BaseEntity<TId> other) return false;
            if (ReferenceEquals(this, other)) return true;
            if (Id.Equals(default(TId)) || other.Id.Equals(default(TId))) return false;

            return Id.Equals(other.Id);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
