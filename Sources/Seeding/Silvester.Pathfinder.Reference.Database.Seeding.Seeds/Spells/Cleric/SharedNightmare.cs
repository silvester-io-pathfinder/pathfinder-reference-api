using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SharedNightmare : Template
    {
        public static readonly Guid ID = Guid.Parse("c481cb2f-cd45-4d1c-9088-ecc88e2cdd5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shared Nightmare",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Nightmares.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6693f7dd-046e-40b4-a98c-7069b8257cec"), Type = TextBlockType.Text, Text = "Merging minds with the target, you swap disorienting visions from one another's nightmares. One of you will become confused, but which it'll be depends on the target's Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d3c6de44-d9cf-46d1-abc4-589bec0edb75"),
                CriticalSuccess = "You are confused for 1 round.",
                Success = "At the start of your next turn, you spend your first action with the confused condition, then act normally.",
                Failure = "As success, but the target is affected instead of you, spending its first action each turn confused. The duration is 1 minute.",
                CriticalFailure = "The target is confused for 1 minute."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c25d092a-dc3b-4909-af6c-5432471b9bd9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("38eb4abe-023e-4954-aebb-5b127e97bf1d"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("d8d8dff9-5e81-49ed-bf74-bb40b0aa8ce3"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("fc8097fc-ab85-469d-8929-8dcef9f47e41"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("d8238461-6c9a-4b26-87c0-9cbfb1368b24"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("ee0fc65f-56d0-407b-8733-137960145850"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31d20aac-5a9b-42cf-8483-3d40e10402b9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
