using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Paaridar : Template
    {
        public static readonly Guid ID = Guid.Parse("2ec9f6dc-0fb0-4092-a0ac-345a05c5080f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Paaridar",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff3e56dc-b849-4043-ad71-8569db7cf219"), Type = TextBlockType.Text, Text = "A paaridar is a humanoid who has gained physical aspects and abilities of a powerful beast through corrupted magical rituals." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d88cd3c-a8a3-4af7-9aab-b97baa1cd59c"),
                SourceId = Bestiary3.ID,
                Page = 63309
            };
        }
    }
}
