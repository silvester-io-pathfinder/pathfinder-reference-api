using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Injection : Template
    {
        public static readonly Guid ID = Guid.Parse("9b876c68-4ad4-48bf-b71a-e697c59c943f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Injection",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d986ccae-a3da-4a33-88c3-ae44a9a01fc7"), Type = TextBlockType.Text, Text = "This weapon can be filled with an injury poison. Immediately after a successful attack with the weapon, you can inject the target with the loaded poison with a single Interact action. Refilling the weapon with a new substance requires three Interact actions and uses both hands." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e93acb1a-c2f7-4d6e-a3a5-526c8d11b870"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 62
            };
        }
    }
}
