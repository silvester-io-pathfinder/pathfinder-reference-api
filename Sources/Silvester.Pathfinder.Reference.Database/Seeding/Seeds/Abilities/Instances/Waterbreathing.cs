using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Waterbreathing : Template
    {
        public static readonly Guid ID = Guid.Parse("9238dff4-8e76-4246-8a41-6c4d97232919");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Waterbreathing",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("6a2ea2ff-ff03-4468-b1b6-12e38979add4"), Text = "You have the ability to breathe underwater." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f705c055-20e8-4db6-b5d3-8fd9f0ec25bf"),
                SourceId = Sources.Instances.Custom.ID
            };
        }
    }
}
