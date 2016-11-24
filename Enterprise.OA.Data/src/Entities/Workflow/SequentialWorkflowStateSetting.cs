using System;
using System.Collections.Generic;

namespace Enterprise.OA.Data.Entities
{
    public class SequentialWorkflowStateSetting : EntityBase<int>, ITraceable
    {
        public virtual SequentialWorkflowState State { get; set; }
        
        public virtual ApplicationUser Applicant { get; set; }
        
        public virtual ICollection<SequentialLevel> Sequences { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
