using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragDown : Template
    {
        public static readonly Guid ID = Guid.Parse("97ab4be1-1d8e-4e4a-bde4-5888de1b65e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drag Down",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a4ee154-20f2-4c0e-a0e3-467a03c6ddf1"), Type = TextBlockType.Text, Text = "While swimming in water at least 10 feet deep, you grab an adjacent creature (on nearby land or in the water) and pull it below the surface. Attempt an Athletics check to (action: Grapple) the creature. On a success, if the creature is on land, in addition to the normal effects of (action: Grapple), you pull the creature into the water in a space adjacent to you. If the creature is already in the water, on a success, in addition the normal effects of (action: Grapple), you drag the creature 10 feet deeper into the water, moving 10 feet with the creature. Moving a creature into water or deeper into water using Drag Down is forced movement for the creature but not for you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6516efcb-28cc-4b2b-97fc-03342119e3f2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
