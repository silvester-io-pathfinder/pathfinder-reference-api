using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JunkTinker : Template
    {
        public static readonly Guid ID = Guid.Parse("4cb2f639-18d0-4746-864c-53b6ace83ffc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Junk Tinker",
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
            yield return new TextBlock { Id = Guid.Parse("6aec8f59-ba6f-47a8-9274-47226934d648"), Type = TextBlockType.Text, Text = "You can make useful tools out of even twisted or rusted scraps. When using the Crafting skill to (action: Craft), you can make level 0 items, including weapons but not armor, out of junk. This reduces the Price to one-quarter the usual amount but always results in a shoddy item. Shoddy items normally give a penalty, but you don’t take this penalty when using shoddy items you made." };
            yield return new TextBlock { Id = Guid.Parse("fd853284-b886-4b1f-8f10-799385b42827"), Type = TextBlockType.Text, Text = "You can also incorporate junk to save money while you (action: Craft) any item. This grants you a discount on the item as if you had spent 1 additional day working to reduce the cost, but the item is obviously made of junk. At the GM’s discretion, this might affect the item’s resale value depending on the buyer’s tastes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afba5c5f-930c-4680-840d-3785cacc7ce8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
