using System;

namespace Enterprise.OA.Data.Entities
{
    public class WorkflowStateOption : EntityBase<int>, ITraceable
    {
        public int Priority { get; set; }
        
        public string Eval { get; set; }

        public virtual WorkflowState State { get; set; }

        public virtual WorkflowState Destinagion { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
