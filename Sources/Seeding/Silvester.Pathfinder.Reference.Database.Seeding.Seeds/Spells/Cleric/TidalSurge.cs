using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TidalSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("b81a1364-8a8a-45b6-9a13-5f6432dda10b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tidal Surge",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Water.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("721ca1ca-588a-493d-ba3b-45106088814c"), Type = TextBlockType.Text, Text = "You call forth a tremendous wave to move the target either in a body of water or on the ground. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1baa4525-6eef-4b9f-adeb-60df5497edc8"),
                Failure = "You move the target 5 feet in any direction along the ground or 10 feet in any direction through a body of water.",
                CriticalFailure = "You move the target up to 10 feet in any direction along the ground or 20 feet in any direction through a body of water."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("cdc8ddce-269d-4e6f-a143-f8c34160d2d9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7e7fbf6c-5a26-4ece-bd11-07259ceb30c2"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("ac1c58f9-c047-4e7f-b15e-9eff552ec5c1"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("dfb7d177-e59d-4a46-8055-3d552ba0756d"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92a0dee3-f391-468e-aba3-a930a0aaa2c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
