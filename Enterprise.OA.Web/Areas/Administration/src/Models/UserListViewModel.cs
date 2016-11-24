using Enterprise.OA.Web.Infrastructure.Models;
using System.Collections.Generic;

namespace Enterprise.OA.Web.Administration.Models
{
    public class UserListViewModel : UserListViewModelBase
    {
        public string UserName { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string MaritalStatus { get; set; }

        public string Nationality { get; set; }

        public string Qualification { get; set; }

        public string IdentityNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public ICollection<EmergencyContactViewModel> EmergencyContacts { get; set; }

        public string Grade { get; set; }

        public string JoinDate { get; set; }

        public string ResignDate { get; set; }
    }
}