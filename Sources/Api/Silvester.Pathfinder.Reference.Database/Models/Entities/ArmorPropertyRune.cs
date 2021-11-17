using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ArmorPropertyRune : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? CraftingRequirements { get; set; }

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? ActionId { get; set; }
        public ArmorPropertyRuneAction? Action { get; set; } 

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArmorPropertyRuneAction : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Effect { get; set; } = default!;

        public string? Frequency { get; set; }

        public string? Trigger{ get; set; }

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid RuneId { get; set; }
        public ArmorPropertyRune Rune { get; set; } = default!;
    }

    public class ArmorPropertyRunePotencyBinding : BaseEntity
    {
        public int Price { get; set; }
        
        public int ItemLevel { get; set; }

        public string Benefits { get; set; } = default!;

        public Guid RuneId { get; set; }
        public ArmorPropertyRune Rune { get; set; } = default!;

        public Guid PotencyId { get; set; }
        public Potency Potency { get; set; } = default!;
    }

    public class ArmorPropertyRuneConfigurator : EntityConfigurator<ArmorPropertyRune>
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

    public class ArmorPropertyRuneSearchConfigurator : SearchableEntityConfigurator<ArmorPropertyRune>
    {
        public override Expression<Func<ArmorPropertyRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.CraftingRequirements };
        }
    }
}
