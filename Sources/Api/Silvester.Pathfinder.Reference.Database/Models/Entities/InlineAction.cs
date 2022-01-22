using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class InlineAction : BaseEntity
    {
        public Guid OwnerId { get; set; }
        
        public string Name { get; set; } = default!;

        public string? Requirements { get; set; }
        public string? Frequency { get; set; }
        public string? Trigger { get; set; }
        public string? Kind { get; set; }
        public string? Cost { get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public Guid? StaggeredEffectId { get; set; }
        public StaggeredEffect? StaggeredEffect { get; set; }

        public ICollection<TextBlock> Effect { get; set; } = new List<TextBlock>();
        public ICollection<InlineActionTraitBinding> Traits { get; set; } = new List<InlineActionTraitBinding>();
    }

    public class InlineActionConfigurator : EntityConfigurator<InlineAction>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<InlineAction>()
                .HasOne(e => e.StaggeredEffect)
                .WithOne()
                .HasForeignKey<InlineAction>(e => e.StaggeredEffectId);
        }
    }

    public class InlineActionTraitBinding : TraitBinding<InlineAction>
    {

    }
}
