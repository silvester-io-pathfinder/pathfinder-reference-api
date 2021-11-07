using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Preparation : Template
    {
        public static readonly Guid ID = Guid.Parse("c4facc51-906f-4976-b00c-b6e4b9940f5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Preparation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b969f99f-4663-4d7b-ba46-54d71e3ce987"), Type = TextBlockType.Text, Text = "You survey the battlefield, calculating the possibilities. You gain one additional reaction, which you can use before the beginning of your next turn for any rogue reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f01cedf-8bb8-4c18-bca8-1ee163bb2975"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
