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
    public class Refugee : Template
    {
        public static readonly Guid ID = Guid.Parse("faf783f7-7f80-4b3e-a4e5-d2e6386adc80");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Refugee",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b8444229-4de9-4670-8fd2-3acc09b3a474"), Type = TextBlockType.Text, Text = "You come from a land very distant from the one you now find yourself in, driven by war, plague, or simply in the pursuit of opportunity. Regardless of your origin or the reason you left your home, you find yourself an outsider in this new land. Adventuring is a way to support yourself while offering hope to those who need it most." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("59fcc95d-7797-4518-a662-e0bb9ccb5951"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("5b4c33c1-c871-4d40-8413-ec66cc297183"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("a455ccbd-e9b0-4a0f-9123-879dee6c733d"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("8873da33-d468-4be6-9caa-8327c7a707b5"));
            builder.GainSpecificSkillProficiency(Guid.Parse("85beb924-17e7-4855-aed0-60dff434cc0f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("5e098f83-5af7-4bb2-a59b-c4220005b2ef"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement you came from.");
            builder.GainSpecificFeat(Guid.Parse("33132201-3508-4de8-9816-fd31693c80ea"), Feats.Instances.Streetwise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21680c69-90b8-40ec-bf51-a79e09411945"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
