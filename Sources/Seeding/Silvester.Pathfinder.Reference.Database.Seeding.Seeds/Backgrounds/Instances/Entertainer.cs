using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Entertainer : Template
    {
        public static readonly Guid ID = Guid.Parse("4f419ec1-4cbc-4694-9345-5f35a12abefa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Entertainer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7cff8a90-fec7-4e1c-86a1-b74930d69089"), Type = TextBlockType.Text, Text = "Through an education in the arts or sheer dogged practice, you learned to entertain crowds. You might have been an actor, a dancer, a musician, a street magician, or any other sort of performer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("2484c1f2-6e56-4039-aa76-b0976ede4945"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("a1e9d9df-b9d5-457e-aca9-545a5e0ae528"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("a8fa42de-682d-49d4-b487-a1cba24cd89a"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("6b17bd62-449a-4f4e-8e88-dca11a7a3392"));
            builder.GainSpecificSkillProficiency(Guid.Parse("86926174-6021-47b4-a80e-963471aca6a9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("fb695dea-f469-4872-a536-f2c1fadfa708"), Proficiencies.Instances.Trained.ID, Lores.Instances.Theater.ID);
            builder.GainSpecificFeat(Guid.Parse("645e948d-5e90-4139-bf05-436883e87b3c"), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f793dc51-938b-44fb-beda-bba00a6b77f2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
