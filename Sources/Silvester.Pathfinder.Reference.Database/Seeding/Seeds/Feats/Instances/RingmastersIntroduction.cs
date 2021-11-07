using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RingmastersIntroduction : Template
    {
        public static readonly Guid ID = Guid.Parse("795afd8b-219d-4c80-883f-8acca0b92c32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ringmaster's Introduction",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally's turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a919c957-4749-4ff8-9c87-950228fc6790"), Type = TextBlockType.Text, Text = "You announce the triggering ally with a litany of their legendary achievements, spurring them to action. The target is quickened this turn and can spend the extra action to (action: Stride), (action: Strike), (action: Demoralize), (action: Feint), or (action: Perform)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2a5aa7e-da59-4f65-9df6-1b3673677c48"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
