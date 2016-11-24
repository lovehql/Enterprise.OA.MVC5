using Enterprise.OA.Data.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data
{
    public static class ModelBuilderExtensions
    {
        public static void WithTraceable<TEntity>(this EntityTypeConfiguration<TEntity> traceable) where TEntity : class, ITraceable
        {
            if (traceable == null)
                throw new ArgumentNullException(nameof(traceable));

            traceable.HasRequired(x => x.Creator)
                .WithMany()
                .Map(cfg => cfg.MapKey("CreatorId"))
                .WillCascadeOnDelete(false);

            traceable.Property(x => x.CreateDate)
                .IsRequired();

            traceable.HasRequired(x => x.Modificator)
                .WithMany()
                .Map(cfg => cfg.MapKey("ModificatorId"))
                .WillCascadeOnDelete(false);

            traceable.Property(x => x.ModifyDate)
                .IsRequired();
        }
    }
}
