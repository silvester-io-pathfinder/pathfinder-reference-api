using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Duskwalker : Template
    {
        public static readonly Guid ID = Guid.Parse("ce1b5358-fa67-4603-b1ba-4aa7ccd6554e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Duskwalker",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d3a5431-0b84-4ce4-ad97-4ec091f2253f"), Type = TextBlockType.Text, Text = "A creature with this trait has the duskwalker versatile heritage. Duskwalkers are planar scions infused with the supernatural energy of psychopomps. An ability with this trait can be used or selected only by duskwalkers." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffe17e86-64ff-465d-98cd-6fe9c32df36f"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 267
            };
        }
    }
}
