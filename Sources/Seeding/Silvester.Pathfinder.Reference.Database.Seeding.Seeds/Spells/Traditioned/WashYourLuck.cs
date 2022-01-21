using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WashYourLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("9b984f1c-31d7-4ee3-8035-0ecce12fd62b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wash your Luck",
                Level = 1,
                Range = "",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c1bf9d8-060a-4a49-b0aa-320d22d49586"), Type = TextBlockType.Text, Text = "Some practitioners argue this spell literally washes your fortunes of all influences, malign or benign, while others claim it simply cleanses your mind of obsessions about luck and destiny. You adjust your garments, change the posture of your chair, fidget with a religious symbol, or make some other innocuous and personally significant action to wash away bad luck." };
            yield return new TextBlock { Id = Guid.Parse("1510ae50-74dc-4f00-b06b-b99881efa81e"), Type = TextBlockType.Text, Text = "Once during the spell�s duration, before rolling a check, you can cancel out a misfortune effect on that roll, as normal when a fortune and misfortune effect apply to the same roll. After canceling out the misfortune effect, the spell ends, and you are then temporarily immune to wash your luck for 10 minutes." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c25db77d-d2e5-4ffc-b4c8-dbd189c7b5bf"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("3ed6b925-1d77-4927-906f-cce21b15ee48"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("2c51e260-916d-4eeb-8639-8219f059d4b5"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f4a4c90-27b9-4d62-8754-d947e7d8ccb0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 140
            };
        }
    }
}
