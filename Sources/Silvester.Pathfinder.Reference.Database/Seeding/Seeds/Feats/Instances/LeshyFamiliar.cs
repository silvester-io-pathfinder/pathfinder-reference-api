using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("91f95e29-9568-4363-a999-fcca6d72c24b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leshy Familiar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad6e407d-6dbc-415c-b3d1-e1f8f13d01d1"), Type = TextBlockType.Text, Text = "You gain a leshy familiar, a Tiny plant that embodies one of the many spirits of nature. Other than taking the form of a plant instead of an animal, this familiar uses all the same rules as other familiars, which are detailed on page 217." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("3d621cb6-079b-4516-bdc5-c9e2d6a5a259"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("047743c0-75f6-4d02-a87f-68c595c8261a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
