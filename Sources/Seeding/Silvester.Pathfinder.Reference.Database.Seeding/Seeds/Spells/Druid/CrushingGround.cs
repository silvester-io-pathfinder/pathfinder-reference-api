using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CrushingGround : Template
    {
        public static readonly Guid ID = Guid.Parse("e17fb9dd-8232-4591-bfdb-8ed52b6c7cec");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Crushing Ground",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                Duration = "1 round.",
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5fa1589b-7a6a-4ffe-a772-1131d5fc61e6"), Type = TextBlockType.Text, Text = "You tear open the ground then slam it shut. The target creature takes 2d6 bludgeoning damage with a Reflex save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("782a5ffb-3e18-4f5a-9305-a9c26af38ca1"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage, is flat-footed, and takes a �10-foot circumstance penalty to Speed.",
                CriticalFailure = "The target takes double damage and is flat-footed and immobilized. It can attempt to Escape against your spell DC. If it doesn't Escape, the target takes an additional 2d6 bludgeoning damage when the spell ends."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5074b063-55aa-47bf-aeee-119bec0c9f2d"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c57cf85b-e4ad-429d-a1db-7f3cdf7b7a44"), Type = TextBlockType.Text, Text = "Increase the initial damage and additional damage by 2d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c6833a1-637e-41da-97e0-a6bbd747cefd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 200
            };
        }
    }
}
