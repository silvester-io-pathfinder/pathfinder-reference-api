using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Spellshot : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Spellshot",
                DedicationFeatId = Feats.Instances.SpellshotDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Spellshots aren't ordinary gunslingers. They come from a tradition of ancient secrets and principles, which they temper with modern innovation and perspective. Spellshots combine magical power into the art of gunplay to create a distinct and mystical way known only to spellshots, enigmatic and unavailable to other gunslingers in the world at large. The first to identify themselves as spellshots tied their magical traditions to the history of the Star Code and the Crowned Regents in Arcadia. Ancient, reclusive crafters known as the Crowned Regents created star guns, the legendary magical firearms that shot white-hot blasts of energy. Wielders of star guns became bound together by the Star Code—a set of cultural expectations that defined how one should behave while using these powerful weapons. You can find more information about star guns, the Crowned Regents, and the Star Code in Guns & Gears." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Most spellshots continue to come from Arcadia, as the stories describing the relevant skills and training to become one have been passed down over the generations. Many gunslingers who grow up in this region hear of these tales early in their lives, and they develop the techniques to channel magical energy through their firearms in imitation of the Regents' arcane methods. While Arcadia is home to the vast majority of the world's spellshots, the techniques have slowly spread to other regions. However, spellshots remain particularly rare in the Inner Sea region due to the unique history of guns there and their connection to the Grand Duchy of Alkenstar, which exists in a magic-dead region of the Mana Wastes." };

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 140
            };
        }
    }
}
