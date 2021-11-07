using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisturbingDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("fba818ea-2a27-4efa-87e3-f517688892ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disturbing Defense",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf52b076-fc14-47aa-8382-135b3154d5bb"), Type = TextBlockType.Text, Text = "Your internal organs and blood vessels have shifted and changed, and even you don’t know precisely where in your body they are. You gain resistance to precision damage equal to 2 + your number of class feats from the oozemorph archetype. The DC of your flat checks to recover from persistent bleed damage is 13, rather than 15." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5815656-b39a-4b22-b274-a60f142d35c9"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab6ff4a8-287c-470c-9842-ca12e632de28"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
