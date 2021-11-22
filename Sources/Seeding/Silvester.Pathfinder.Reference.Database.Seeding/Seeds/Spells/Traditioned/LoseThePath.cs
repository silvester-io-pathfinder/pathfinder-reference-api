using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LoseThePath : Template
    {
        public static readonly Guid ID = Guid.Parse("2a5f0847-7377-4cb0-ac22-0924452b44d9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lose the Path",
                Level = 1,
                Range = "60 feet.",
                Trigger = "A creature in range Strides.",
                Targets = "The triggering creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39181e0d-be0d-4b38-8bf9-3291c0e3eebc"), Type = TextBlockType.Text, Text = "You surround a moving creature with lifelike illusions, shifting their perception of the terrain to subtly lead them off course. The target must attempt a Will save. Regardless of the result, the creature is immune to lose the path for 1 hour." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("73178a7f-9a8e-4af4-82bf-4d71dd1ee658"),
                Success = "The creature is unaffected.",
                Failure = "The creature treats all squares as difficult terrain for its Stride.",
                CriticalFailure = "As failure, except that you determine where the target moves during the Stride, though you can�t move it into hazardous terrain or to a place it can�t stand."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01d4bfa5-7d5a-49de-96e0-21bcbdd928c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 113
            };
        }
    }
}
