using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonAim : Template
    {
        public static readonly Guid ID = Guid.Parse("2b5865c0-136a-42e4-98ae-e7ddf7c41b20");

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
            yield return new TextBlock { Id = Guid.Parse("6e5e4771-ec94-418c-915c-effba2ca370a"), Type = TextBlockType.Text, Text = "You steady your body and observe the events of the battlefield to maximize the range of your next shot. You reduce the penalty for firing into your weapon’s second range increment from –2 to 0 for the next ranged attack you make this turn. You can use this action a second time in the same turn to reduce the penalty from firing into your weapon’s third range increment from –4 to 0 for the next ranged attack you make this turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4d9e415-d6f9-40db-8ae1-579060c67f40"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
