using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DebilitatingDichotomy : Template
    {
        public static readonly Guid ID = Guid.Parse("7b43164e-9de7-4c7d-b133-6eb08c0c234c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Dichotomy",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("851acfb9-e161-493a-9612-f506471397f1"), Type = TextBlockType.Text, Text = "You can give others a glimpse of the impossible conflicts and unchecked power that courses through your body. You learn the (spell: debilitating dichotomy) revelation spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("943f1390-9fd9-42f4-9802-556e51cb48b4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
