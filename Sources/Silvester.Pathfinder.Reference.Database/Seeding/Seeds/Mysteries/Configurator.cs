using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Mysteries
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