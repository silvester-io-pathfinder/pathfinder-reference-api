using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities
{
    public class Template : EntityConfigurator<Deity>
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
}
