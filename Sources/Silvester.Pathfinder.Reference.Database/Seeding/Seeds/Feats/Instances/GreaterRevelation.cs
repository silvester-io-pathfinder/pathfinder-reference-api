using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("ab1df6f9-dd38-48aa-8732-0a059aba03e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Revelation",
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
            yield return new TextBlock { Id = Guid.Parse("eb757a67-30f7-4e2d-9ca6-c0f9b7680bf8"), Type = TextBlockType.Text, Text = "You learn a greater revelation spell associated with your mystery. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae4ee6dd-a0c5-48f7-8dfd-4991190b8af6"), Feats.Instances.InitialRevelation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3568b9bc-685c-41f2-aa60-2c540f3e5a37"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
