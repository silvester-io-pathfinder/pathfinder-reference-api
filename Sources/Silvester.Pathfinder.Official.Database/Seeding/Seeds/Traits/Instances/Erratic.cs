using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Erratic : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("7df265ef-e15c-4e11-80bd-e87208758c2e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Erratic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e15ee200-d33a-4157-b8f8-d9412df63f2b"), Type = TextBlockType.Text, Text = "Planes with this trait have a flow of time that slows down or speeds up relative to other planes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d492657d-e8c2-42ce-9acf-22e1217ddaf6"),
                SourceId = GamemasteryGuide.ID,
                Page = 251
            };
        }
    }
}
