using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Snowball : Template
    {
        public static readonly Guid ID = Guid.Parse("71611c6f-c1c7-448a-b5fb-e2dfab37f653");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Snowball",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5741a58-e088-4fe4-b546-d8ff500b7928"), Type = TextBlockType.Text, Text = "You throw a magically propelled and chilled ball of dense snow. The target takes 2d4 cold damage and potentially other effects, depending on the result of your spell attack roll." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b192eb0f-a8ba-42d0-b34a-8428d4e8e630"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c348f522-24e2-42b5-a3d2-e7566b2828f9"), Type = TextBlockType.Text, Text = "The damage increases by 2d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("3c131fb0-57a4-458b-96b4-a439b33e0b09"),
                CriticalSuccess = "The target takes double damage and a �10-foot status penalty to its Speeds for 1 round.",
                Success = "The target takes full damage and a �5-foot status penalty to its Speeds for 1 round.",
                Failure = "No effect.",
            };
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
            builder.Add(Guid.Parse("2d0d59eb-56a1-452b-9bcb-91e33960020a"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("c1f4d0c6-1638-4036-9619-a0139ce109b5"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("aec09084-ba5e-4847-a240-3b9478f5233c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("03f04d69-96dd-49e9-959e-7062ef83e314"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6070e2b5-f610-4b73-b2e8-96b499a85168"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 112
            };
        }
    }
}
