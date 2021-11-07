using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousCuriosityOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("9b950580-af41-4b0a-94dc-05b76b6bf2ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Curiosity - Occult",
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
            yield return new TextBlock { Id = Guid.Parse("2489e8f5-a011-4d73-b1a0-00cde5aeaed6"), Type = TextBlockType.Text, Text = "You gain (spell: misdirection) and (spell: silence) as 2nd-level occult innate spells. You can cast each spell once per day and can target only yourself." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04d6c898-efb3-49f3-b4bd-6e818edfebeb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
