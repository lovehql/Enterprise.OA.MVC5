using System;

namespace Enterprise.OA.Data.Entities
{
    public class Workflow : EntityBase<int>
    {
        public string DisplayName { get; set; }
        
        public string ApplicationName { get; set; }

        public virtual WorkflowState InitialState { get; set; }

        public string Comment { get; set; }
        
        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
