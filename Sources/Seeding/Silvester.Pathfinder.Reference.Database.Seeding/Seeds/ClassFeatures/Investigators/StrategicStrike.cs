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
    public class StrategicStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("1efbf0a4-03fd-4af9-a85c-e76cf1a87494");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Strategic Strike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9cb9ffa5-13d9-4db0-87f5-d025b49b29fa"), Type = TextBlockType.Text, Text = "When you strike carefully and with forethought, you deal a telling blow. When making a Strike that adds your Intelligence modifier on your attack roll due to Devising a Stratagem, you deal an additional 1d6 precision damage." };
            yield return new TextBlock { Id = Guid.Parse("edbcb6a6-2e8d-4bf4-83e5-281bf5579321"), Type = TextBlockType.Text, Text = "As your investigator level increases, so too does the deadliness of your strategic strike. Increase the number of dice by one at 5th, 9th, 13th, and 17th levels." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4078c49-836f-4638-9ea7-988d8e502f1d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
