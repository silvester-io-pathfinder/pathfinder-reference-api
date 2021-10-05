using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Conrasu : Template
    {
        public static readonly Guid ID = Guid.Parse("63fa3f81-de0b-4c73-9d92-906df1990dfd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Conrasu",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4adde5bd-4cf4-42ee-88d9-9777e24ccc1e"), Type = TextBlockType.Text, Text = "There was not explicit description for this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f4b728f-1392-491f-a0ec-5236fd12ec72"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
