using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("346a4378-15d8-465d-97e6-88452484c43e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Eyes",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75485e4b-863a-4b7a-a2a6-c2448780258b"), Type = TextBlockType.Text, Text = "You can see through darkness. You gain darkvision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("e0925e7e-57e8-4458-9bbd-db7ef80b33ba"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d62b5c38-214e-4d60-b810-36482a80dbd8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
