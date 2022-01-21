using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class AlchemicalPoison : BaseItem
    {
    }

    public class AlchemicalPoisonVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;
       
        public Guid PoisonEffectId { get; set; }
        public StaggeredEffect PoisonEffect { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AlchemicalPoisonVariantConfigurator : EntityConfigurator<AlchemicalPoisonVariant>
	{
		public AlchemicalPoisonVariantConfigurator()
		{
			ConfigureEntitySearch<AlchemicalPoisonVariant>(e => new {e.Name, e.Usage});
		}

        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<AlchemicalPoisonVariant>()
                .HasOne(e => e.PoisonEffect)
                .WithOne()
                .HasForeignKey<AlchemicalPoisonVariant>(e => e.PoisonEffectId);
        }
    }
}
