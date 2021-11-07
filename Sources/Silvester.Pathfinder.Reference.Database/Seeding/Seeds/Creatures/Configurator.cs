using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Creatures
{
    public class Configurator : EntityConfigurator<Creature>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<Creature>()
                .HasOne(e => e.RecallKnowledge)
                .WithOne(e => e!.Creature)
                .HasForeignKey<Creature>(e => e.RecallKnowledgeId);
        }
    }

    public class SearchConfigurator : SearchableEntityConfigurator<Creature>
    {
        public override Expression<Func<Creature, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}