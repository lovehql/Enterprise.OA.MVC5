using System.Collections.Generic;

namespace Enterprise.OA.Web.Infrastructure.Dtos
{
    public class UserProfileDto : UserProfileDtoBase
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

        public ICollection<EmergencyContactDto> EmergencyContacts { get; set; }

        public string Grade { get; set; }

        public string JoinDate { get; set; }

        public string ResignDate { get; set; }
    }
}
