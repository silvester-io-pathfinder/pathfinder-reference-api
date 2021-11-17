using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Dream : Template
    {
        public static readonly Guid ID = Guid.Parse("d8988a11-861b-4372-966e-7b8dd2fbe487");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dream",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c577192e-6ed8-4a0d-8c8f-d46459d18fee"), Type = TextBlockType.Text, Text = "Creatures native to the Dimension of Dreams can be any alignment and possess a diverse array of abilities, although those associated with the nightmare realm of Leng are almost always evil and immune to that realm’s freezing temperatures." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df7e2e06-098a-4c97-9b98-a375723edda7"),
                SourceId = Bestiary2.ID,
                Page = 308
            };
        }
    }
}
