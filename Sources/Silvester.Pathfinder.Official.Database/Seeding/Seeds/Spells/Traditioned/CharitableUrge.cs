using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CharitableUrge : Template
    {
        public static readonly Guid ID = Guid.Parse("55c19e3c-6035-49cd-adf7-4de4f6a72961");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Charitable Urge",
                Level = 2,
                Range = "30 feet.",
                Duration = "Varies.",
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
            yield return new TextBlock { Id = Guid.Parse("0a297eef-c502-4394-b44a-0e9c0596795d"), Type = TextBlockType.Text, Text = "You speak on the virtue of charity, compelling the target to give away its possessions. The target must attempt a Will save. If the target has no items on its person, the spell fails." };
        }
        
        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("078d384d-d0b9-4622-bd2e-80b7c4f3498b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stunned 1 as it wrestles with the urge.",
                Failure = "On its next turn, before it does anything else, the target must present the nearest creature with an item in its possession; the target chooses which item to give, and if the only item it has is one that it's currently using to defend itself, such as a weapon during a combat encounter, it can choose to be stunned for 1 round instead of giving up the item. This might require the target to Interact to retrieve an item or move to reach the nearest creature, and handing the item to the target always requires an Interact action.",
                CriticalFailure = "As failure, except the duration is 4 rounds, and the target must repeat the effects of failure on each of its turns. At the end of each of its turns, the target can attempt a new Will save to reduce the remaining duration by 1 round, ending it entirely on a critical success."
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2eef21fb-6b03-4b4c-bb7d-23e03a58044b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}
