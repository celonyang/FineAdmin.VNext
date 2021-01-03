using System.Data;

namespace FineAdmin.Model
{
    public class SearchFilter
    {
        public string Prefix { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string ReturnFields { get; set; }
        public string Where { get; set; }
        public string OrderBy { get; set; }
        public object Param { get; set; }
        public IDbTransaction Transaction { get; set; }
        public int? CommandTimeout { get; set; }
    }
}
