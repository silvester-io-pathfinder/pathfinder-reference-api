using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandedSplash : Template
    {
        public static readonly Guid ID = Guid.Parse("20f225f2-3316-457f-9ebc-93ddbdd29efd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Splash",
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
            yield return new TextBlock { Id = Guid.Parse("0c5b7c7b-8101-4046-b7c3-15e6d5830dfb"), Type = TextBlockType.Text, Text = "The particularly volatile compounds that you brew into your bombs result in them creating especially large and powerful explosions. When you throw an alchemical bomb and that bomb has the (trait: splash) trait, you can add your Intelligence modifier to the bomb’s usual splash damage, and it deals splash damage to every creature within 10 feet of the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e95bb960-0608-435c-a128-68d20b4936aa"), Feats.Instances.CalculatedSplash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7ebd294-0777-48ba-88c5-61cdf4201016"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
