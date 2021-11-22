using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoulSiphon : Template
    {
        public static readonly Guid ID = Guid.Parse("de8437fe-a9a2-4e25-b69a-9af413281871");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soul Siphon",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17e82c6e-02ee-43c7-a911-4d5446438dfa"), Type = TextBlockType.Text, Text = "You siphon off a portion of the target's soul to bolster your own vitality. The target must attempt a Fortitude save or take 1d4 negative damage. You gain temporary Hit Points equal to the total amount of HP the target loses, including the HP lost from becoming drained." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a7371247-6a94-42b4-9838-403038410b55"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("94cc1f60-2f67-4e64-9c31-4d3322f8fe33"), Type = TextBlockType.Text, Text = "Increase the damage by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ce1a6ed1-c1cd-4761-a376-417ebc3de70f"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and becomes drained 1.",
                CriticalFailure = "The creature takes double damage and becomes drained 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b2748c2-4100-4383-8c70-e97c00f4b551"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
