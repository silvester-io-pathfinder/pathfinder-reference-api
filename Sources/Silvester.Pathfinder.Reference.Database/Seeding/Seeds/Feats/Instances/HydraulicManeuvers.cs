using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HydraulicManeuvers : Template
    {
        public static readonly Guid ID = Guid.Parse("778acece-e4da-4247-b013-87fa95791b2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hydraulic Maneuvers",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("033875d1-b112-4f45-8c9a-7b7e1271418b"), Type = TextBlockType.Text, Text = "You batter your foes with a torrent of water siphoned from your surroundings. If the next action you take is an Athletics check to (action: Disarm), (action: Shove), or (action: Trip), that action has a range of 15 feet. You don’t receive any item bonuses to that check or any circumstance bonuses related to your physical body, but if you roll a critical failure on that Athletics check, you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77ee0110-988d-4129-a72e-10c4af1e5573"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
