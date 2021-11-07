using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpalingBriars : Template
    {
        public static readonly Guid ID = Guid.Parse("da1bc264-71b0-4c5e-83c4-4e95e00024b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impaling Briars",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31310210-34d3-4eda-a37d-71cacff207a4"), Type = TextBlockType.Text, Text = "You can fill an area with devastating briars that impale and impede your foes. You gain the (Spell: impaling briars) order spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("79cf5b20-dabc-4ddd-a998-16e2a40292d0"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6628556-d0d6-4cd0-9cc7-3733ad528979"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
