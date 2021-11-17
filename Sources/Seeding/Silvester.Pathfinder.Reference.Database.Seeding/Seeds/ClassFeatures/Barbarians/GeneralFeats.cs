using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("527cc8e3-6725-414c-b970-2ea0bc85c3fb");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("950ff3ef-9c6b-4d52-9858-0b4faf9f03b8"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("074748a7-5ed8-477a-b6a2-99e2d5dd13de"), Guid.Parse("9331c315-c85b-4059-9021-93a19176fc45"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("02257320-9d2d-4c21-93e6-18513dd4a794"), Guid.Parse("7ac40fae-2fe4-46f0-8512-6182d47e11c9"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("31716f6f-0875-4b95-b0ad-0def5535f2f6"), Guid.Parse("2222bd29-5e84-4fda-91ac-12adc2a9caaa"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("deeb6693-5036-480f-a3fd-4322c6f8259c"), Guid.Parse("bb44af02-eb2a-4bf6-849f-22c92d0ab59b"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("ea18ec0b-17f6-492c-af14-07f6135ac8c8"), Guid.Parse("1810364c-142d-4ac1-997e-4efd61806ffa"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("359d1673-eb2c-421f-9f66-234e50872f28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
