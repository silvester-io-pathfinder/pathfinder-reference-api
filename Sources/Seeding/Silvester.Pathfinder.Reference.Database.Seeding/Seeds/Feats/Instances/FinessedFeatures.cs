using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinessedFeatures : Template
    {
        public static readonly Guid ID = Guid.Parse("90e00163-ddac-4079-a47d-c469d6e338c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finessed Features",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3dc71d2a-7e35-429a-bd1d-812a218e037c"), Type = TextBlockType.Text, Text = "You’ve learned how to build snares that trigger based on visual stimuli. When you construct a snare using gears, you can cause it to trigger based on the visual features of a creature. For example, you could lay a snare that can only be triggered by a Large or Larger creatures, or one that only activates when a creature wearing red clothing would trigger it. You can use this ability to specify your snares to trigger on creatures that typically do not trigger snares, such as creatures smaller than Small, though the creature must still otherwise satisfy the snare’s trigger as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("35b0bae7-c0af-4a07-b190-b917408daec2"), Feats.Instances.TrapsmithDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87d2de34-874d-4890-9235-1a0663a28f68"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
