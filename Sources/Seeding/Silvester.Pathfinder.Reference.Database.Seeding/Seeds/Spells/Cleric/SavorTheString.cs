using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SavorTheString : Template
    {
        public static readonly Guid ID = Guid.Parse("2ae88ff7-9177-406b-99ec-05fdd4263943");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Savor the String",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Pain.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f3b3211-80d2-41b2-8981-292b02cfb500"), Type = TextBlockType.Text, Text = "You inflict pain upon the target and revel in their anguish. This deals 1d4 mental damage and 1d4 persistent mental damage; the target must attempt a Will save. As long as the target is taking persistent damage from this spell, you gain a +1 status bonus to attack rolls and skill checks against the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("36431e8c-f59a-45dc-a926-2f491ea23f2c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ae907ce7-d8e9-45e6-878f-cf090bed9767"), Type = TextBlockType.Text, Text = "The initial damage increases by 1d4 and the persistent damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("191dc645-26f1-47cd-a6ae-b767b51fa988"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and no persistent damage.",
                Failure = "The target takes full initial and persistent damage.",
                CriticalFailure = "The target takes double initial and persistent damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Nonlethal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85273227-c939-48e5-984b-0825f9a70d14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
