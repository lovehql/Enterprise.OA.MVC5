using System;

namespace Enterprise.OA.Data.Entities
{
    public class TransportationMealClaimLog : EntityBase<int>, IWorkflowLog, ITraceable
    {
        public virtual WorkflowInstance Instance { get; set; }

        public virtual WorkflowState Origin { get; set; }

        public virtual WorkflowState Destinagion { get; set; }

        public virtual ApplicationUser Checker { get; set; }

        public virtual ApplicationUser Agent { get; set; }

        public ApplicationStatus Status { get; set; }

        public string Comment { get; set; }

        public string IpAddress { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ApplicationUser Modificator { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
