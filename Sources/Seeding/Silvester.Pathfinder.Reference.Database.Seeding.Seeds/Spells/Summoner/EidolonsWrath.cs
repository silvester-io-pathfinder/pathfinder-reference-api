using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EidolonsWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("f585a1b3-830d-43c2-af96-07df465b5c94");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Eidolon's Wrath",
                Level = 3,
                Area = "20-foot radius emanation around your eidolon.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0255404e-9d3e-44c9-9022-c86665e40660"), Type = TextBlockType.Text, Text = "Your eidolon releases a powerful energy attack that deals 5d6 damage of the type you chose when you took the Eidolon�s Wrath feat, with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3f8837e6-24e0-4923-8611-2cd5112f6ddd"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3cef545a-929b-4c51-b2c7-73b0cf1e1bd9"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ab100123-80c2-49c2-84ea-2ef1026e2067"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("70b9009b-a50b-4c27-afe9-1e8641af6c61"), Traits.Instances.Eidolon.ID);
            builder.Add(Guid.Parse("7ec41e71-730b-4f3a-bbf9-787ae42c2bed"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("4ef9e4de-ac30-4013-a60f-3673a9344e25"), Traits.Instances.Summoner.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba48b867-936d-4b5e-8580-00a1f1b0cea1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
