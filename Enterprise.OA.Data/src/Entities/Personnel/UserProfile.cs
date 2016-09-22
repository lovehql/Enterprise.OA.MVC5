using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class UserProfile : EntityBase<int>
    {
        public UserProfile()
        {
            EmergencyContacts = new List<EmergencyContact>();
        }
        
        public string FullName { get; set; }

        public string Alias { get; set; }

        public string StaffNumber { get; set; }

        public Gender Gender { get; set; }
        
        public DateTime Birthday { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public string Nationality { get; set; }

        public string IdentityNumber { get; set; }

        public string Qualification { get; set; }
        
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }
        
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        
        public virtual Subsidiary Subsidiary { get; set; }

        public virtual Department Department { get; set; }

        public string JobPosition { get; set; }

        public EmploymentGrade Grade { get; set; }

        public UserStatus Status { get; set; }

        public DateTime JoinDate { get; set; }

        public DateTime ResignDate { get; set; }

        public virtual UserProfile Agent { get; set; }

        public virtual ICollection<UserProfile> AgentFors { get; set; }
    }
}
