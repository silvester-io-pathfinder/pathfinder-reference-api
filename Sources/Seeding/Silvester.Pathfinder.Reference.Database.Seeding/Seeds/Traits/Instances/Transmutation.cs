using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Transmutation : Template
    {
        public static readonly Guid ID = Guid.Parse("ae31ec44-8633-4a5c-94f3-1f5d2ed553dd");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Transmutation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("608a4c37-012b-49bd-8dcc-450c7225a60a"), Type = TextBlockType.Text, Text = "Effects and magic items with this trait are associated with the transmutation school of magic, typically changing something’s form." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91475152-29d9-4f64-be3f-3ab6fb7a46da"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
