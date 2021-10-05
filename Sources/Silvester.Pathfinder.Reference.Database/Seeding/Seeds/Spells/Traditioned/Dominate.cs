using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Dominate : Template
    {
        public static readonly Guid ID = Guid.Parse("f60c59d1-d117-4f9a-8ef1-ef4defab2bf8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dominate",
                Level = 6,
                Range = "30 feet.",
                Duration = "Until the next time you make your daily preparations.",
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
            yield return new TextBlock { Id = Guid.Parse("854f9ba4-d984-4022-a611-0308695b7280"), Type = TextBlockType.Text, Text = "You take command of the target, forcing it to obey your orders. If you issue an obviously self-destructive order, the target doesn’t act until you issue a new order. The effect depends on its Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8e7a740a-8ac0-4d35-9f6d-a4deeec6c26c"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12fef6d4-f358-46b4-ac89-264e260c5ed5"), Type = TextBlockType.Text, Text = "The duration is unlimited." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("cbe04376-fd3e-4efa-8a70-e4b123ea307a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stunned 1 as it fights off your commands.",
                Failure = "You control the target. It gains the controlled condition, but it can attempt a Will save at the end of each of its turns. On a success, the spell ends.",
                CriticalFailure = "As a failure, but the target receives a new save only if you give it a new order that is against its nature, such as killing its allies."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58d85c84-558d-40bd-8eb7-15e6d412dc69"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 332
            };
        }
    }
}
