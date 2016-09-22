using System;

namespace Enterprise.OA.Data.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public abstract class EntityBase<TId>
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual TId Id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static bool IsTransient(EntityBase<TId> obj)
        {
            return obj != null && Equals(obj.Id, default(TId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as EntityBase<TId>);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public virtual bool Equals(EntityBase<TId> other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (!IsTransient(this) && !IsTransient(other) && Equals(Id, other.Id))
            {
                Type otherType = other.GetUnproxiedType();

                Type thisType = GetUnproxiedType();

                return thisType.IsAssignableFrom(otherType) || otherType.IsAssignableFrom(thisType);
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (Equals(Id, default(TId)))
            {
                return base.GetHashCode();
            }

            return Id.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Type GetUnproxiedType()
        {
            return GetType();
        }
    }
}
