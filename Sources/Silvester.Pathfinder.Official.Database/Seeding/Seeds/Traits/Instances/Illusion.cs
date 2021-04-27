using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Illusion : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("4ec8b734-6099-4b0e-97cc-2bf987a8bcbe");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Illusion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a2ba241-31d3-4743-819e-055b39f8a15b"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the illusion school of magic, typically involving false sensory stimuli." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38c8bc39-a22b-44a5-b019-07061be34c84"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
