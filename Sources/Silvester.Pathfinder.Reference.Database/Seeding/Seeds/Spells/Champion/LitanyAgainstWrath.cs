using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LitanyAgainstWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("3c9d8bd6-264b-42d3-8e6f-1639918cf707");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Litany Against Wrath",
                Level = 3,
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
            yield return new TextBlock { Id = Guid.Parse("13ded45e-51fb-447a-b505-09210b2ef9e3"), Type = TextBlockType.Text, Text = "Your litany rails against the sin of wrath, punishing the target for attacking good creatures. The target must attempt a Will save. A particularly wrathful creature, such as a wrath demon, uses the outcome one degree of success worse than the result of its saving throw. The target then becomes temporarily immune to all of your litanies for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7e5c4e1b-94c4-4cde-a975-17e56f7375f2"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3cf912bd-c641-4d89-8661-aa40ec3a24e0"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }
        
        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("b1b916b4-2c4b-4dcf-982a-9795d148f1f2"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The first time the target uses an action that deals damage to at least one good creature, the target takes 3d6 good damage.",
                Failure = "Each time the target uses an action that deals damage to at least one good creature, the target takes 3d6 good damage.",
                CriticalFailure = "The target is enfeebled 2. Each time it uses an action that deals damage to at least one good creature, the target takes 3d6 good damage."
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
                Id = Guid.Parse("7f721bc2-eaf3-4a9f-be9b-9c7df438b9b8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 388
            };
        }
    }
}
