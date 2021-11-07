using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptingStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("8f601bbb-9c25-430a-bd77-18cc08b49030");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disrupting Strikes",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb7e865d-75db-4bdb-aab8-4b3931f94c18"), Type = TextBlockType.Text, Text = "You call forth positive energy from within to help you destroy undead. Your weapon and unarmed (action: Strikes | Strike) gain the effects of a (item: disrupting property rune | Disrupting Runestone) until the start of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("a04de584-2cd3-4dc1-ac75-9aed3a356003"), Type = TextBlockType.Text, Text = "If you&#39;re 14th level or higher, your (action: Strikes | Strike) instead gain the effects of a (item: greater disrupting property rune | Greater Disrupting Runestone). The DC for the rune&#39;s effect is equal to your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63110217-7c00-4a3f-bf1b-9e7929d5b409"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
