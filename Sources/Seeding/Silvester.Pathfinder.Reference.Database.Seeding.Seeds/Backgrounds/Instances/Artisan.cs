using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Artisan : Template
    {
        public static readonly Guid ID = Guid.Parse("74d5f9f5-0428-41db-b417-f0c5889072bf");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Artisan",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5d1aa430-6fba-4dd8-9390-5eb2b1d3730b"), Type = TextBlockType.Text, Text = "As an apprentice, you practiced a particular form of building or crafting, developing specialized skill. You might have been a blacksmith's apprentice toiling over the forge for countless hours, a young tailor sewing garments of all kinds, or a shipwright shaping the hulls of ships." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("fee48a72-cc61-4acb-b4b0-62f04d60ef53"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("cb606f17-3232-49e1-8406-6711eade60cb"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("deec4377-51af-4ca8-839b-0500b3c85638"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("f962644c-afef-4c8c-9e8d-bb728e96b13f"));
            builder.GainSpecificSkillProficiency(Guid.Parse("944f373b-4739-4b1a-8408-fa652ad33c7f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("a11402c5-ff27-4250-8500-90b622ca823e"), Proficiencies.Instances.Trained.ID, Lores.Instances.Guild.ID);
            builder.GainSpecificFeat(Guid.Parse("633c4be9-c4ff-4808-aebe-6cfdbdcf5a7d"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a305580-2d54-4090-94ae-465b22e10fab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
