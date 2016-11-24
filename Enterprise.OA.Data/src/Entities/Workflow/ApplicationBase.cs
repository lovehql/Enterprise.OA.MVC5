using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class ApplicationBase : EntityBase<int>, ITraceable
    {
        public string Number { get; set; }
        
        public virtual ApplicationUser Applicant { get; set; }
        
        public ApplicationStatus Status { get; set; }
        
        public virtual WorkflowInstance WorkflowInstance { get; set; }
        
        public virtual ICollection<WorkflowInstance> WorkflowRecords { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
