using System;

namespace Enterprise.OA.Data.Entities
{
    public interface ITraceable
    {

        ApplicationUser Creator { get; set; }
        
        DateTime CreateDate { get; set; }
        
        ApplicationUser Modificator { get; set; }
        
        DateTime ModifyDate { get; set; }
    }
}
