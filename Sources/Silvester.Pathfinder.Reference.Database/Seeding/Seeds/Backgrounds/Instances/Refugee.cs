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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement you came from.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Streetwise.ID);
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
