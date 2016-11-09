using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enterprise.OA.Web.Administration.Models
{
    public class UserListViewModel
    {
        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Alias { get; set; }

        public string SubsidiaryName { get; set; }

        public string DepartementName { get; set; }
    }
}