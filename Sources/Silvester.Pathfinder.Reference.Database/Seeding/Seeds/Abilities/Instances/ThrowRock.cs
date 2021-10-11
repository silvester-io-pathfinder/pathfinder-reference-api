using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ThrowRock : Template
    {
        public static readonly Guid ID = Guid.Parse("67235228-3e7f-4825-b7ac-fd4c5a291777");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Throw Rock",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("0d606118-9c86-4887-be25-7d0e7f20eb94"), Text = "The monster picks up a rock within reach or retrieves a stowed rock and throws it, making a ranged Strike." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("938e0c6a-537e-4503-b3d3-5b5ba81522e3"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
