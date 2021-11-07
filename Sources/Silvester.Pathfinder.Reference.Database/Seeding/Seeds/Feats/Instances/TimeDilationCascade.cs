using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TimeDilationCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("4a9bc05a-60d9-4263-8745-2160cef7b585");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Time Dilation Cascade",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a29da2f6-0f6d-4dbe-be56-f5fbbb0b29e0"), Type = TextBlockType.Text, Text = "You borrow a bit of time from the future to act now. Make six (action: Strikes | Strike). Your multiple attack penalty applies normally to these (action: Strikes | Strike). If you successfully hit a creature with multiple (action: Strikes | Strike), combine those (action: Strikes&#39; | Strike) damage for the purpose of resistances and weaknesses. On your next turn, you regain 1 action instead of 3. This is before any alteration in your actions due to the quickened, slowed, and stunned conditions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e416e37e-4911-43aa-99d5-00ce94840986"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
