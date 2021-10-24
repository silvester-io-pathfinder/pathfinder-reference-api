using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellComponents.Instances
{
    public class Somatic : Template
    {
        public static readonly Guid ID = Guid.Parse("8665739e-a938-4927-afb6-be0c2d15fdc0");

        public override SpellComponent GetSpellComponent()
        {
            return new SpellComponent
            {
                Id = ID,
                Name = "Somatic",
                Description = "A somatic component is a specific hand movement or gesture that generates a magical nexus.The spell gains the manipulate trait and requires you to make gestures.You can use this component while holding something in your hand, but not if you are restrained or otherwise unable to gesture freely. Spells that require you to touch the target require a somatic component. You can do so while holding something as long as part of your hand is able to touch the target(even if it’s through a glove or gauntlet)."
            };
        }
    }
}
