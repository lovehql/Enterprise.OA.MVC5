using System;

namespace Enterprise.OA.Data.Entities
{
    public class File : EntityBase<Guid>, ITraceable
    {
        public  string FileName { get; set; }
        
        public string ContentType { get; set; }

        public long ContentLength { get; set; }

        public string LocalFileUrl { get; set; }

        public FileStatus Status { get; set; }

        public virtual ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public virtual ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
