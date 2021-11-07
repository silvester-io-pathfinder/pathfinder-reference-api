using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("7f04e7b7-33cd-46c7-9090-c82ae36ce249");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("612e6ca9-0ecb-4de6-91df-0946e7ee2c9a"), Type = TextBlockType.Text, Text = "Your connection to nature is particularly strong, and the spirits of nature flock around you, helping you replenish your focus. If you have spent at least 2 Focus Points since the last time you (Activity: Refocused | Refocus), you recover 2 Focus Points when you (Activity: Refocus) instead of 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("881bd756-ab92-4042-af60-0f4012da444d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
