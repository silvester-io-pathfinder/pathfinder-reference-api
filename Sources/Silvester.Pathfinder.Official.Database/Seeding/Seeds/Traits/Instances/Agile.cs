using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Agile : Template
    {
        public static readonly Guid ID = Guid.Parse("34f43b53-1639-4e15-ae03-9cec0ff0fa30");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Agile",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddd69f04-a78a-4f36-85af-2af36cda7862"), Type = TextBlockType.Text, Text = "The multiple attack penalty you take with this weapon on the second attack on your turn is –4 instead of –5, and –8 instead of –10 on the third and subsequent attacks in the turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd057720-dc09-4bac-8393-98875b52d2cd"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
