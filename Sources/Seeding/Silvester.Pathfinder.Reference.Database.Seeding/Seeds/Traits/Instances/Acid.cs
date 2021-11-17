using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Acid : Template
    {
        public static readonly Guid ID = Guid.Parse("ef7d80ee-a7a0-417f-ba66-748ba26ec489");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Acid",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2e3125f-23f6-45a7-ab20-62334e8a549c"), Type = TextBlockType.Text, Text = "Effects with this trait deal acid damage. Creatures with this trait have a magical connection to acid." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1a0f863-1753-41c8-bb02-524069c2c916"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
