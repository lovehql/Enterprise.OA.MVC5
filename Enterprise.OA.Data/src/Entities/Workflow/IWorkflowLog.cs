using System;

namespace Enterprise.OA.Data.Entities
{
    public interface IWorkflowLog
    {
        WorkflowInstance Instance { get; set; }
        
        WorkflowState Origin { get; set; }
        
        WorkflowState Destinagion { get; set; }
        
        ApplicationUser Checker { get; set; }
        
        ApplicationUser Agent { get; set; }

        ApplicationStatus Status { get; set; }

        string Comment { get; set; }

        string IpAddress { get; set; }
    }
}
