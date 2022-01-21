using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class EvolutionFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8eb08ec8-7b48-4f58-b53d-5327d94d1c72");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Evolution Feat", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("88951512-65db-4a39-867b-dec1f36734f7"), Type = TextBlockType.Text, Text = "Evolution feats are a special type of summoner class feat that allow you to customize your eidolon through your shared link. You gain an evolution feat for your eidolon at 1st level, representing the differences that make it unique from other eidolons of its type. If you retrain this feat, the feat you replace it with must also be an evolution feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTraitFeat(Guid.Parse("bc2dfbc6-2f08-4bd7-bd3c-2f4132addd31"), Traits.Instances.Evolution.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8aac9a77-b36c-4bbe-8d7e-3e2e38628ed4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
