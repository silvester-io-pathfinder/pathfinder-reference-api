using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities
{
    public class Configurator : EntityConfigurator<Deity>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<Deity>()
                .HasOne(e => e.Alignment)
                .WithMany(e => e.Deities);

            builder
                .Entity<Deity>()
                .HasMany(e => e.FollowerAlignments)
                .WithMany(e => e.DeityFollowerAlignments);
        }
    }

    public class SearchConfigurator : SearchableEntityConfigurator<Deity>
    {
        public override Expression<Func<Deity, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Anathema, e.Description, e.Edicts };
        }
    }
}
