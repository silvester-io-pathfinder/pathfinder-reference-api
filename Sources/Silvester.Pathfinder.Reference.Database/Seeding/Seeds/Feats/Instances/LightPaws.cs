using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LightPaws : Template
    {
        public static readonly Guid ID = Guid.Parse("2e3a1cf6-3fca-423c-90d1-b69f8f47fbae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light Paws",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac09dd31-5bff-4d15-8299-b1712a031fa0"), Type = TextBlockType.Text, Text = "You can balance on your toes to step carefully over obstructions. You (action: Stride) and then (action: Step), or (action: Step) and then (action: Stride), ignoring difficult terrain during this movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5a4469c-e2d6-4c43-8bfe-320e601ba972"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
