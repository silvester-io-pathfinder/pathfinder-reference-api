using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrderExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("d3d9b8c9-1f64-49af-816b-76c5ef468c40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Order Explorer",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. Each time you do, you must choose a different order other than your own.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94e2b60b-887b-4de0-b669-3570d50b075e"), Type = TextBlockType.Text, Text = "You have learned the secrets of another druidic order, passing whatever rites of initiation that order requires and gaining access to its secrets. Choose an order other than your own. You gain a 1st-level feat that lists that order as a prerequisite, and you are now a member of that order for the purpose of meeting feat prerequisites. If you commit acts anathema to your new order, you lose all feats and abilities requiring that order but retain your other druid feats and abilities. You don’t gain any of the other benefits of the order you chose." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5357154a-0946-426a-abc9-8110044f0a8e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
