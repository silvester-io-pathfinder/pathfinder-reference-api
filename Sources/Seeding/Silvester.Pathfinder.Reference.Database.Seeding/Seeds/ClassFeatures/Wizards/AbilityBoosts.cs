using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("6fd0d639-3d0a-4081-b84c-63140e2058d5");

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
            yield return new TextBlock { Id = Guid.Parse("5f63e7c3-7d01-4997-ac44-da26be42770b"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("a0e926ea-4d44-4711-8915-1e49a04b7b5e"), Guid.Parse("f76353f0-9f28-4296-be95-81dda2d4e464"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("f9c86570-68ad-46fb-9f28-07e612477192"), Guid.Parse("3194761e-9256-4cda-953a-e4d6178028cc"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("0f8d06f4-46d1-4770-9e51-17a49a7cefb6"), Guid.Parse("e1c572d2-b576-4dba-ab96-9bcfde272f64"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("0604b24d-9628-4b2a-bade-6b8383aa419f"), Guid.Parse("4c4de38d-c164-458c-b2f6-8552b6ee017a"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("492e9c3b-b811-4166-87c8-23fcd0f6fbe1"), Guid.Parse("f71b0211-fd75-43f3-9d14-f72095b52124"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("a7b6088c-0c40-4800-92ba-33c0ee73e6d6"), Guid.Parse("c7c4c2cb-62ce-438a-bf42-3e0f8b130712"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("d27ec905-a1ce-409a-b33a-7bc0db03ecde"), Guid.Parse("9838208c-d3bb-4ba5-8665-9577af161e0b"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("29b3352d-70c3-4480-8395-59ce5777f8ab"), Guid.Parse("e75b4b45-5809-49ab-9528-30422f78c91a"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("d9fbcd0a-d973-4312-9266-bac51cbe5dac"), Guid.Parse("afb20913-43e1-45db-81b1-87eff2a835eb"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("f2863af4-1522-4028-a14e-48170bab709b"), Guid.Parse("004521f4-6f7c-44ea-bd70-0f75ef7d59a6"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("dbbcfd5e-bebb-452b-9206-b19915d94d02"), Guid.Parse("d88cefcc-dd25-47e7-8fd4-e8d1c9a552db"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("4897c1eb-e4d5-4647-8235-67738e9e1ad7"), Guid.Parse("07788692-d31d-4de5-b19f-60f2628faaa9"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("29bd20e6-ae2c-46cb-a127-7e4e346280ae"), Guid.Parse("667dbbdf-b04c-4032-9260-4a85f1a8e318"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("1b8a96c0-2aee-4a23-867a-56e40e6709d4"), Guid.Parse("46dcc4ff-7d98-403d-bd76-ded225d9df29"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("a91c8513-ab94-46d7-a33a-3a782ebc90af"), Guid.Parse("d320b152-5495-4959-89cd-eaf60b4aa0a0"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("50c245f4-6fa1-45f7-b6db-c59b340cdbab"), Guid.Parse("7a10ebce-c55e-409a-92eb-4d00523b7a52"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53fc2db3-d83a-4d4e-b740-c6b498c66245"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
