using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Gnome : Template
    {
        public static readonly Guid ID = Guid.Parse("e108b7ec-3756-4e04-a806-62f55611379c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Gnome",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61d64090-54d0-4076-9739-d36f25a9e92c"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the gnome ancestry. Gnomes are small people skilled at magic who seek out new experiences and usually have low-light vision. An ability with this trait can be used or selected only by gnomes. A weapon with this trait is created and used by gnomes." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dc7d9a8-6646-4549-9960-37022879d210"),
                SourceId = CoreRulebook.ID,
                Page = 632
            };
        }
    }
}
