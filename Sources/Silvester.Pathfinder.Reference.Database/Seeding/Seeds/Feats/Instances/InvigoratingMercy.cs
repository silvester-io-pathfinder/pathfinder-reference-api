using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvigoratingMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("c4c1e2eb-9289-4bfc-a23b-d52fc722d686");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invigorating Mercy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddf243b2-149a-4377-a40f-f78dd447fb1a"), Type = TextBlockType.Text, Text = "Your divine touch rejuvenates the weak and tired. When you use (feat: Mercy), you can instead attempt a counteract check to remove the clumsy or enfeebled conditions, using the source of that condition to determine the counteract level and DC. If the condition was caused by an ongoing effect and you don’t remove that effect, the condition returns at the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("72f86bb9-2163-44aa-bd79-5967f97f38e9"), Feats.Instances.mercy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d869e3fb-4df9-4a93-b871-77cadbe96cf2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
