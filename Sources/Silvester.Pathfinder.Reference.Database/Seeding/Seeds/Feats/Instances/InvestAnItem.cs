using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvestAnItem : Template
    {
        public static readonly Guid ID = Guid.Parse("a4af853c-f2fc-4e3c-9f28-93a26bfe6a5a");

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
            yield return new TextBlock { Id = Guid.Parse("2c851a87-5053-444f-943c-64985d1f0375"), Type = TextBlockType.Text, Text = "You invest your energy in an item with the (trait: invested) trait as you don it. This process requires 1 or more (action: Interact) actions, usually taking the same amount of time it takes to don the item. Once you’ve Invested the Item, you benefit from its constant magical abilities as long as you meet its other requirements (for most invested items, the only other requirement is that you must be wearing the item). This investiture lasts until you remove the item." };
            yield return new TextBlock { Id = Guid.Parse("358130a0-0dbc-4196-9452-b1ce7b2b568c"), Type = TextBlockType.Text, Text = "You can invest no more than 10 items per day. If you remove an invested item, it loses its investiture. The item still counts against your daily limit after it loses its investiture. You reset the limit during your daily preparations, at which point you Invest your Items anew. If you’re still wearing items you had invested the previous day, you can typically keep them invested on the new day, but they still count against your limit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("088fa2d1-615b-486c-89c6-8fbc7e75ebc4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
