using System.Collections.Generic;

namespace Enterprise.OA.Framework.Model
{
    public class PagedResultModel<TModel> where TModel : class
    {
        public int TotalRecords { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public ICollection<TModel> Results { get; set; }
    }
}
