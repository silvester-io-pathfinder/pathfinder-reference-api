using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fire : Template
    {
        public static readonly Guid ID = Guid.Parse("ad8d0e67-98c5-418e-82e5-03791fdee791");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fire",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39d7cbb5-262f-4487-a521-40c964c44cc0"), Type = TextBlockType.Text, Text = "Effects with the fire trait deal fire damage or either conjure or manipulate fire. Those that manipulate fire have no effect in an area without fire. Creatures with this trait consist primarily of fire or have a magical connection to that element. Planes with this trait are composed of flames that continually burn with no fuel source. Fire planes are extremely hostile to non-fire creatures." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7663be07-5948-4341-a68e-c07f47bb8b3b"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
