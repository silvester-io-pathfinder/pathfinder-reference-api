using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrderMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("6892e65e-0c71-440b-962b-2cb48fcb0a95");

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
            yield return new TextBlock { Id = Guid.Parse("3706ecdf-9101-4a9f-a75e-65618f71536b"), Type = TextBlockType.Text, Text = "You have delved deeper into the teaching of a new order, gaining access to a coveted order spell. Choose an order you have selected with (Feat: Order Explorer). You gain the initial order spell from that order." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("26e61be3-c0bd-4ffd-992e-4e5e0fff67ae"), Feats.Instances.OrderExplorer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50a12b5f-0ab9-4539-9b68-d61c94fad731"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
