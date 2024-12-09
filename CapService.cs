using SofCaps.Models;
using System.Collections.Generic;
using System.Linq;

namespace SofCaps.Services
{
    public class CapService : ICapService
    {
        private readonly List<Cap> _caps = new();

        public IEnumerable<Cap> GetAllCaps()
        {
            return _caps;
        }

        public void AddCap(Cap cap)
        {
            _caps.Add(cap);
        }
    }
}
