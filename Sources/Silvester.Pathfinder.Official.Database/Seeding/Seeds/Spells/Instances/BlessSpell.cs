using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlessSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Enchantment";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("51df17bf-ef57-4eed-973c-55cf33285b61"),
                Name = "Bless",
                Level = 1,
                Area = "5-foot emanation",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84937ca3-5b7a-4529-9930-4145419e858b"), Type = Utilities.Text.TextBlockType.Text, Text = "Blessings from beyond help your companions strike true. You and your allies gain a +1 status bonus to attack rolls while within the emanation. Once per turn, starting the turn after you cast bless, you can use a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet. Bless can counteract bane." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Enchantment";
            yield return "Mental";
        }
    }
}
