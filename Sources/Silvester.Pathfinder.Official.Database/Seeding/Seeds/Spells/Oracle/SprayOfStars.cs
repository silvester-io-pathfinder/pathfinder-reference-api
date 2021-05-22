using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SprayOfStars : Template
    {
        public static readonly Guid ID = Guid.Parse("849ede9e-7dd9-434e-89e7-a2f10636bb08");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spray of Stars",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
                MysteryId = Mysteries.Instances.Cosmos.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6a06002-c567-4c5d-8133-dbed8a879807"), Type = TextBlockType.Text, Text = "You fling a spray of tiny shooting stars, dealing 1d4 fire damage. Each creature in the area must attempt a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b7092efb-af3b-4392-9b20-956b20e75ab3"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4e39b45d-c1ec-4247-824b-b2d33d08fc41"), Type = TextBlockType.Text, Text = "Increase the damage by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("86e51afa-81ff-42ec-afb2-5bd6265ac87e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and is dazzled for 1 round.",
                Failure = "The creature takes full damage and is dazzled for 3 rounds.",
                CriticalFailure = "The creature takes double damage and is dazzled for 1 minute."
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
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20819c9a-def4-4faa-86fc-65e461b2fcff"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
