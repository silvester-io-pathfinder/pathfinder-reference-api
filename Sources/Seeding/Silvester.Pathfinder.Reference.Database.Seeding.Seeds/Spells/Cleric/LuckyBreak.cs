using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
                Trigger = "You fail (but don't critically fail) a saving throw.",
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6de8b06b-e71a-4af0-b2a4-712e38fbde6b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("de7ef164-f06b-4dfa-832e-340180240e32"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("e02ba9a9-dc2d-49da-8d11-f3a899964e4c"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("91f29470-7884-4878-8c3f-24369db12c9c"), Traits.Instances.Fortune.ID);
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
