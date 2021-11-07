using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnhamperedPassage : Template
    {
        public static readonly Guid ID = Guid.Parse("eff04223-4728-4805-bfbf-01673c5d8bfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unhampered Passage",
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
            yield return new TextBlock { Id = Guid.Parse("df1c63ae-097e-4e0b-b591-69a8b225abec"), Type = TextBlockType.Text, Text = "You won’t allow others to restrain you. You can cast (spell: freedom of movement) on yourself as a primal innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9429f1b-49b9-479f-9d18-62347e8c4340"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
