using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FleetTempo : Template
    {
        public static readonly Guid ID = Guid.Parse("2d92658d-e145-44a8-8057-58a60b7df755");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fleet Tempo",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36b0f671-ac4e-49a9-81e8-96e0b6136a5f"), Type = TextBlockType.Text, Text = "To rush after a criminal or reach someone in need, you ring a sprightly tone. You and all allies within 30 feet gain a +10-foot status bonus to all Speeds for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ed7270b-4026-49cb-b028-a46cd0dd3b53"), Feats.Instances.NantambuChimeRingerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9d7f0c2-2c80-42e6-9161-9e8e68b06db8"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
