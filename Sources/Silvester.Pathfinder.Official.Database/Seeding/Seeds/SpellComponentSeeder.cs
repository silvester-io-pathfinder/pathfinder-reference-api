using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SpellComponentSeeder : IEntitySeed<SpellComponent>
    {
        public IEnumerable<SpellComponent> GetSeedEntities()
        {
            yield return new SpellComponent { Id = Guid.Parse("4a9cf550-0cb7-4df1-8519-45765fc23af3"), Name = "Material", Description = "A material component is a bit of physical matter consumed in the casting of the spell. The spell gains the manipulate trait and requires you to have a free hand to retrieve and manipulate a material component. That component is expended in the casting (even if the spell is disrupted). Except in extreme circumstances, you can assume all common components are included in a material component pouch." };
            yield return new SpellComponent { Id = Guid.Parse("8665739e-a938-4927-afb6-be0c2d15fdc0"), Name = "Somatic", Description = "A somatic component is a specific hand movement or gesture that generates a magical nexus.The spell gains the manipulate trait and requires you to make gestures.You can use this component while holding something in your hand, but not if you are restrained or otherwise unable to gesture freely. Spells that require you to touch the target require a somatic component. You can do so while holding something as long as part of your hand is able to touch the target(even if it’s through a glove or gauntlet)." };
            yield return new SpellComponent { Id = Guid.Parse("dacdeaaa-2a0e-4cf8-b011-d896947fbf3f"), Name = "Verbal", Description = "A verbal component is a vocalization of words of power. You must speak them in a strong voice, so it’s hard to conceal that you’re Casting a Spell.The spell gains the concentrate trait.You must be able to speak to provide this component." };
            yield return new SpellComponent { Id = Guid.Parse("1438bb9e-3ce3-4b33-93a5-1728b134b9ff"), Name = "Focus", Description = "A focus is an object that funnels the magical energy of the spell. The spell gains the manipulate trait and requires you to either have a free hand to retrieve the focus listed in the spell or already be holding the focus in your hand. As part of Casting the Spell, you retrieve the focus (if necessary), manipulate it, and can put it away again if you so choose. Foci tend to be expensive, and you need to acquire them in advance to Cast the Spell." };
        }
    }
}
