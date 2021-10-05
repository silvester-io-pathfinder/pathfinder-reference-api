using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiderClimb : Template
    {
        public static readonly Guid ID = Guid.Parse("378e003f-daf7-4083-aff0-fa89ce625e8d");

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
            yield return new TextBlock { Id = Guid.Parse("a4674f5b-95ac-4a64-b387-bdb201883e97"), Type = TextBlockType.Text, Text = "Tiny clinging hairs sprout across the creature’s hands and feet, offering purchase on nearly any surface. The target gains a climb Speed equal to its Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("53eac60c-84c3-4cfe-a8ab-c39c4e50d39c"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("05d5ebe3-cd25-4267-9e8c-316317a0788e"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
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
                Id = Guid.Parse("ae95cefb-c589-40a2-bc5c-150ebe59bba7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
