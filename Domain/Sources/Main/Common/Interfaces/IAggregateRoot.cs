using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common.Interfaces
{
    public interface IAggregateRoot
    {
        // Đây là Marker Interface, không cần định nghĩa hàm bên trong.
        // Dùng để ràng buộc cho các Repository kiểu: IRepository<T> where T : IAggregateRoot
    }
}
