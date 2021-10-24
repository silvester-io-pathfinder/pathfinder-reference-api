using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Trailblazer : Template
    {
        public static readonly Guid ID = Guid.Parse("010bc624-87f4-447f-a29a-9d9a76e1d372");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Trailblazer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9175b76f-fa06-45d9-b3df-7246f82ecc85"), Type = TextBlockType.Text, Text = "Uncharted realms have always intrigued you, and you've explored and mapped large territories in service to merchants, governments, or your own curiosity. Where some see a blank spot on a map, you see the potential for something new and undiscovered." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Cartography.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TerrainExpertise.ID, "The chosen terrain should be one that you've explored (such as forest or underground).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cef12ff2-e261-46db-bbdc-92386ede20f9"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
