using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightFromDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("d0c85567-0ae0-46a1-86ab-d9c6bfc90621");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light from Darkness",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0463016-20e4-46c4-b740-69b67bf6acfa"), Type = TextBlockType.Text, Text = "You&#39;ve battled the fiendish power within your nature and come out on top; whatever you decide to do with your life, for good or evil, will be your choice and your choice alone. This struggle has granted you powerful resistance against the divine. You gain a +1 circumstance bonus to all saving throws against (trait: divine) effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50202475-0ad1-44d8-9249-ff006c12b679"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
