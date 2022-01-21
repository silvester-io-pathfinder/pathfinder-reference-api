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
    public class SharedReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("c7bfa42b-755d-4a7c-bbe8-c6cdf96b6545");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Shared Reflexes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a8013d45-b9d2-410c-8619-6574436e5f69"), Type = TextBlockType.Text, Text = "You and your eidolon boost each other's reflexes, allowing you both to roll away from danger. Your proficiency rank for Reflex saves and your eidolon's proficiency rank for Reflex saves increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("a52cf135-0eab-42ef-bbbb-b410a81cba81"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff196735-ef3d-4b57-8f63-e511b17f7c29"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
