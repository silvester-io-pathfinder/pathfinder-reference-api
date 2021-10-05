using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Dinosaur : Template
    {
        public static readonly Guid ID = Guid.Parse("d122ce52-0c97-4942-b4a0-a8d455c01883");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Dinosaur",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea2e4706-ed40-4e73-9c3e-bc882366872e"), Type = TextBlockType.Text, Text = "These reptiles have survived from prehistoric times." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b61a619f-0f12-4b84-bd06-3b0f7743a6f1"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
