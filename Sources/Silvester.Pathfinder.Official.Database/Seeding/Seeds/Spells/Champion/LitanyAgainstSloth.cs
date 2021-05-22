using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LitanyAgainstSloth : Template
    {
        public static readonly Guid ID = Guid.Parse("43cd8c45-8865-4690-bddd-0f8401e88ba9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Litany Against Sloth",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 evil creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c108a13-0b1e-4bce-9655-fb15a599553a"), Type = TextBlockType.Text, Text = "Your litany rails against the sin of sloth, interfering with the target’s ability to react. The target must attempt a Will save. A particularly slothful creature, such as a sloth demon, uses the outcome one degree of success worse than the result of its saving throw. The target becomes temporarily immune to all of your litanies for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8f4531ff-e507-44b7-8e9c-e2e2d08de426"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target can’t use reactions.",
                Failure = "The target can’t use reactions and is slowed 1.",
                CriticalFailure = "The target can’t use reactions and is slowed 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Champion.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Good.ID;
            yield return Traits.Instances.Litany.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f19bcaa-ded8-4139-9b82-d6452706ce68"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 388
            };
        }
    }
}
