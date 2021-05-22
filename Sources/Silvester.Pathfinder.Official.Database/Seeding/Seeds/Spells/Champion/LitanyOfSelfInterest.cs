using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LitanyOfSelfInterest : Template
    {
        public static readonly Guid ID = Guid.Parse("3000a92d-b7e9-477e-8d60-06bec208fbe2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Litany of Self-Interest",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cde541e4-870e-4d6b-a046-f5a6096a7aab"), Type = TextBlockType.Text, Text = "You give a speech that fills your target with a drive to improve themself to the exclusion of assisting others. A creature that wants to gain the benefit of this spell and doesn’t care about its limitations can voluntarily fail the save. The target then becomes temporarily immune to all your litanies for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2e5a361c-a469-4bad-99d3-75ef81fb3538"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9e81627e-6efa-4548-ae29-ae407bde0dfb"), Type = TextBlockType.Text, Text = "The status bonus increases to +3." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("cd7a460f-3985-4ab9-a876-7da31b5f83e6"),
                Success = "The target is unaffected.",
                Failure = "The target gains a +2 status bonus to attack rolls, Perception checks, saving throws, and skill checks. The target can’t Aid other creatures, consider any creature an ally, or use spells or abilities that directly benefit another creature (as determined by the GM), even if they also benefit the target. Other creatures allied with the spell’s target can still consider the target an ally and affect it accordingly.",
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Litany.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08cae253-31fd-45b7-9c85-3db508b27842"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
