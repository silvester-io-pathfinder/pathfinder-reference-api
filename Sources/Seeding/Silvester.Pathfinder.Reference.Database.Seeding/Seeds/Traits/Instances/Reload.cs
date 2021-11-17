using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Reload : Template
    {
        public static readonly Guid ID = Guid.Parse("a6fb51b7-6e8c-406a-b9d3-66049faef2da");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Reload",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c61771e0-154e-4b20-926e-dd943f1bbb3e"), Type = TextBlockType.Text, Text = "While all weapons need some amount of time to get into position, many ranged weapons also need to be loaded and reloaded. This entry indicates how many Interact actions it takes to reload such weapons. This can be 0 if drawing ammunition and firing the weapon are part of the same action. If an item takes 2 or more actions to reload, the GM determines whether they must be performed together as an activity, or you can spend some of those actions during one turn and the rest during your next turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffb0ab73-c88a-4078-a51c-6b8346675f93"),
                SourceId = CoreRulebook.ID,
                Page = 279
            };
        }
    }
}
