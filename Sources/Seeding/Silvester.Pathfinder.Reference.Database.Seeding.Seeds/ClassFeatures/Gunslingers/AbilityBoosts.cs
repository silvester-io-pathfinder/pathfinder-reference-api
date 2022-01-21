using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("d20fde85-f8d7-4630-9920-a56ab4d41011");

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
            yield return new TextBlock { Id = Guid.Parse("490f41b4-3210-4171-b8da-81fd0d3af7e9"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("425d046a-c8c3-453f-a824-90031581cd3b"), Guid.Parse("cc067939-6fc9-46c8-8719-0f640373c660"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("49cda30b-fa2d-4c33-a495-9a758d346345"), Guid.Parse("13b93e6d-79fe-42d5-a7cf-461cea435035"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("ea40da0c-05a1-4cc1-9f09-58b39251ce61"), Guid.Parse("7081c066-1b63-4ccd-9d8e-1782e7b6353e"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("30687808-dfee-4bda-b449-0b1df2982b4f"), Guid.Parse("ed7107ad-0f89-44d7-a7d8-d50f13cb1457"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("0b531b53-fce6-4ed2-81d9-f1f092e10ebd"), Guid.Parse("96629ec6-072c-4089-98ff-245a5e2b4037"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("49a61554-19d3-4fbd-8671-1badeeaae805"), Guid.Parse("bdb37ebd-8d68-4457-af66-bb4caca56052"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("627f9d0e-8101-4280-b2a1-5e4dcb4e3f6e"), Guid.Parse("cda45edc-f29e-419e-9468-a38e48ac6aaf"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("49f8416b-2fbd-45e4-a2f2-9d8cc596fc27"), Guid.Parse("b1c36c1c-f48e-4295-bb61-9644f2fdef8a"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("f79aa1f2-d355-4bd0-832f-41b5f33ad2b4"), Guid.Parse("d09b75e7-cfb2-47e0-bccb-4809f255d2c0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("d60fd4d5-39d1-4932-97f6-1835616597e2"), Guid.Parse("acc6d52b-c93c-4873-a372-1150128580c0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("dc6b4237-0f9b-4efb-97a6-badc42f7e74f"), Guid.Parse("345f461c-6e8a-419d-8651-5d3c328eb9e3"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("e2e42273-fa1b-4b41-a497-2c00d587a723"), Guid.Parse("adbfd09c-3f02-4d9c-9f17-d9c82a0a2d79"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("0aca8460-8bb7-45b1-8e53-1ab99138765a"), Guid.Parse("a0bf0719-4b12-43e5-b212-d9c9938a4940"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("bde95e8d-6baa-4283-8054-3d9978a9390c"), Guid.Parse("9e7e84de-7de0-4b5e-873e-f6b2872d5629"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("0a1e59ad-b2ee-4787-9e09-a77aedaa3bfe"), Guid.Parse("9b2fba50-4d27-45de-b9c3-603c39ea7bf9"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("aaf6178e-3e35-441f-87c1-f7cd6aefc774"), Guid.Parse("bc03092e-08d4-4b69-837e-1d5ed4260c30"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5ec4573-4dde-4953-b819-498e4c778f6b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
