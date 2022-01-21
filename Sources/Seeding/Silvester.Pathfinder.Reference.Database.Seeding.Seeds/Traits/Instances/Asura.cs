using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Asura : Template
    {
        public static readonly Guid ID = Guid.Parse("7c85d47b-d7c9-4026-bfbc-a78ea28b2a3e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Asura",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5040952-c062-48a0-b397-f0400f0526e6"), Type = TextBlockType.Text, Text = "These lawful fiends are physical manifestations of divine accidents. Asuras typically have darkvision, immunity to curses, and a weakness to good." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5083a079-884d-4acf-a5ed-35242e6891ad"),
                SourceId = Bestiary3.ID,
                Page = 308
            };
        }
    }
}
