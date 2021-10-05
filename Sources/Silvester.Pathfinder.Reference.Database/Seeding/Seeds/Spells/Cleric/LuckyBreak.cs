using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LuckyBreak : Template
    {
        public static readonly Guid ID = Guid.Parse("f000b642-63af-4e5a-b206-ad0e96936b43");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lucky Break",
                Level = 4,
                Trigger = "You fail (but don’t critically fail) a saving throw.",
                DomainId = Domains.Instances.Luck.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c839c7d-2805-46f2-9c9a-6ab1b843a27e"), Type = TextBlockType.Text, Text = "Reroll the saving throw and use the better result. You then become temporarily immune for 10 minutes." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b79047ff-26e0-4cb5-9cb4-14720fc795c6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
