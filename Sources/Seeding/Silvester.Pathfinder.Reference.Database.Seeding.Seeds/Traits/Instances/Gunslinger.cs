using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Gunslinger : Template
    {
        public static readonly Guid ID = Guid.Parse("8cdafad3-9934-4e74-a9bb-b4de2a433e46");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Gunslinger",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42c6d675-ade2-460b-9649-b5745f431f5f"), Type = TextBlockType.Text, Text = "This indicates abilities from the gunslinger class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c5a142a-a5a9-463b-841b-04da083fdd3b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 233
            };
        }
    }
}
