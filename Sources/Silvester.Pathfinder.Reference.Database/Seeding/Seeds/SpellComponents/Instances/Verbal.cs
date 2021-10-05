using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellComponents.Instances
{
    public class Verbal : Template
    {
        public static readonly Guid ID = Guid.Parse("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f");

        public override SpellComponent GetSpellComponent()
        {
            return new SpellComponent
            {
                Id = ID,
                Name = "Verbal",
                Description = "A verbal component is a vocalization of words of power. You must speak them in a strong voice, so it’s hard to conceal that you’re Casting a Spell.The spell gains the concentrate trait.You must be able to speak to provide this component."
            };
        }
    }
}
