using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("d9b54934-e040-43c3-9954-8323a3992234");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Domain Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6bee1e1-1d9f-41e8-a655-1e429bc7cac9"), Type = TextBlockType.Text, Text = "The intensity of your focus grows from the investment you’ve placed in your domains. If you have spent at least 3 Focus Points since the last time you (action: Refocused | Refocus), you recover 3 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("17438293-89e4-4d5e-a770-62d99c751219"), Feats.Instances.DomainFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07a5f1d7-4538-4370-b68b-6e0f08742c86"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
