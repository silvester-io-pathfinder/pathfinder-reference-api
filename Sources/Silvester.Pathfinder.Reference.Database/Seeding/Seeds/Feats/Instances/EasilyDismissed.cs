using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EasilyDismissed : Template
    {
        public static readonly Guid ID = Guid.Parse("c91b944a-b21d-42ee-83c9-1bdd0725e78f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Easily Dismissed",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6c1e1fa-ff5c-472d-8931-d62519ac452b"), Type = TextBlockType.Text, Text = "~ Access: Chelaxian nationality" };
            yield return new TextBlock { Id = Guid.Parse("5508280f-9b9c-4d81-9840-c5d56b7ecaa8"), Type = TextBlockType.Text, Text = "You are practiced at blending into the background of the streets and halls of larger folk to ensure that you are overlooked. When you are in a crowd or well trafficked urban area, you can attempt to (action: Hide) and (action: Sneak), even when observed. On a success, you aren’t hidden or undetected, but other creatures simply don’t take particular notice of you, even though they can see you. You can’t use this ability on observers who have already seen you perform obtrusive or notable actions. If you perform any action other than to (action: Hide) or (action: Sneak) or otherwise take particularly salient actions (GM’s discretion), observers notice you right away." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e62ea742-4298-41a3-aaab-427f76daa4b2"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
