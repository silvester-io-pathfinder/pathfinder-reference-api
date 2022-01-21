using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DarkenedEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("b84325e2-a86f-4202-b268-ab755204d7e1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Darkened Eyes",
                Level = 4,
                Range = "60 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Darkness.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d4fe2f8-c5aa-448c-beae-61e60d910bd1"), Type = TextBlockType.Text, Text = "You infuse a creature's vision with darkness. After attempting its save, the target becomes temporarily immune for 24 hours." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("324ced5a-220f-4874-b0d2-7b829b0ee113"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target's darkvision or low-light vision is suppressed for 1 round.",
                Failure = "As success, but the duration is 1 minute.",
                CriticalFailure = "As success, but the duration is 1 minute, and the target is also blinded for the duration. It can attempt a new save at the end of each of its turns. If it succeeds, it's no longer blinded, but its darkvision or low-light vision remains suppressed."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c7a2efe2-7e52-4257-9108-3ddc4a797ffb"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("134f2f12-3c3d-4725-8a7e-6b38ff0c9fca"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("3b42d4ca-e64d-4c75-86ab-8a2a6f493fce"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("c113e000-d960-4480-bd27-e6a2a876b9f2"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47acb694-8c11-43c7-80a0-7d58b2baffd7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
