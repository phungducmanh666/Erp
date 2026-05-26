using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common
{
    public abstract class ValueObject
    {
        // Hàm này bắt buộc các Class con phải liệt kê các thuộc tính cấu thành nên nó
        protected abstract IEnumerable<object?> GetEqualityComponents();
        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;

            var other = (ValueObject)obj;
            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
