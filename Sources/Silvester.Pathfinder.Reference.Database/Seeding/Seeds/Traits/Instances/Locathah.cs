using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Locathah : Template
    {
        public static readonly Guid ID = Guid.Parse("e3fa3f52-ba3d-419c-905b-f8f7e7945017");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Locathah",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70055b4d-ac7a-4982-ae5c-cdd1ee024165"), Type = TextBlockType.Text, Text = "Locathahs are fishlike aquatic humanoids." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d3d2ac9-24c7-4d1d-b1d0-0efe5a8348c2"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
