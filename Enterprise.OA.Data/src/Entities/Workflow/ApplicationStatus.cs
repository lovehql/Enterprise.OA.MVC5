namespace Enterprise.OA.Data.Entities
{
    public enum ApplicationStatus : int
    {
        Draft = 0,
        
        Submitted = 1,

        Processed = 2,

        Completed = 3,
        
        Rejected = 4,
        
        Cancelled = 5,
        
        Deleted = 6
    }
}
