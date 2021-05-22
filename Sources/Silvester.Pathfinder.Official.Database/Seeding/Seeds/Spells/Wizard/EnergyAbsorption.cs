using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EnergyAbsorption : Template
    {
        public static readonly Guid ID = Guid.Parse("a3f7cab4-d2e1-4a4b-9220-0194e0dc7d3c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Energy Absorption",
                Level = 4,
                Trigger = "An effect would deal acid, cold, electricity, or fire damage to you.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3f7cab4-d2e1-4a4b-9220-0194e0dc7d3c"), Type = TextBlockType.Text, Text = "You gain resistance 15 to acid, cold, electricity, or fire damage from the triggering effect (one type of your choice). The resistance applies only to the triggering effect’s initial damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a3f7cab4-d2e1-4a4b-9220-0194e0dc7d3c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a3f7cab4-d2e1-4a4b-9220-0194e0dc7d3c"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3f7cab4-d2e1-4a4b-9220-0194e0dc7d3c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
