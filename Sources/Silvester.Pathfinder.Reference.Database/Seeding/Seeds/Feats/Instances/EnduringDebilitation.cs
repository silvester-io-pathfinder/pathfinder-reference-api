using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduringDebilitation : Template
    {
        public static readonly Guid ID = Guid.Parse("6e2df6d1-105b-4d7d-8a80-0f1f629fb548");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enduring Debilitation",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You apply a debilitation to a creature.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2c5054a-d5cc-41a1-b55f-f1e1d385cf7f"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("3de95f65-80a5-4767-abd3-05f92307e981"), Type = TextBlockType.Text, Text = "You can make your debilitation last an exceptionally long time. The triggering debilitation lasts for 1 minute instead of until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8fde9d5c-5ddf-4bc4-a80d-b52f13d7bafa"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7f910e7-09dc-4ef8-98de-785a89b77587"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
