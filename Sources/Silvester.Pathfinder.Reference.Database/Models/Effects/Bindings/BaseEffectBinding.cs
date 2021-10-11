using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings
{
    public class BaseEffectBinding : BaseEntity
    {
        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
    }

    public class BaseEffectBindingConfigurator : EntityConfigurator<BaseEffectBinding>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<BaseEffectBinding>()
                .HasOne(e => e.Effect)
                .WithOne(e => e.Binding)
                .HasForeignKey<BaseEffectBinding>(e => e.EffectId);
        }
    }
}
