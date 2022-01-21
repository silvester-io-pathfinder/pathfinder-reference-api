using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForestallCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("3b014af5-ff78-432a-8998-c8bdaa95f097");

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
            yield return new TextBlock { Id = Guid.Parse("f48a0955-d19d-4a37-a185-00f1788fbb2f"), Type = TextBlockType.Text, Text = "You've learned to forestall the effects of your curse somewhat. If the next action you use is to cast a (trait: revelation) spell, the severity of your curse doesn't increase." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a36ab309-f555-4647-807b-737c19e0e115"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
