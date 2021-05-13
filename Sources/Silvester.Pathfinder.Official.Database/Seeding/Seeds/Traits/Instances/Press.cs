using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Press : Template
    {
        public static readonly Guid ID = Guid.Parse("5abc1ed0-f627-42e9-bf3e-6174d39b4bdc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Press",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62e05849-bdfe-4ecf-8000-fed229fa0592"), Type = TextBlockType.Text, Text = "Actions with this trait allow you to follow up earlier attacks. An action with the press trait can be used only if you are currently affected by a multiple attack penalty. Some actions with the press trait also grant an effect on a failure. The effects that are added on a failure don’t apply on a critical failure. If your press action succeeds, you can choose to apply the failure effect instead. (For example, you may wish to do this when an attack deals no damage due to resistance.) Because a press action requires a multiple attack penalty, you can’t use one when it’s not your turn, even if you use the Ready activity." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ba747ea-d846-42b1-93db-9c4527667916"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
