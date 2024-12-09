using SofCaps.Models;
using System.Collections.Generic;

namespace SofCaps.Services
{
    public interface ICapService
    {
        IEnumerable<Cap> GetAllCaps();
        void AddCap(Cap cap);
    }
}
