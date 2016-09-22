using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class WorkflowInstance : EntityBase<int>
    {
        public int Level { get; set; }

        public virtual Workflow Workflow { get; set; }
        
        public virtual ApplicationUser Applicant { get; set; }
        
        public virtual WorkflowState State { get; set; }
        
        public virtual ApplicationUser Checker { get; set; }

        public virtual ICollection<IWorkflowLog> Logs { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
