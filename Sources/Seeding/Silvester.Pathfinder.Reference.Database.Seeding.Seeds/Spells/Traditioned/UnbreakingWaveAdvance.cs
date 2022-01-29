using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnbreakingWaveAdvance : Template
    {
        public static readonly Guid ID = Guid.Parse("5f614078-9c0e-4e09-8c8c-c326d858c23f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unbreaking Wave Advance",
                Level = 3,
                Area = "15-foot cone.",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2065b65d-c3e0-4723-bde6-85fb5235bb8e"), Type = TextBlockType.Text, Text = "You unleash a mighty wave from your hand that buffets back your foes. Each creature in the area must attempt a Fortitude saving throw. If a creature pushed by unbreaking wave advance would be pushed into a solid barrier or another creature, it stops at that point and takes 3d6 damage." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("18316634-91b9-4f34-bf29-03487ad7d708"),
                Success = "The creature is unaffected",
                Failure = "The creature is pushed 10 feet.",
                CriticalFailure = "The creature is pushed 20 feet."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cada1e06-c14d-461b-968a-e57b52c26ff9"),
                Level = "+1",
                Details = new TextBlockBuilder()
                    .Text(Guid.Parse("028a8ea7-2583-42aa-a135-f94e04ed9f2b"), "The damage for pushing a creature into a solid barrier increases by 1d6.")
                    .Build()
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("afc45225-506b-4ffe-b7d0-17d4aa1fb506"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3b7753c9-56bb-40da-9764-9a62c073c984"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("fb5f776b-072c-422c-98e4-e84d3cb1570b"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d4487b2-7914-42b9-9811-69ebcd3cc097"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 83
            };
        }
    }
}
