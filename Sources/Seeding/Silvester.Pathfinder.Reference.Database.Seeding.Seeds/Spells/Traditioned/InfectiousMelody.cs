using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InfectiousMelody : Template
    {
        public static readonly Guid ID = Guid.Parse("84640b7a-c0fe-49ba-9fff-9ce1cfb43472");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Infectious Melody",
                Level = 4,
                Duration = "Varies.",
                Targets = "Enemies in the area.",
                Area = "15-foot emanation.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95728cab-b00b-4bf0-82c7-1f1f3f6889f8"), Type = TextBlockType.Text, Text = "You call forth the chords of a tune so catchy that foes hearing it can't help but sing along, making it harder for them to communicate. Each target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("0ead7308-a8b9-44df-96e2-9dd99e07d511"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "For 1 round, the creature can communicate only by singing along to the melody. It can speak only on its turn, and it must take the Perform action when it does. The result of the Performance check determines how well it sang, but it stills communicate the information regardless of the result, which has no further mechanical impact than the time spent to take the action. A single Perform check is sufficient for any amount of speaking on the creature's turn. This effect might interfere with verbal components of spells or other linguistic abilities that rely on precise speech; in order to use such an ability successfully, the creature must succeed at a DC 5 flat check. In addition, the creature takes a -2 status penalty on linguistic Intimidation checks, as singing its threats saps away some of the menace. The creature's constant humming of the tune also makes it nearly impossible for the creature to remain undetected.",
                Failure = "As success, but the duration is 3 rounds.",
                CriticalFailure = "As success, but the duration is 1 hour."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("745f4ddc-dafd-4d60-adbc-5d4b40be0e73"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("c8d60fcd-4857-4abc-a56c-42e9da86f125"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("a04ef40d-5bee-4251-8f3c-20001d8661c3"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f596573-8e92-4b5e-805a-d43719ee148d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 112
            };
        }
    }
}
