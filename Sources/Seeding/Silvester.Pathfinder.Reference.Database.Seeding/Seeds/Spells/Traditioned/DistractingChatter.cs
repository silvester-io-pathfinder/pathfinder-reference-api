using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DistractingChatter : Template
    {
        public static readonly Guid ID = Guid.Parse("18f66992-fbb3-4316-b0a0-f9c841f502f2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Distracting Chatter",
                Level = 3,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("278e79c4-5491-4690-b3a3-48533bbb9ced"), Type = TextBlockType.Text, Text = "You bombard a target with distracting auditory illusions, surrounding them with a tumultuous cacophony of overlapping speech, whispers, screams, and muttering. The target is flat-footed, takes a �2 status penalty to purely auditory Perception checks, and must succeed at a DC 5 flat check to use auditory abilities or verbal spell components. Similarly, a creature who attempts to affect the target with an auditory effect must succeed at a DC 5 flat check or the attempt fails. The duration depends on the target�s Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1096e1da-7104-4a31-a58b-497530f6e718"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("10061b9b-32db-454a-9cac-06149046db08"), Type = TextBlockType.Text, Text = "You can target up to five creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("b1f392de-0510-44af-854b-fe6cbeb30286"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The duration is 1 round.",
                Failure = "The duration is 3 rounds.",
                CriticalFailure = "The duration is 1 minute."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29dd4b0e-ad51-4684-b670-1f5f067239f6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 100
            };
        }
    }
}
