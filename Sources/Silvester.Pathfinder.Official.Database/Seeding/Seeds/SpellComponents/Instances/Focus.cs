using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellComponents.Instances
{
    public class Focus : Template
    {
        public static readonly Guid ID = Guid.Parse("1438bb9e-3ce3-4b33-93a5-1728b134b9ff");

        public override SpellComponent GetSpellComponent()
        {
            return new SpellComponent
            {
                Id = ID,
                Name = "Focus",
                Description = "A focus is an object that funnels the magical energy of the spell. The spell gains the manipulate trait and requires you to either have a free hand to retrieve the focus listed in the spell or already be holding the focus in your hand. As part of Casting the Spell, you retrieve the focus (if necessary), manipulate it, and can put it away again if you so choose. Foci tend to be expensive, and you need to acquire them in advance to Cast the Spell."
            };
        }
    }
}
