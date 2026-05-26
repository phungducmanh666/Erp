using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common.Interfaces
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
