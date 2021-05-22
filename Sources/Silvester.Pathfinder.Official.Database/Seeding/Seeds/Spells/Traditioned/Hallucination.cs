using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Hallucination : Template
    {
        public static readonly Guid ID = Guid.Parse("ba088a8d-3acd-4ae3-b661-9043201478b5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hallucination",
                Level = 5,
                Range = "30 feet.",
                Duration = "",
                Targets = "",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b564e15e-4a2b-4622-84a4-64d90e74671a"), Type = TextBlockType.Text, Text = "The target consistently detects one thing as another, can’t detect something that’s there, or detects something that’s not there, though it doesn’t alter their beliefs. You choose which of these effects applies, and you determine the specifics of the hallucination. For example, you could make the target see all elves as humans, be unable to detect the presence of their brother, see their beloved pocket watch on their person even when it isn’t, or see a tower in the center of town." };
            yield return new TextBlock { Id = Guid.Parse("c5c6d878-ba21-4d16-b633-2afd65d3fe11"), Type = TextBlockType.Text, Text = "The target can attempt an initial Will save, with effects below. They also receive a Will save to disbelieve the hallucination every time they Seek or directly interact with the hallucination. For example, the target could attempt to disbelieve the hallucination each time they interacted with an elf, bumped into their brother accidentally, tried to check their pocket watch, or studied the tower. The target can attempt to disbelieve with a large circumstance bonus in situations determined by the GM, such as if the target attempted to climb the nonexistent tower." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("92cca1b1-46c2-4d2f-b7d9-f9a67b2ec7c5"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5566b799-f228-41ee-b609-b2f48ad0307b"), Type = TextBlockType.Text, Text = "Choose to either target up to 10 creatures or change the spell’s duration to until the next time you make your daily preparations." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("ab0fb0e7-7fa6-46be-a6a3-b2192871998a"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0cea56a5-d1cf-4df4-b753-d1ac3990c1e9"), Type = TextBlockType.Text, Text = "Choose to either target any number of creatures or change the spell’s duration to unlimited." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("953de49c-c10b-4456-a387-f27ff371db76"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature perceives what you chose until it disbelieves, but it knows what the hallucination is.",
                Failure = "The creature perceives what you chose until it disbelieves.",
                CriticalFailure = "The creature perceives what you chose until it disbelieves, and it trusts its false senses, taking a –4 circumstance penalty to saves to disbelieve."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6ec7ef9-e19d-4496-bb37-77267f259b8c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 342
            };
        }
    }
}
