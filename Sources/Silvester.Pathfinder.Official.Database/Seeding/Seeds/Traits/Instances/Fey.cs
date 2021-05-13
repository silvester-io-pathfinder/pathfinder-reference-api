using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fey : Template
    {
        public static readonly Guid ID = Guid.Parse("f1ca6a72-114b-42cd-9b25-10710347eaed");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fey",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4bd73d8-7828-4a6b-8a6c-de62d217fa2f"), Type = TextBlockType.Text, Text = "Creatures of the First World are called the fey." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b77565e2-1f39-4da0-82b4-15c509844bf7"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
