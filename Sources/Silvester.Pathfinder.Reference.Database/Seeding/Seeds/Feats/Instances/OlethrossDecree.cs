using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OlethrossDecree : Template
    {
        public static readonly Guid ID = Guid.Parse("50995c11-6f61-4275-8963-c5a270b15c8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Olethros's Decree",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("77ba8fdd-42d7-4943-a950-8e2791530516"), Type = TextBlockType.Text, Text = "You have a connection to olethroses, the enigmatic psychopomps who successfully swayed the yamaraj to permit the creation of the first duskwalkers. You place a finger on fate’s scales by wrapping silk around your bow. The first time this turn that you hit a creature with a (action: Strike) using a weapon in the bow group you’ve modified in this way, that creature takes an additional 60 damage (basic Fortitude save using your class DC or spell DC, whichever is higher) as the arrow works to cut short their very destiny. This additional damage is of the same type as the initial attack dealt. If you hit more than one creature at the same time, choose one to suffer the effect of your decree." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfb9bcc4-4e6c-45ef-b279-43a9eab12801"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
