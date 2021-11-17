using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Fungus : Template
    {
        public static readonly Guid ID = Guid.Parse("0c938c14-65bc-4847-9da2-e88318f39994");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fungus",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a88a8a71-8b22-47ff-a96f-e7ced5b79453"), Type = TextBlockType.Text, Text = "Fungal creatures have the fungus trait. They are distinct from normal fungi." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cde2d86-62ec-4385-a09c-3c032ede1191"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
