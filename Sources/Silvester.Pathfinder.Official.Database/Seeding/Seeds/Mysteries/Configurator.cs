using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries
{
    public class Configurator : EntityConfigurator<Mystery>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<Mystery>()
                .HasOne(e => e.GrantedCantrip)
                .WithOne(e => e.GrantedBy!)
                .HasForeignKey<Mystery>(e => e.GrantedCantripId);

            builder
                .Entity<Mystery>()
                .HasOne(e => e.InitialRevelation)
                .WithOne(e => e.InitialRevelationOf!)
                .HasForeignKey<Mystery>(e => e.InitialRevelationId);

            builder
                .Entity<Mystery>()
                .HasOne(e => e.AdvancedRevelation)
                .WithOne(e => e.AdvancedRevelationOf!)
                .HasForeignKey<Mystery>(e => e.AdvancedRevelationId);

            builder
                .Entity<Mystery>()
                .HasOne(e => e.GreaterRevelation)
                .WithOne(e => e.GreaterRevelationOf!)
                .HasForeignKey<Mystery>(e => e.GreaterRevelationId);

            builder
                .Entity<Mystery>()
                .HasOne(e => e.MysteryCurse)
                .WithOne(e => e.Mystery)
                .HasForeignKey<Mystery>(e => e.MysteryCurseId);

        }
    }

    public class SearchConfigurator : SearchableEntityConfigurator<Mystery>
    {
        public override Expression<Func<Mystery, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.TrainedSkillAddendum };
        }
    }
}