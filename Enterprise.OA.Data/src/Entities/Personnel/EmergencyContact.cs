using System;

namespace Enterprise.OA.Data.Entities
{
    public class EmergencyContact : EntityBase<int>
    {

        /// <summary>
        /// 
        /// </summary>
        public virtual UserProfile UserProfile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
