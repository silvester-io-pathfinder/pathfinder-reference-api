using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class HybridStudy : Template
    {
        public static readonly Guid ID = Guid.Parse("8363985c-992e-4159-a8b6-aedd7b2b0f6e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Hybrid Study", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("208ccda8-63a5-42ad-9440-9ecf991b91f3"), Type = TextBlockType.Text, Text = "Your extensive physical training and carefully chosen magic combine to form a unique and dangerous fighting style that's more than the sum of its parts. You choose one field of hybrid study to represent your particular combination of skills. Your hybrid study gives you a special ability, usually tied to Spellstrike or Arcane Cascade, and it determines your initial conflux spell." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyHybridStudy(Guid.Parse("70bfdd91-81b7-42b1-9adb-c2c5343ed740"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34896eb3-f978-48d7-a684-75782a7ac6e2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 38
            };
        }
    }
}
