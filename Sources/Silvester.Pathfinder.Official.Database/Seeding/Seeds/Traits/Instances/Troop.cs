using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Troop : Template
    {
        public static readonly Guid ID = Guid.Parse("b18a1fb5-b904-4372-9fb4-dab6d6cf7b2c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Troop",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa113a36-5531-44db-9ade-fdbb28ddaaa4"), Type = TextBlockType.Text, Text = "A troop is an organized collection of component creatures, typically Small or Medium in size, working as a cohesive whole. A troop is 16 squares in size and has two Hit Point thresholds in their HP entry, under which it reduces in size to 12 squares and then 8 squares. A troop has the Troop Defenses, Form Up, and Troop Movement abilities. Most troops have a weakness to area damage. Because they consist of multiple discrete creatures, they can't be summoned." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fbcc87c-8716-4cfe-b9dc-ce47fa327b7f"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
