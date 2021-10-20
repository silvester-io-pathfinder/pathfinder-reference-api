using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificArmorEffect : Effect
    {
        public Guid ArmorId { get; set; }
        public Armor Armor { get; set; } = default!;
    }
}
