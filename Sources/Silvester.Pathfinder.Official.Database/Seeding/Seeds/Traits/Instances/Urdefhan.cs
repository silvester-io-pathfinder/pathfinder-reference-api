using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Urdefhan : Template
    {
        public static readonly Guid ID = Guid.Parse("9f9a9f98-1eac-44be-a524-a826155e78c0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Urdefhan",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a4acb31-ae17-4069-962b-b93d091715ce"), Type = TextBlockType.Text, Text = "Urdefhans are humanoids who have pacts with daemons, have transparent skin, and drink blood." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e3df7eb-55f0-441b-9542-9ca908cd3837"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
