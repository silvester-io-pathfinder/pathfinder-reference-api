using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Suggestion : Template
    {
        public static readonly Guid ID = Guid.Parse("e3535989-0eca-4992-84dc-48515ad2edf3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Suggestion",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f31c4c5-2c3a-4b83-b6e8-8c60d9219756"), Type = TextBlockType.Text, Text = "Your honeyed words are difficult for creatures to resist. You suggest a course of action to the target, which must be phrased in such a way as to seem like a logical course of action to the target and can't be self-destructive or obviously against the target's self-interest. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("aa3ab007-dea1-4328-a38e-5402a8d1f6cd"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12e7ab54-3aff-42a2-b5a3-47ad66ce73f1"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("974e98d4-5080-4555-9683-a7a6854d5494"),
                CriticalSuccess = "The target is unaffected and knows you tried to control it.",
                Success = "The target is unaffected and thinks you were talking to them normally, not casting a spell on them.",
                Failure = "The target immediately follows your suggestion. The spell has a duration of 1 minute, or until the target has completed a finite suggestion or the suggestion becomes self-destructive or has other obvious negative effects.",
                CriticalFailure = "As failure, but the base duration is 1 hour."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c51735ab-2bfa-4ac1-88a2-a2a36e64f210"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("25916de2-aa60-4ed7-9b3a-0882bb597f8b"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("29ec65ba-e7e8-45f2-bcc1-5ab8c33441da"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("32f528c2-1e6a-45c0-99ae-9c8949e4ebcf"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f876bcf-d557-4014-82de-29a35ecb2267"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
