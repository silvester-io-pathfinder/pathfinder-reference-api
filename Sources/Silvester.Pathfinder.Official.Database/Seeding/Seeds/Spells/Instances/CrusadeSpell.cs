using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CrusadeSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";
        
        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("e4568cde-13d1-4684-81b2-180bc291198f"),
                Name = "Crusade",
                Description = "You issue a divine mandate or proclaim a cause to the targets. It can be to attain an item, claim a patch of land, slay a creature, war with a group, or be entirely peaceful. Your cause can’t force the targets to harm one another or themselves. The targets become completely dedicated to that cause, depending on their levels. They choose their own actions, but they favor direct action over inaction or indirect action.",
                Level = 9,
                Range = 60,
                Targets = "Up to 4 creatures.",
                Duration = "4 minutes."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("9e535072-b4b7-428e-94c3-898de6ca0ab6"), Text = "- 13th or Lower: The target is so dedicated to the cause that it pursues the cause to the death (unless you say otherwise)." };
            yield return new SpellDetailBlock { Id = Guid.Parse("45983a64-0a25-4eba-9eaf-d050a4b49d11"), Text = "- 14th: The target is dedicated to the cause, but the spell ends for the target if it’s reduced to half its maximum Hit Points or fewer." };
            yield return new SpellDetailBlock { Id = Guid.Parse("f3e7e74b-556d-46f8-87fe-861544c2331b"), Text = "- 15th: As 14th, plus the target can attempt a Will save at the end of each of its turns to end the spell for itself." };
            yield return new SpellDetailBlock { Id = Guid.Parse("c474670c-dd98-40b0-a6fc-f5d19f51fec1"), Text = "The spell ends for all creatures if you or one of your allies uses a hostile action against a target, or when the cause is completed. The GM might determine this spell has alignment traits befitting the cause." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("7c4a2e8b-867f-4b2b-816a-535e3eb0fc79"), Level = 10, Description = "The level for each category increases by 2." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Enchantment";
            yield return "Linguistic";
            yield return "Mental";
        }
    }
}
