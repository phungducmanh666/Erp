using Domain.Sources.Main.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.ValueObjects
{
    public class Address: ValueObject
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public Address(string street, string city)
        {
            Street = street;
            City = city;
        }
        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
        }
    }
}
