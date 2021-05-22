using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClingingIce : Template
    {
        public static readonly Guid ID = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clinging Ice",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c"), Type = TextBlockType.Text, Text = "Freezing sleet and heavy snowfall collect on the target’s feet and legs, dealing 1d4 cold damage and other effects depending on its Reflex save. Once this spell ends, the target becomes temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage, and takes a –5-foot circumstance penalty to its Speeds until the spell ends.",
                CriticalFailure = "The target takes double damage and a –10-foot circumstance penalty to its Speeds until the spell ends."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1b38c8b-9893-4320-b511-2e2171b12f8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
