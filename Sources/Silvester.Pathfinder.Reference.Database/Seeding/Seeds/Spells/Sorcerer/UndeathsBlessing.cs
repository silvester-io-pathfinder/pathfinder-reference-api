using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class UndeathsBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("85845094-40e3-40cf-8295-8c8e49a4b6fd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Undeath's Blessing",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 living creature touched.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c4a3188-2efd-4877-a1b1-048e7eb8e818"), Type = TextBlockType.Text, Text = "You instill within a creature the touch of the grave. For the duration, harm spells treat the creature as undead and heal spells treat the creature as living. In addition, harm spells gain a +2 status bonus to the Hit Points restored to the target." };
            yield return new TextBlock { Id = Guid.Parse("8e8ce519-7b05-4515-aea3-53e690208892"), Type = TextBlockType.Text, Text = "If the target wishes to avoid the spell, it can attempt a Will save to reduce the effects." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fcc2f7b7-b333-4f72-bd69-2a21b3f1f3a0"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0d6646ba-d746-4dfb-806c-4c5cc26998ec"), Type = TextBlockType.Text, Text = "The status bonus to the Hit Points restored increases by 2." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("42976bf4-1071-4396-96d2-816420011f37"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target heals half as much from heal and takes half as much damage from harm for 1 round.",
                Failure = "Effects as described in the text.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2168b17f-0ed1-4a9a-9b6d-1cda607a871d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
