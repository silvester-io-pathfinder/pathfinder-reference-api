using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeafowlStrut : Template
    {
        public static readonly Guid ID = Guid.Parse("f432b1ac-080f-4ad9-a1bc-23f74ac1e64e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peafowl Strut",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cc9a474-091f-4b3e-becf-bd44e785580c"), Type = TextBlockType.Text, Text = "You slowly move across the battlefield with dangerous grace. (action: Step) twice and then (action: Strike). The (action: Strike) must be made with the sword required by (feat: Peafowl Stance)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d4055ee6-9c4b-4342-8b74-3bd534ed11d9"), Feats.Instances.PeafowlStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("248eb319-dd79-4c3b-a7fd-ff59fa01a747"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
