using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BalefulPolymorph : Template
    {
        public static readonly Guid ID = Guid.Parse("79fbdd8a-c496-4974-af00-14c3640841ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Baleful Polymorph",
                Level = 6,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("435f323d-f2ba-4a44-b7fb-05738ce88cdd"), Type = Utilities.Text.TextBlockType.Text, Text = "You transform the target creature into a harmless animal appropriate to the area, with effects based on its Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f5e8d362-20e3-4342-bd65-73ca29c1825b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target's body gains minor features of the harmless animal. Its insides churn as they partially transform, causing it to be sickened 1. When it recovers from the sickened condition, its features revert to normal.",
                Failure = "The target transforms for 1 minute but keeps its mind. If it spends all its actions on its turn concentrating on its original form, it can attempt a Will save to end the effect immediately.",
                CriticalFailure = "The target is transformed into the chosen harmless animal, body and mind, for an unlimited duration."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f006965a-ada2-4782-9493-f527a18aa6ab"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("9e23725f-5ecf-4374-81ff-86b3ab1f88dd"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("f2698835-0cdd-4dcd-aeb2-9c5c4094c862"), Traits.Instances.Polymorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9228896-0ede-4301-945a-447a527f1363"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 320
            };
        }
    }
}
