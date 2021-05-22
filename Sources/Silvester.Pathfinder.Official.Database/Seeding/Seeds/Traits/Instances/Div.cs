using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Div : Template
    {
        public static readonly Guid ID = Guid.Parse("3ce200fc-375b-419d-a783-c3b8f6cc2034");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Div",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aec18129-85d1-487e-bb3b-dcb36ae1876c"), Type = TextBlockType.Text, Text = "Divs are a family of fiends spawned from the spirits of evil genies within the desolation of Abaddon. Most divs are neutral evil. They typically have greater darkvision and weakness to cold iron and good damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("580b2b34-19ec-4d7e-a62b-13b7c39f0336"),
                SourceId = Bestiary3.ID,
                Page = 308
            };
        }
    }
}
