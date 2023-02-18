using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen.Data.DTO;
using Examen.Data.Models;

namespace Examen.Data.Results
{
    public class ArticleResult
    {
        public ArticleDTO Article { get; set; }
        public bool Success { get; set; }
        public int Total_Elements { get; set; }

    }
}
