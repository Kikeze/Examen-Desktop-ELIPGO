using Examen.Data.DTO;

namespace Examen.Data.Results
{
    public class ArticlesResult
    {
        public List<ArticleDTO> Articles { get; set; }
        public bool Success { get; set; }
        public int Total_Elements { get; set; }

    }
}
