using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Contact : Template
    {
        public static readonly Guid ID = Guid.Parse("a035e945-b6b9-4247-b640-6bd58b25f74a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Contact",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d3462c9-ee8a-4e48-935d-db489e23ed93"), Type = TextBlockType.Text, Text = "This poison is delivered by contact with the skin." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b2410af-456f-49cc-bd8e-12fdff799d80"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
