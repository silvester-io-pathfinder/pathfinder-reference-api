using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Leshy : Template
    {
        public static readonly Guid ID = Guid.Parse("aa8a4365-a565-4dbf-8b0d-c3bd8cd7d719");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Leshy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a65e3f07-c42f-4fdd-9fb0-5b2ff3295ca2"), Type = TextBlockType.Text, Text = "Leshies are living plants animated by primal magic." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b419330d-5971-4874-aecb-55bc8ace7864"),
                SourceId = CharacterGuide.ID,
                Page = 63133
            };
        }
    }
}
