using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BolerasInterrogation : Template
    {
        public static readonly Guid ID = Guid.Parse("c3826e6d-3e77-40a9-b75c-989d5a35736c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bolera's Interrogation",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "three times per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba2df9d4-fb08-4a3a-9f06-f7e536e63d9b"), Type = TextBlockType.Text, Text = "You focus your attention on a single creature within 30 feet. That creature must attempt a Will save against your Perception DC. On a failure, the creature finds itself unable to speak any deliberate and intentional lies and takes a -2 penalty to Deception checks. On a critical failure, the penalty to Deception checks is -4. This effect lasts for 10 minutes as long as you are within 30 feet of the target and the target is aware that you are using the ability against it. If you begin a new interrogation, this effect ends for any previous target. After your interrogation ends, the target is immune to this ability for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3fbae93-0069-44f3-872d-0c9ba16236ff"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca89cc7e-ea07-41cf-ad79-f23bae82db61"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
