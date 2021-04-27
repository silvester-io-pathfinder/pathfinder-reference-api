using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Boggard : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("c397e8a4-ed21-4ece-be24-ed76c3aad67e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Boggard",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f262099-497f-4214-a163-8c863d9171f9"), Type = TextBlockType.Text, Text = "Boggards are frog-like humanoids. They typically have darkvision." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e01f5704-1664-420a-830c-71a7fd965cdb"),
                SourceId = Bestiary.ID,
                Page = 345
            };
        }
    }
}
