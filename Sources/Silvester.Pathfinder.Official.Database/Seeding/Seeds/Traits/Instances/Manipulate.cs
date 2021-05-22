using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Manipulate : Template
    {
        public static readonly Guid ID = Guid.Parse("d97a6bbe-6431-4306-bc54-dfcee431fc70");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Manipulate",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbbb1c76-557a-40bf-b5b3-64d57a35c90d"), Type = TextBlockType.Text, Text = "You must physically manipulate an item or make gestures to use an action with this trait. Creatures without a suitable appendage can’t perform actions with this trait. Manipulate actions often trigger reactions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d1ec74f-dd9f-412a-84fd-1e3488927af4"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
