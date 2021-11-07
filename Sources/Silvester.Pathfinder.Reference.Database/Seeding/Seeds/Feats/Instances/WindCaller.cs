using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WindCaller : Template
    {
        public static readonly Guid ID = Guid.Parse("f6db1545-dee8-4071-bf94-8c4ee2bc7c62");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wind Caller",
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
            yield return new TextBlock { Id = Guid.Parse("22229d9a-21f7-4678-9906-57d56f4e9780"), Type = TextBlockType.Text, Text = "You bid the winds to lift and carry you through the air. You gain the (Spell: stormwind flight) order spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("8268ecd8-4661-4721-8da4-f7e518dc88b2"), DruidicOrders.Instances.Storm.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1de1b52-8506-4ed5-a887-807e61e43ce9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
