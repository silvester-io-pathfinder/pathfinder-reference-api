using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Bullseye : Template
    {
        public static readonly Guid ID = Guid.Parse("a10dc255-f21f-430b-ab0e-1b5cf1854794");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullseye",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7f86640-c5e2-47ec-9983-7ddf45151fd5"), Type = TextBlockType.Text, Text = "You carefully take aim before making your attack in order to avoid your foe’s concealment and cover. On your next Strike with a (trait: thrown) weapon before the end of your turn, you gain a +1 circumstance bonus to your attack roll and ignore your target’s concealed condition, as well as the target’s lesser cover or standard cover; if the target had greater cover, they instead have only standard cover against the Strike." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd17fc41-9f6f-4f60-915f-0f392eaeca95"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
