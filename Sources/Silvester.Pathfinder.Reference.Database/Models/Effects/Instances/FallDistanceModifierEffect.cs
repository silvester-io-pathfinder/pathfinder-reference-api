using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class FallDistanceModifierEffect : Effect
    {
        public int Modifier { get; set; }
        public ModifierType ModifierType { get; set; }
    }
}
