﻿using Enterprise.OA.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.OA.Data.Mappings
{
    public class WorkflowStateMap : EntityTypeConfiguration<WorkflowState>
    {
        public WorkflowStateMap()
        {
            this.ToTable("oa_wfs_WorkflowStates");

            this.HasKey(x => x.Id);

            this.Property(x => x.Number).HasMaxLength(50).IsRequired();
            this.Property(x => x.DisplayName).HasMaxLength(256);
            this.Property<WorkflowStateType>(x => x.Type).IsRequired();
            
            this.HasOptional(x => x.Destinagion).WithMany().Map(m => m.MapKey("DestinagionId"));

            this.Property(x => x.Comment).HasMaxLength(512);

            this.WithTraceable();
        }
    }
}
