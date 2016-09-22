namespace Enterprise.OA.Data.Entities
{
    public class BasicWorkflowState : WorkflowState
    {
        
        public BasicWorkflowState()
        {
            Type = WorkflowStateType.Basic;
        }
        
        public virtual ApplicationUser Checker { get; set; }
    }
}
