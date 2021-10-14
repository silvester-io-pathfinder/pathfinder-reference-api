using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("91f9684a-6059-4b6e-902e-5cc28f11b249"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("285dafc9-f6ee-4d70-93c4-0b0c3ec62f7d"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("b97b5298-35d0-4e6e-a32c-efd720945510"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("fd54430a-cef5-4b6f-9579-accd2925e410")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("4bfb64bd-f7b0-4e3a-b285-da48b0021b2d"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("3f6d6ad4-3a91-489f-8661-af8940b3424b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Cartography.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("410a8cc8-0873-4cf8-b8fb-4ef9163c3e6e"),
                FeatId = Feats.General.TerrainExpertiseFeat.ID,
                Restrictions = "The chosen terrain should be one that you've explored (such as forest or underground)."
            };
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
