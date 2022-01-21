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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("97d583c3-5f2b-42d6-aa2d-843d60a552f5"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("9a8df684-173a-41cd-9b1c-8bc17aa8b1ce"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("22cdea66-6e1c-4aeb-b017-842eddaa9f76"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("1b99effd-e558-4055-9dcb-b81c7f2978ae"));
            builder.GainSpecificSkillProficiency(Guid.Parse("b397ab2a-2696-4bec-a8c6-8e9621c3518f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("0ea974f6-6972-45a5-8cc5-a243eddeb17e"), Proficiencies.Instances.Trained.ID, Lores.Instances.Mercantile.ID);
            builder.GainSpecificFeat(Guid.Parse("2b51e1d8-6a64-4d27-97da-224c364e47a8"), Feats.Instances.CraftersAppraisal.ID);
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
