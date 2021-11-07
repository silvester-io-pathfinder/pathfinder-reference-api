using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertScrollCache : Template
    {
        public static readonly Guid ID = Guid.Parse("92f8d279-18f1-4f87-a081-6ede8ecac2df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Scroll Cache",
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
            yield return new TextBlock { Id = Guid.Parse("336b56d2-ad6e-4320-83ed-7cb1596ae7f6"), Type = TextBlockType.Text, Text = "Your scroll collection is more powerful. In addition to your daily scrolls from (feat: Basic Scroll Cache), add a scroll with a 3rd-level spell. At 14th level, add a scroll with a 4th-level spell. At 16th level, add a scroll with a 5th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("846a00e2-b6d8-4451-9f63-159470eda9d8"), Feats.Instances.BasicScrollCache.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92fc47a5-8296-4e27-93d7-c9ecb8261570"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
