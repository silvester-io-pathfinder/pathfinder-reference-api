using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances
{
    public class AffixATalisman : Template
    {
        public static readonly Guid ID = Guid.Parse("500c5e6a-16c9-4ed6-aa7f-89375b56cfa6");

        protected override Models.Entities.Action GetAction()
        {
            return new Models.Entities.Action
            {
                Id = ID,
                Name = "Affix a Talisman",
                Requirements = "You must use a repair kit (page 291 of the Core Rulebook).",
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b17dba23-7085-48f1-96eb-70b660908dbc"), Text = "You spend 10 minutes affixing a talisman to an item, placing the item on a stable surface and using the repair kit with both hands. You can also use this activity to remove a talisman. If more than one talisman is affixed to an item, the talismans are suppressed; none of them can be activated." };
        }
    }
}
