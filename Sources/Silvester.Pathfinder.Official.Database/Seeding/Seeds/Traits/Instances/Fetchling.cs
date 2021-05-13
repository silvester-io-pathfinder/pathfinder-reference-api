using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Fetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("4ace0949-9874-4a57-afca-539a202106e2");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fetchling",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66bf89bb-9425-49a1-a0bb-904fffb62473"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the fetchling ancestry. Fetchlings were once human, but generations of life on the Shadow Plane have transformed them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6465a0b8-f542-4b8d-90b7-8e57c58f1e97"),
                SourceId = Bestiary2.ID,
                Page = 308
            };
        }
    }
}
