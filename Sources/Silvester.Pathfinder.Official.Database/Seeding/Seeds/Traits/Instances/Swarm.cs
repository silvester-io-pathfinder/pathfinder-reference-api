using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Swarm : Template
    {
        public static readonly Guid ID = Guid.Parse("b605c666-d324-449b-8574-709d3c066dd2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Swarm",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e504a84-c4af-4fd3-aacb-2d29b8b3085d"), Type = TextBlockType.Text, Text = "A swarm is a mass or cloud of creatures that functions as one monster. Its size entry gives the size of the entire mass, though for most swarms the individual creatures that make up that mass are Tiny. A swarm can occupy the same space as other creatures, and must do so in order to use its damaging action. A swarm typically has weakness to effects that deal damage over an area (like area spells and splash weapons). Swarms are immune to the grappled, prone, and restrained conditions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76af42e0-125d-43bd-a4b6-19c4aa93becc"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
