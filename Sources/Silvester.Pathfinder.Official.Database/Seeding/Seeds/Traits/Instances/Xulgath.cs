using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Xulgath : Template
    {
        public static readonly Guid ID = Guid.Parse("de02f7f2-5ae0-4011-a6de-b53cd13fa972");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Xulgath",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14d3aca8-5717-4cf5-b9c0-7c249aef86ea"), Type = TextBlockType.Text, Text = "These subterranean reptilian creatures tend to have darkvision and smell awful." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56b756ff-5af9-4915-905c-42fbd3201536"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
