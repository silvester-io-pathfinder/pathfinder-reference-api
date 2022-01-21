using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ControlWater : Template
    {
        public static readonly Guid ID = Guid.Parse("b2cc63b2-466a-478a-b024-b785f2b722de");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Control Water",
                Level = 5,
                Range = "500 feet.",
                Area = "50 feet long by 50 feet wide",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ecde9a96-ca65-4f65-85aa-9500e8417229"), Type = Utilities.Text.TextBlockType.Text, Text = "By imposing your will upon the water, you can raise or lower the level of water in the chosen area by 10 feet. Water creatures in the area are subjected to the effects of slow." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e76b4cd5-70dc-44f5-a519-73cab123d36f"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("c6aed1d2-2508-4071-91f3-59fbfb284ccf"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5909291e-edd2-46bd-92ec-d44f4e3c2204"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
