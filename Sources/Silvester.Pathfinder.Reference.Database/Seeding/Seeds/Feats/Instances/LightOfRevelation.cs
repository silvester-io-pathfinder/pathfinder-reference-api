using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightOfRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("0f258c35-e7de-4fb4-8c23-ecec47e6ca0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light of Revelation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18160827-c3a1-4e0e-8679-e356f82befbe"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("6e406927-6471-42c7-9dbb-53aee6c4ea71"), Type = TextBlockType.Text, Text = "You’ve learned to call upon light to reveal what is hidden. You gain the (spell: light of revelation) devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89b486b4-8b60-4ddf-84a0-dcbac7060965"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
