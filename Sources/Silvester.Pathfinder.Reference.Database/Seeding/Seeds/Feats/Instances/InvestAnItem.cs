using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestAnItem : Template
    {
        public static readonly Guid ID = Guid.Parse("c6fb6e59-482c-4b9a-95c3-d28deffc5efa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invest an Item",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed5a0cb3-4687-451a-ba93-2c2094a42bcd"), Type = TextBlockType.Text, Text = "You invest your energy in an item with the (trait: invested) trait as you don it. This process requires 1 or more (action: Interact) actions, usually taking the same amount of time it takes to don the item. Once you’ve Invested the Item, you benefit from its constant magical abilities as long as you meet its other requirements (for most invested items, the only other requirement is that you must be wearing the item). This investiture lasts until you remove the item." };
            yield return new TextBlock { Id = Guid.Parse("9d4c57db-dc22-4e91-849a-f9f64e0adb1d"), Type = TextBlockType.Text, Text = "You can invest no more than 10 items per day. If you remove an invested item, it loses its investiture. The item still counts against your daily limit after it loses its investiture. You reset the limit during your daily preparations, at which point you Invest your Items anew. If you’re still wearing items you had invested the previous day, you can typically keep them invested on the new day, but they still count against your limit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc7b7b95-925a-4382-b480-996f7f315d14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
