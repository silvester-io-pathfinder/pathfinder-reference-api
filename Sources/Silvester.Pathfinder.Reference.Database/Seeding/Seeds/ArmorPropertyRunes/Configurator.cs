using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorPropertyRunes
{
    public class Configurator : EntityConfigurator<ArmorPropertyRune>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<ArmorPropertyRune>()
                .HasOne(e => e.Action)
                .WithOne(e => e!.Rune)
                .HasForeignKey<ArmorPropertyRuneAction>(a => a.RuneId); ;

            builder
                .Entity<ArmorPropertyRuneAction>()
                .HasOne(e => e.Rune)
                .WithOne(e => e!.Action);
        }
    }

    public class SearchConfigurator : SearchableEntityConfigurator<ArmorPropertyRune>
    {
        public override Expression<Func<ArmorPropertyRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.CraftingRequirements };
        }
    }
}
