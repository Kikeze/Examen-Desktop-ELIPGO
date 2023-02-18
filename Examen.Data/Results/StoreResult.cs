using Examen.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Data.Results
{
    public class StoreResult
    {
        public Store Store { get; set; }
        public bool Success { get; set; }
        public int Total_Elements { get; set; }
    }
}
