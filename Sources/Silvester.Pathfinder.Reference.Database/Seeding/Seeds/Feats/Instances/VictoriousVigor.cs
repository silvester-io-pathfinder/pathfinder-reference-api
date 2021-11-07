using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VictoriousVigor : Template
    {
        public static readonly Guid ID = Guid.Parse("c7f950e9-859c-485c-b738-ee69f5df885c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Victorious Vigor",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You bring a foe to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45ccc312-4c2f-4416-962b-c3600a4e9cef"), Type = TextBlockType.Text, Text = "Your victories in battle fill you with pride and imbue you with the energy to fight a bit longer despite your wounds. You gain temporary Hit Points equal to your Constitution modifier until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0793e75-d0ca-4d36-94a5-54e391d860cd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
