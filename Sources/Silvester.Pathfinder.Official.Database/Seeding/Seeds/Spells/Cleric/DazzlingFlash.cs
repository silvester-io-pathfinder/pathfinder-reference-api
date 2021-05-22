using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DazzlingFlash : Template
    {
        public static readonly Guid ID = Guid.Parse("dd619009-2808-4069-8d47-f65cafe32de7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dazzling Flash",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Sun.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f1b7a2c-71e2-46b6-8529-b03d43016e5c"), Type = TextBlockType.Text, Text = "You raise your religious symbol and create a blinding flash of light. Each creature in the area must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3b84346f-bad7-455f-8015-acdd8ef74c43"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("87bfe1e7-f0d6-4db0-bc71-be8e86024933"), Type = TextBlockType.Text, Text = "The area increases to a 30-foot cone." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("669b975b-0026-4e04-9e56-80cff29b8c54"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is blinded for 1 round and dazzled for 1 minute. The creature can spend an Interact action rubbing its eyes to end the blinded condition.",
                CriticalFailure = "The creature is blinded for 1 round and dazzled for 1 hour."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("141a3513-5053-4551-9d74-ca66c8b43f4c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
