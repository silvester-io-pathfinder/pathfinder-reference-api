using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class EidolonTranscendence : Template
    {
        public static readonly Guid ID = Guid.Parse("2c74ab44-1f0b-41fd-bddd-14b42317924f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Eidolon Transcendence", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2a2e311a-96d1-4c02-b894-fd59496cf8b0"), Type = TextBlockType.Text, Text = "Your connection with your eidolon approaches its peak, granting your eidolon access to a powerful new ability depending on its type, as described in Eidolon Abilities in each eidolon's entry. This ability also increases one of the eidolon's ability scores by 2." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("9fb0574a-f112-4c69-acde-dd2436d953f0"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f222ae4-d124-417a-967a-a9a54c18708c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
