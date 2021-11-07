using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TumblingOpportunist : Template
    {
        public static readonly Guid ID = Guid.Parse("e6788d72-9283-4b92-8844-8a69c3c5628a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tumbling Opportunist",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8d0eab9-30fd-4f69-bf69-042771483c03"), Type = TextBlockType.Text, Text = "You use a burst of stamina to perform a breathtaking feat of Acrobatics as you speed through a foe’s space, leaving your foe lying flat on their back. You attempt to (action: Trip) the enemy whose space you moved through. You can use Acrobatics instead of Athletics for this check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f91005b0-f127-4327-a1e5-026d17f5093d"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c12b8b5c-b1aa-41c9-bda8-dde311731d09"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
