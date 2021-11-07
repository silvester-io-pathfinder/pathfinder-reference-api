using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("a98e90cb-80ae-4a00-89c8-887b602416ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c66ba494-b027-4711-b621-342355393633"), Type = TextBlockType.Text, Text = "Your connection with your surroundings grows deeper as you focus. If you have spent at least 2 Focus Points since the last time you (activity: Refocused | Refocus), you recover 2 Focus Points when you (activity: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("a87899c2-f266-4ba9-9a52-8d1ab2a213cc"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38ee7025-23a5-497d-8b96-eb1961f9de73"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
