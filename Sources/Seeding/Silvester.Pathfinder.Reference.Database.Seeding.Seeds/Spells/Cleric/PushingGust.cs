using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PushingGust : Template
    {
        public static readonly Guid ID = Guid.Parse("8ba9e8e6-7902-49c0-8d3a-aff76bcd8a9b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pushing Gust",
                Level = 1,
                Range = "500 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Air.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61a44a33-b2ed-4021-ab9e-d29ed24fe47f"), Type = TextBlockType.Text, Text = "Giving the air a push, you buffet the target with a powerful gust of wind; it must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("7448f1d4-f500-4a12-9f94-66cca30061bd"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is pushed 5 feet away from you.",
                Failure = "The target is pushed 10 feet away from you.",
                CriticalFailure = "The target is pushed 10 feet away from you and knocked prone."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("13b76dad-2477-43d1-8e8f-d42eaef821e1"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("70567fa9-c7e8-4c78-8074-dcbd997a8974"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("2780273b-3729-49e7-9f74-77a5ead58ca5"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("ec28d2e3-8c90-4435-8ded-6a1963a456d1"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b6bc5ba-2e21-4727-8bf9-9bcd01970f6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 395
            };
        }
    }
}
