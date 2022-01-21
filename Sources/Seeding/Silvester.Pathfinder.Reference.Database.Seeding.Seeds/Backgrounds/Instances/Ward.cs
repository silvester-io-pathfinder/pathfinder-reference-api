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
    public class Ward : Template
    {
        public static readonly Guid ID = Guid.Parse("43c093ea-e06e-4759-a0df-6c4df20fe7b3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Ward",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b22e9381-d3c6-4405-9508-b84c683d9e8a"), Type = TextBlockType.Text, Text = "When you were young, you became the ward of another house'boarded, fed, and educated, but never quite a part of the family. Perhaps you had to tend to their needs in return for feeding and raising you, or perhaps you were provided for but disregarded. Now, adventuring is your chance to grow and roam free." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("9990b9de-d7fd-4500-bc85-44ffa7d5e9b0"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("79f89e80-3aed-4651-8f01-29ff6e8e4b3a"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("fbe16f37-fd34-4523-8e4b-034353af83d2"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("9d4b9a22-8b29-4956-b735-89017e17ba94"));
            builder.GainSpecificSkillProficiency(Guid.Parse("8eda2afd-150b-42fe-a884-b71de3be9938"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("d7ed267b-f4de-409d-a3ef-49ee5a791116"), Proficiencies.Instances.Trained.ID, Lores.Instances.Genealogy.ID);
            builder.GainSpecificFeat(Guid.Parse("da598c36-8ffb-4ec6-aecd-43f11c86a6ed"), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("240488cd-288d-470a-ad81-57f39af5bf9f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
