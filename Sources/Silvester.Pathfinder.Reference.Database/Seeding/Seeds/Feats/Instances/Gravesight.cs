using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gravesight : Template
    {
        public static readonly Guid ID = Guid.Parse("97a65623-aa64-4a79-a243-1bd8560c81a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gravesight",
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
            yield return new TextBlock { Id = Guid.Parse("1cf32ac5-6439-4cfe-8608-cd43c9b8f78a"), Type = TextBlockType.Text, Text = "You can see in the darkness as easily as a psychopomp. You gain darkvision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("004d9659-a423-400f-8183-3a87ddf494a4"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea601d33-06b6-4bda-9b56-b82fd3054fb9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
