using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("04a314f9-1256-4958-b750-11b3b4a9ae8f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ability Boosts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0db01bad-69dc-4938-9833-53461d7e222b"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("f45014a4-5c25-4163-af04-19fc9c554547"), Guid.Parse("c4e99fe7-fbf6-47c7-a69c-26fefcc33d26"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("2d92b1f9-df7f-4016-9ee6-c886b40fd6e4"), Guid.Parse("e8abbdd8-937b-4b8d-a87a-fc8853e68160"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("7262a07f-0567-400b-905b-b2789bb04400"), Guid.Parse("0a298351-72cd-4fed-ab7f-aabba39beb20"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("b9bedad8-048c-4627-b314-7b6a83c3fcdf"), Guid.Parse("2d640a2f-c440-4e52-bc96-49efe0bec771"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("b16829c8-86a7-494a-89a4-61b5457de663"), Guid.Parse("4e06a4d3-7d4b-43a6-98c3-1ce5c8dbe4e3"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("78351462-8c58-4878-a115-094c8aa6a16c"), Guid.Parse("96af6a28-1042-4ea5-9f27-eaf874f24e25"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("2e3e1fe5-ed7c-4ba3-b900-d922b032f1d6"), Guid.Parse("8c80cf49-0446-4858-9659-bcfa22c116bf"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("65df43a6-42e7-47ea-aa1d-6e8abb66dd26"), Guid.Parse("758041a4-0f76-4e2d-aaca-c6a0b5510dc6"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("501a57b6-d5f6-426d-96df-b0ba89980d17"), Guid.Parse("8a1b45fc-8368-4907-ab58-77f71c18fee3"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("ef3d9147-19ea-41d6-9891-5f4b26fbf548"), Guid.Parse("af231f71-053d-47c7-a3bf-df29c32b4343"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("409c9658-8d5b-441a-b45f-3313b1ca4bdc"), Guid.Parse("a48a77b3-1c6c-4bb8-a719-a3fc492f4853"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("de0dedd6-3a0d-4a00-8d64-f6e44ce67275"), Guid.Parse("7a0bc1d0-87a5-4cda-a40a-e05493208f11"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("832a40b9-6de9-4047-8e58-77e30be20247"), Guid.Parse("8f75ae82-7b81-40c2-a822-f998739d1a9d"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("a214a681-6d20-48be-a645-6ac35a97c38e"), Guid.Parse("bfc9c45e-2680-4b52-8102-f290f6470fa1"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("a48b3dd0-05d4-4b9a-9931-802dae18eb44"), Guid.Parse("7b78680c-0c17-48e0-bf5b-28c9d4c9e10b"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("d33610bc-b720-4659-839f-ce9dc83c7e9d"), Guid.Parse("cc1a3923-f2aa-46c3-9733-71f39af77790"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("824cb35f-e583-4824-b9b8-4320bb0cac08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 181
            };
        }
    }
}
