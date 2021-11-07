using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecycledCogwheels : Template
    {
        public static readonly Guid ID = Guid.Parse("f7987552-6a29-4d35-9093-2dbaa9d49913");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recycled Cogwheels",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("74d55f77-f69d-45bd-866b-3743ee4afa3f"), Type = TextBlockType.Text, Text = "You’re able to scavenge the cogwheels from your daily quick-deploy snares that use gears. This allows you to deconstruct a snare that didn’t trigger in order to set the snare up somewhere else. Doing so takes the same number of actions as setting the snare did. When you do, you recover the snare and can deploy it in another location." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0913ea71-8071-4e23-8a10-19403a464bf5"), Feats.Instances.TrapsmithDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("186daf6f-8620-4dc5-bfb4-54abe4bd86f3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
