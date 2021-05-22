using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiderClimb : Template
    {
        public static readonly Guid ID = Guid.Parse("418a14ef-ecab-4e64-bd1c-bebeb397f3c5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spider Climb",
                Level = 2,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("418a14ef-ecab-4e64-bd1c-bebeb397f3c5"), Type = TextBlockType.Text, Text = "Tiny clinging hairs sprout across the creature’s hands and feet, offering purchase on nearly any surface. The target gains a climb Speed equal to its Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("418a14ef-ecab-4e64-bd1c-bebeb397f3c5"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("418a14ef-ecab-4e64-bd1c-bebeb397f3c5"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
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
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("418a14ef-ecab-4e64-bd1c-bebeb397f3c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
