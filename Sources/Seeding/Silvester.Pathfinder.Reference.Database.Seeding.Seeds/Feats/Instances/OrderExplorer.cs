using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrderExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("6aa73a62-55d5-4034-a73c-53ef07b57f7f");

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
            yield return new TextBlock { Id = Guid.Parse("afaaa27f-3239-4dc4-b85e-6cb334fcf1c7"), Type = TextBlockType.Text, Text = $"You have learned the secrets of another druidic order, passing whatever rites of initiation that order requires and gaining access to its secrets. Choose an order other than your own. You gain a 1st-level feat that lists that order as a prerequisite, and you are now a member of that order for the purpose of meeting feat prerequisites. If you commit acts anathema to your new order, you lose all feats and abilities requiring that order but retain your other druid feats and abilities. You don't gain any of the other benefits of the order you chose." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a87f155-f69d-4e5c-9191-adf0ca87b4ea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
