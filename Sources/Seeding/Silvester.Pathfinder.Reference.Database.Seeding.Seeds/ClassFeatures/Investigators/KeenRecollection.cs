using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class KeenRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("5878e207-49c4-4511-938c-8593e823b6b6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Keen Recollection", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea5d6194-c094-4d11-8cff-0b705a044fd9"), Type = TextBlockType.Text, Text = "You can recall pertinent facts on topics that aren't your specialty. Your proficiency bonus to untrained skill checks to Recall Knowledge is equal to your level instead of +0." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add modification to Recall Knowledge.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60157d8b-dfe7-42c5-88a1-91b7a567cc93"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
