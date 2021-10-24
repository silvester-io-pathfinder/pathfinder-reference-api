using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ranger : Template
    {
        public static readonly Guid ID = Guid.Parse("21adfb24-112a-4799-88c3-25490f102792");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ranger",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9c272fd-c5dc-4a36-ac4e-e38a5eaab21d"), Type = TextBlockType.Text, Text = "This indicates abilities from the ranger class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e729bba5-4a7c-4b3d-b9a8-79442d1f61b5"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
