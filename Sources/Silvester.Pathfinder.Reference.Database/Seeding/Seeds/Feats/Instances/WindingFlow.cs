using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WindingFlow : Template
    {
        public static readonly Guid ID = Guid.Parse("6274ab85-aa81-4387-8d03-cb8dda1be57f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Winding Flow",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61263d73-415b-4142-9aac-4add5b920ed9"), Type = TextBlockType.Text, Text = "Any journey consists of more than simply reaching your destination. You use two of the following actions in any order: (action: Stand | Stand / Drop Prone), (action: Step), and (action: Stride). You can’t use the same action twice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd91539c-1b6d-4eac-85c7-7a217f080601"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
