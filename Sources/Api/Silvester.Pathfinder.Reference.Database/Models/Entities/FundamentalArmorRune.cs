using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class FundamentalArmorRune : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class FundamentalArmorRuneVariant : BaseEntity
    {
        public string Name { get; set; } = default!;
        
        public int Price { get; set; }

        public int ItemLevel { get; set; }

        public string Benefits { get; set; } = default!;

        public string? CraftingRequirements { get; set; }

        public Guid RuneId { get; set; }
        public FundamentalArmorRune Rune { get; set; } = default!;
    }

    public class FundamentalArmorRuneSearchConfigurator : SearchableEntityConfigurator<FundamentalArmorRune>
    {
        public override Expression<Func<FundamentalArmorRune, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
