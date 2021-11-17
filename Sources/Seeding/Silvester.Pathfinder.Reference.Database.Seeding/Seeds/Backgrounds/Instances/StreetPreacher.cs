using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class StreetPreacher : Template
    {
        public static readonly Guid ID = Guid.Parse("f5363bda-c26b-4a8b-807f-7bf88221457b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Street Preacher",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("04da2593-bfee-4548-8dfe-d563f4f52860"), Type = TextBlockType.Text, Text = "Forget the church orthodoxy and the stuffy cloisters' spreading the word of your god to the people is your calling. You've preached on the street corners and in public houses, to wanderers on the road and to captives in the stocks. Adventuring can take you across the world. What vocation could better serve to take your holy words to fresh ears?" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("895270bf-7078-4da8-8ca0-e684df402e51"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("9a07f36b-b98f-42ea-985a-94528ac85c1c"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("c1368783-c6df-442c-9c18-27121404767e"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("6ceaddb3-d9ea-4019-89db-2a138026e162"));
            builder.GainSpecificSkillProficiency(Guid.Parse("e679004e-1d47-4fe7-beb8-874a50557199"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("a9d52eb7-84d5-40b6-8490-816f67201108"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Deities.ID, "The chosen Lore skill must be related to your patron deity.");
            builder.GainSpecificFeat(Guid.Parse("2eb2ba02-da4d-4001-8c27-706040dabc83"), Feats.Instances.DubiousKnowledge.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0709433-0d87-46fc-8c8e-49409cb30e10"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
