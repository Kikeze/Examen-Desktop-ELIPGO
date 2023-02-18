using Examen.Data.Models;

namespace Examen.Data.Results
{
    public class StoresResult
    {
        public List<Store> Stores { get; set; }
        public bool Success { get; set; }
        public int Total_Elements { get; set; }

    }
}
