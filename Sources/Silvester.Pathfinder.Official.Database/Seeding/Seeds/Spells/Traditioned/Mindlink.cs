using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Mindlink : Template
    {
        public static readonly Guid ID = Guid.Parse("106437f4-e6d0-49cc-b271-f057e2c13f68");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mindlink",
                Level = 1,
                Range = "Touch.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6be0dc9-468f-4cc2-8186-94777e2d1232"), Type = TextBlockType.Text, Text = "You link your mind to the target’s mind and mentally impart to that target an amount of information in an instant that could otherwise be communicated in 10 minutes." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1cdbaee5-1c49-433d-ab94-eeb70be62636"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
