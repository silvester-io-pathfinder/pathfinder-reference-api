using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Implosion : Template
    {
        public static readonly Guid ID = Guid.Parse("4d827030-0f40-496b-a73f-4477ed978bce");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Implosion",
                Level = 9,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "1 corporeal creature.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5e934a2-7bf8-47fc-a081-1af1a6d28808"), Type = TextBlockType.Text, Text = "You crush the target by causing it to collapse in on itself, dealing 75 damage. The first time each round you Sustain the Spell, you must choose a new target to be subject to the same effect; the same creature can never be targeted more than once with a single casting of this spell. You also can't affect more than one creature per turn with implosion. You can't target a creature that's incorporeal, gaseous, or liquid, or otherwise lacking a solid form." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("af3c4630-79b1-427e-afbb-37f4cf342a52"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("04622cfb-62de-4cee-a784-a8272c354e01"), Type = TextBlockType.Text, Text = "The damage increases by 10." }
                }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abd4d451-da5a-463a-b364-6fa6d3e2cb6e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 346
            };
        }
    }
}
