using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Mystery : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        
        public string? TrainedSkillAddendum { get; set; }

        public Guid MysteryCurseId { get; set; }
        public MysteryCurse MysteryCurse { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid TrainedSkillId { get; set; }
        public Skill TrainedSkill { get; set; } = default!;

        public Guid GrantedCantripId { get; set; }
        public Spell GrantedCantrip { get; set; } = default!;

        public Guid InitialRevelationId { get; set; }
        public Spell InitialRevelation { get; set; } = default!;

        public Guid AdvancedRevelationId { get; set; }
        public Spell AdvancedRevelation { get; set; } = default!;

        public Guid GreaterRevelationId { get; set; }
        public Spell GreaterRevelation { get; set; } = default!;
        
        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<Domain> RelatedDomains { get; set; } = new List<Domain>();

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<TextBlock> MysteryBenefits { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MysteryCurse : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid MysteryId { get; set; }
        public Mystery Mystery { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<MysteryCursePotency> Potencies { get; set; } = new List<MysteryCursePotency>();

        public Guid? TableId { get; set; }
        public Table? Table { get; set; } = default!;
    }

    public class MysteryCursePotency : BaseEntity
    {
        public Guid MysteryCurseId { get; set; }
        public MysteryCurse MysteryCurse { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }

    public class MysteryConfigurator : EntityConfigurator<Mystery>
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

    public class MysterySearchConfigurator : SearchableEntityConfigurator<Mystery>
    {
        public override Expression<Func<Mystery, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.TrainedSkillAddendum };
        }
    }
}
