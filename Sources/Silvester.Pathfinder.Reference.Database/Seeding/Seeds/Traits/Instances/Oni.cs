using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Oni : Template
    {
        public static readonly Guid ID = Guid.Parse("76792b26-bda8-46cc-ba9f-8e8cdbf4871f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Oni",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("523b074e-c81b-46dc-af85-979b3ae1c968"), Type = TextBlockType.Text, Text = "Oni are a family of fiends who dwell on the Material Plane and take monstrous forms based on humanoid shapes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24a534e7-1af3-4cd9-96e9-c7c5fba6ce79"),
                SourceId = Bestiary2.ID,
                Page = 309
            };
        }
    }
}
