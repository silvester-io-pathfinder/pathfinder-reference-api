using NpgsqlTypes;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Lore : BaseEntity, ISearchableEntity, INamedEntity
    {
        public virtual string Name { get; set; } = default!;

        public Guid StatModifierId { get; set; }
        public Stat StatModifier { get; set; } = default!;
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DeityLore : Lore
    {
        public Guid DeityId { get; set; }
        public Deity Deity { get; set; } = default!;

        public override string Name { get; set; } = "Deity";
    }

    public class CreatureLore : Lore
    {
        public string Creature { get; set; } = default!;
        public override string Name { get; set; } = "Creature";
    }

    public class TerrainLore : Lore
    {
        public string Terrain { get; set; } = default!;
        public override string Name { get; set; } = "Terrain";
    }

    public class SettlementLore : Lore
    {
        public string Settlement { get; set; } = default!;
        public override string Name { get; set; } = "Settlement";
    }

    public class ConsumableLore : Lore
    {
        public string Consumable { get; set; } = default!;
        public override string Name { get; set; } = "Consumable";
    }

    public class PlaneLore : Lore
    {
        public Guid PlaneId { get; set; }
        public Plane Plane { get; set; } = default!;

        public override string Name { get; set; } = "Plane";
    }
}
