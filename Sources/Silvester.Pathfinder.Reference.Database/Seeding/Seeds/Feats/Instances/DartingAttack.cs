using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DartingAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("14ef1d6a-e68e-4cc1-84b0-98942b788af8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Darting Attack",
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
            yield return new TextBlock { Id = Guid.Parse("164e5700-c4f0-4868-974d-d7e18b0a7342"), Type = TextBlockType.Text, Text = "The raptor (action: Steps | Step) up to 10 feet and then (action: Strikes | Strike), or (action: Strikes | Strike) and then (action: Steps | Step) up to 10 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c783bef6-aee8-4024-8f99-9bfc0bfde0c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
