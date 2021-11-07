using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonAim : Template
    {
        public static readonly Guid ID = Guid.Parse("9c65e32c-68ae-4c50-b887-0087c0c708b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Aim",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d983e546-38b6-4ed4-bb1e-0a5fd0c9be19"), Type = TextBlockType.Text, Text = "You steady your body and observe the events of the battlefield to maximize the range of your next shot. You reduce the penalty for firing into your weapon’s second range increment from –2 to 0 for the next ranged attack you make this turn. You can use this action a second time in the same turn to reduce the penalty from firing into your weapon’s third range increment from –4 to 0 for the next ranged attack you make this turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3da08a3-8e94-4d29-8d60-e3fe9debe297"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
