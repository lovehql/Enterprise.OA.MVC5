namespace Enterprise.OA.Data.Entities
{
    public class SequentialWorkflowState : WorkflowState
    {
        public SequentialWorkflowState()
        {
            Type = WorkflowStateType.Sequential;
        }
    }
}
