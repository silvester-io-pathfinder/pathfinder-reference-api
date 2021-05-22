using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Champion : Template
    {
        public static readonly Guid ID = Guid.Parse("98a520d1-cebe-4f03-9c60-f244748b9dc7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Champion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("890491b2-93ad-4c88-a088-8f4fab3a79ad"), Type = TextBlockType.Text, Text = "This indicates abilities from the champion class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("310544b2-34ad-4e4f-abdc-97e32dcd6462"),
                SourceId = CoreRulebook.ID,
                Page = 629
            };
        }
    }
}
