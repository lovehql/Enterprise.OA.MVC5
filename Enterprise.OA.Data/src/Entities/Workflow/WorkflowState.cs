using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class WorkflowState : EntityBase<int>, ITraceable
    {
        public WorkflowState()
        {
            Options = new List<WorkflowStateOption>();
        }

        public string Number { get; set; }
        
        public string DisplayName { get; set; }
        
        public WorkflowStateType Type { get; set; }
        
        public virtual WorkflowState Destinagion { get; set; }
        
        public virtual ICollection<WorkflowStateOption> Options { get; set; }
        
        public string Comment { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
