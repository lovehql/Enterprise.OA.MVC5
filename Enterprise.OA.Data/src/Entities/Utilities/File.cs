using System;

namespace Enterprise.OA.Data.Entities
{
    public class File : EntityBase<Guid>
    {
        public  string FileName { get; set; }
        
        public string ContentType { get; set; }

        public long ContentLength { get; set; }

        public string LocalFileUrl { get; set; }

        public FileStatus Status { get; set; }

        public ApplicationUser Creator { get; set; }
        
        public DateTime CreateDate { get; set; }
        
        public ApplicationUser Modificator { get; set; }
        
        public DateTime ModifyDate { get; set; }
    }
}
