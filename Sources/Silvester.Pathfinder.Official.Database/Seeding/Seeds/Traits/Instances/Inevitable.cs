using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Inevitable : Template
    {
        public static readonly Guid ID = Guid.Parse("08f9e964-7481-4c26-85bf-424b823bbb58");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Inevitable",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8eb70672-1557-43fe-8f5f-dfe9e8af03b9"), Type = TextBlockType.Text, Text = "These constructed aeons were created by the axiomites. Each type of inevitable is dedicated to a specific task. Most inevitables have weakness to chaotic damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7469a3f-8d6b-41c9-aec6-ba36a67fa302"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
