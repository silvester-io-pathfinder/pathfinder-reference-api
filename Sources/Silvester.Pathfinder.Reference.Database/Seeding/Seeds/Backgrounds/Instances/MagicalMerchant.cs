using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MagicalMerchant : Template
    {
        public static readonly Guid ID = Guid.Parse("a21c6c23-f361-403c-bd96-5fe62d6fbd82");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Magical Merchant",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c2a1379-f2d8-40b2-b791-4efe1ca1209f"), Type = TextBlockType.Text, Text = "Selling magic items isn't like being an ordinary merchant. The wares you buy and sell are expensive, making each sale rare and lucrative. You've developed knowledge of expert handiwork to ensure you don't fall for a scam, since buying a single counterfeit item can lead to bankruptcy. Whether you went out of business and had to find alternative employment, or took up adventuring to acquire new merchandise, you've taken to adventuring yourself." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("cfe26399-93ee-4819-b705-49551ce3f17f"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("80d72dcf-7314-4ca7-a31d-7a0c1f960e34"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("9c4718e6-5571-4e75-a446-6e5b88da29a2"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("5e194644-8a46-4ce0-b892-0679a0c08d7d")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("ec0084b7-b1a6-437d-aa65-9dc48315c5db"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("c1f66e7b-01d1-4e55-9f32-c323c6bbd89e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Mercantile.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("8f6d3e29-2264-4462-8d51-f620adb5abe9"),
                FeatId = Feats.General.CraftersAppraisal.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4161bbc0-fb0f-46c5-b01b-e36623ee7752"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
