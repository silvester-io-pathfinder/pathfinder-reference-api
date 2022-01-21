using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AberrantWhispers : Template
    {
        public static readonly Guid ID = Guid.Parse("455a8767-4d85-45aa-a6eb-e39ad05640fe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Aberrant Whispers",
                Level = 3,
                Area = "50foot emanation or more.",
                Duration = "1 round.",
                Targets = "Each foe in the area.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9617bd0e-dbc3-48c1-af5b-aa2e3971086e"), Type = TextBlockType.Text, Text = "You utter phrases in an unknown tongue, assaulting the minds of those nearby. Each target must attempt a Will save. Regardless of the result of its save, each target is then temporarily immune for 1 minute. You can increase the number of actions it takes to Cast the Spell (to a maximum of 3 actions total). For each additional action, increase the emanation's radius by 5 feet, to a maximum of 10 extra feet for 3 actions." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c42a4a4f-290c-49f8-b04c-c01b60926a47"),
                Level = "+3",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b3d108f9-d922-4edb-bdf1-f3895cb53c90"), Type = TextBlockType.Text, Text = "The initial radius increases by 5 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6283d467-0532-441d-ac09-6a261d78d347"),
                Success = "The target is unaffected.",
                Failure = "The target is stupefied 2.",
                CriticalFailure = "The target is confused."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2dd40f68-caf9-416a-9f88-78b6c0001861"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("97e3c144-9df2-401f-8a28-48f3595f7d5b"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("dc9de7b4-5f25-432d-ad4f-70167be9acda"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("a8623a40-8d92-45bf-ac3b-5c14f00ac7b3"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("fd47e8f5-479c-43f2-9bb8-a03545b4cb5b"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12f9d5fc-6a2f-49ec-93b7-b92332422582"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 402
            };
        }
    }
}
