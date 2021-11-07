using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForestallCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("37b04c92-2cc4-40ef-8d42-4eadf86503f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forestall Curse",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4bbd097f-ab3f-4964-9221-8c6cf8c14607"), Type = TextBlockType.Text, Text = "You’ve learned to forestall the effects of your curse somewhat. If the next action you use is to cast a (trait: revelation) spell, the severity of your curse doesn’t increase." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2412dff8-8feb-4575-8816-2815babec695"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
