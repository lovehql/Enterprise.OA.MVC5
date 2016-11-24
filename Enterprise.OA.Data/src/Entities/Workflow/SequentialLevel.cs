using System;

namespace Enterprise.OA.Data.Entities
{
    public class SequentialLevel : EntityBase<int>, ITraceable
    {
        public virtual SequentialWorkflowStateSetting Setting { get; set; }
        
        public int Level { get; set; }
        
        public virtual ApplicationUser Checker { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
