using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Items
{
    public abstract class BaseItem : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string? AccessRequirements { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<BaseItemTraitBinding> TraitBindings { get; set; } = new List<BaseItemTraitBinding>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<BaseItemVariant> Variants { get; set; } = new List<BaseItemVariant>();
        public ICollection<InlineAction> InlineActions { get; set; } = new List<InlineAction>();
    }

    public class BaseItemTraitBinding : TraitBinding<BaseItem>
    {

    }

    public abstract class BaseItemVariant : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? CraftingRequirements { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid ItemId { get; set; }
        public BaseItem Item { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; }

        public ICollection<TextBlock> Addendum { get; set; } = new List<TextBlock>();
        public ICollection<InlineAction> InlineActions { get; set; } = new List<InlineAction>();
    }
}
