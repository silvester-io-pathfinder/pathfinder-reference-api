using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinToTheSpot : Template
    {
        public static readonly Guid ID = Guid.Parse("3e23062d-b08a-41e7-9dfa-0d8494a7e6a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pin to the Spot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a82705a-26ae-4cc5-af82-7024bd226b89"), Type = TextBlockType.Text, Text = "You (action: Strike) a target within reach. If you hit and deal damage, the target is also restrained as if you had critically succeeded at an Athletics check to (action: Grapple)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ef8228ba-7216-414b-86bb-ba30b839aad5"), Feats.Instances.ProvocatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f3eef32-38cb-4c15-963d-d6d71d4e1a7a"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
