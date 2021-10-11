using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings
{
    public class BasePrerequisiteBinding : BaseEntity
    {
        public Guid PrerequisiteId { get; set; }
        public Prerequisite Prerequisite { get; set; } = default!;
    }

    public class BasePrerequisiteBindingConfigurator : EntityConfigurator<BasePrerequisiteBinding>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<BasePrerequisiteBinding>()
                .HasOne(e => e.Prerequisite)
                .WithOne(e => e.Binding)
                .HasForeignKey<BasePrerequisiteBinding>(e => e.PrerequisiteId);
        }
    }
}
