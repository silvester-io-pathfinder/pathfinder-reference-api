using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Creatures
{
    public class Configurator : EntityConfigurator<Creature>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<Creature>()
                .HasOne(e => e.RecallKnowledge)
                .WithOne(e => e.Creature)
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