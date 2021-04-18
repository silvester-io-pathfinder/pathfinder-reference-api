using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CreationSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("311b0146-7b80-4594-800f-b0046237d47f"),
                Name = "Creation",
                Level = 4,
                Range = 0,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "1 hour."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10f19591-1df1-4976-802c-12a27265350f"), Type = Utilities.Text.TextBlockType.Text, Text = "You conjure a temporary object from eldritch energy. It must be of vegetable matter (such as wood or paper) and 5 cubic feet or smaller. It can’t rely on intricate artistry or complex moving parts, never fulfills a cost or the like, and can’t be made of precious materials or materials with a rarity of uncommon or higher. It is obviously temporarily conjured, and thus can’t be sold or passed off as a genuine item." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("480f3fc8-55c9-4961-8572-5cc86cc4ca85"), 
                Level = 5,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("10273eee-70b6-4b64-9119-e1ca2dc37a7f"), Type = Utilities.Text.TextBlockType.Text, Text = "The item is metal and can include common minerals, like feldspar or quartz." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Conjuration";
        }
    }
}
