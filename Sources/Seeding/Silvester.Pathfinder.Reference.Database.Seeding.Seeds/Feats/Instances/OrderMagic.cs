using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrderMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("839a3109-dc91-4f2a-992a-953e25ff32f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Order Magic",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. Each time you do, you must choose a different order you have selected with Order Explorer.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc3a5bec-d9b8-4af2-ac25-d87f12e5a761"), Type = TextBlockType.Text, Text = $"You have delved deeper into the teaching of a new order, gaining access to a coveted order spell. Choose an order you have selected with {ToMarkdownLink<Models.Entities.Feat>("Order Explorer", Feats.Instances.OrderExplorer.ID)}. You gain the initial order spell from that order." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("feee5422-5b9f-4c6a-8904-fe40885d55df"), Feats.Instances.OrderExplorer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cea27b23-6845-4aa9-9a43-12705e3cdd3b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
