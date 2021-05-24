using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClingingIce : Template
    {
        public static readonly Guid ID = Guid.Parse("8a559f6c-9fa7-49d8-bd98-29ff051260cd");

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
            yield return new TextBlock { Id = Guid.Parse("1d8dbc57-75cb-43cd-b439-c103928f601d"), Type = TextBlockType.Text, Text = "Freezing sleet and heavy snowfall collect on the target’s feet and legs, dealing 1d4 cold damage and other effects depending on its Reflex save. Once this spell ends, the target becomes temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f33d1c8e-0182-49d6-ada7-27374ae50b81"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b1db6e08-5de5-41ab-b124-94888f662c89"), Type = TextBlockType.Text, Text = "The damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("58e988a4-3ded-4ab8-929d-66b2332d713e"),
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
                Id = Guid.Parse("b75d20f2-a9d3-477f-8894-5703c34add31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
