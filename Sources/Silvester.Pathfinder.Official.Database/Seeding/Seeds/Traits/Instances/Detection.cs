using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Detection : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("842d41fd-ad2d-4bc0-a7bf-1a58c079c298");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Detection",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2f24426-f567-4557-8339-8f7aecbaf16a"), Type = TextBlockType.Text, Text = "You must select a feat with this trait to apply an archetype to your character." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44449f01-dd7b-4b06-965d-e839f060814a"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
