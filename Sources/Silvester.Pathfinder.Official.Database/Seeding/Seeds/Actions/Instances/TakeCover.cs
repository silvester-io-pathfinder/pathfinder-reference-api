using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ActionTypes.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class TakeCover : Template
    {
        public static readonly Guid ID = Guid.Parse("55bca308-af52-4da5-a1e4-a6c1059c5321");

        protected override Models.Action GetAction()
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Take Cover",
                Requirements = "You are benefiting from cover, are near a feature that allows you to take cover, or are prone.",
                ActionTypeId = OneAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3fb46634-1f05-49e3-afbc-4cc2c1553980"), Text = "You press yourself against a wall or duck behind an obstacle to take better advantage of cover (page 477). If you would have standard cover, you instead gain greater cover, which provides a +4 circumstance bonus to AC; to Reflex saves against area effects; and to Stealth checks to Hide, Sneak, or otherwise avoid detection. Otherwise, you gain the benefits of standard cover (a +2 circumstance bonus instead). This lasts until you move from your current space, use an attack action, become unconscious, or end this effect as a free action." };
        }
    }
}
