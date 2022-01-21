using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Steam : Template
    {
        public static readonly Guid ID = Guid.Parse("0035194b-14c8-43dc-9f71-e24c90ab9035");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Steam",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c001b02c-031a-47df-98c1-7dff25a724b2"), Type = TextBlockType.Text, Text = "Items with this trait are powered by engines that boil water to produce steam and move their components." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9975e2cc-4498-4c52-914e-3b0f72d4c887"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 236
            };
        }
    }
}
