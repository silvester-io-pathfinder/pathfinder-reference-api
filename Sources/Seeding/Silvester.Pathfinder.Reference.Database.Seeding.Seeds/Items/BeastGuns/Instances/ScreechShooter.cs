using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.BeastGuns.Instances
{
    public class ScreechShooter : Template
    {
        public static readonly Guid ID = Guid.Parse("cfa80f23-d5f8-4980-93c8-73e4a0a36164");

        public static readonly Guid STANDARD_ID = Guid.Parse("d9659b18-4581-413c-9051-491cf7296c99");
        public static readonly Guid GREATER_ID = Guid.Parse("2ae432ab-7f20-41f3-9785-c30e0a7b4ad4");
        public static readonly Guid MAJOR_ID = Guid.Parse("ea077eb2-b1ed-4c5c-9409-6ddc2b582ea4");

        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Screech Shooter",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f124b89f-22ce-4c9c-8464-54ef497aae43"), "Built from the larynx of an owlbear, terror shrike, or similar animal that possesses a frightening screech or similar special ability, a screech shooter is a special +1 striking harmona gun designed to fire terrifying blasts of sound. A screech shooter deals sonic damage but can otherwise be used like a normal harmona gun.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = STANDARD_ID,
                Name = "Screech Shooter",
                CraftingRequirements = "The initial raw materials must include the larynx of a creature with a frightening screech.",
                Level = 9,
                Price = 70000,
                Hands = "2",
                Range = 150,
                Reload = 1,
                Damage = "2d10",
                DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ccdbbb3f-6fee-462d-9495-5bfa4f7753fe"), "It's a special +1 striking harmona gun.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4a7acfc4-7507-4564-b751-cea22da028a2"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Traits(traits => 
                            { 
                                traits.Add(Guid.Parse("48657543-aa6e-4c34-a9b9-c4959c06febe"), Traits.Instances.Emotion.ID);
                                traits.Add(Guid.Parse("a04965d6-53a9-4f15-ba9b-1c783b9e1c88"), Traits.Instances.Enchantment.ID);
                                traits.Add(Guid.Parse("c4e75e18-7290-4b0f-bf28-9f8b56ca6eed"), Traits.Instances.Fear.ID);
                                traits.Add(Guid.Parse("821a2378-555e-4dd4-b077-9446e68b9d2b"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("6f45231e-88ea-4306-b98b-ef67e0612fd7"), Traits.Instances.Mental.ID);
                            })
                            .RollableEffect(Guid.Parse("6eab4cfe-a86e-41b5-9642-21f66d39ba47"), effect => 
                            {
                                effect.CriticalSuccess("The creature is unaffected.");
                                effect.Success("The creature is frightened 1.");
                                effect.Failure("The creature is frightened 2.");
                                effect.CriticalFailure("The creature is frightened 3 and fleeing for 1 round.");
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("91aa82e7-1af3-4055-92f8-c5b812d0a320"), "The screech shooter unleashes a frightening wail. All creatures in a 30-foot emanation from you must attempt a DC 25 Will save.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = GREATER_ID,
                Name = "Screech Shooter (Greater)",
                CraftingRequirements = "The initial raw materials must include the larynx of a creature with a frightening screech.",
                Level = 13,
                Price = 300000,
                Hands = "2",
                Range = 150,
                Reload = 1,
                Damage = "3d10",
                DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("35b66bac-12de-4230-bc6a-2331c40a8e0b"), "A greater screech shooter is a +2 greater striking harmona gun. The DC for the activation is 30 and it affects creatures in a 40-foot emanation.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("74903d56-5a2e-4b67-94c2-c0a2360048f7"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("9e481f21-2336-41a2-9c50-3816e962770d"), Traits.Instances.Emotion.ID);
                                traits.Add(Guid.Parse("ec65f061-adfc-4de9-ab57-f0564bcff5d3"), Traits.Instances.Enchantment.ID);
                                traits.Add(Guid.Parse("807ca54c-e751-415d-b2c1-a726af12a331"), Traits.Instances.Fear.ID);
                                traits.Add(Guid.Parse("ad15c637-e528-41ee-b4a5-14d405f6db68"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("8b2cb15b-e06c-4560-be17-1cba802d6db3"), Traits.Instances.Mental.ID);
                            })
                            .RollableEffect(Guid.Parse("9a79dba6-f726-4b97-9826-848f8aca8329"), effect =>
                            {
                                effect.CriticalSuccess("The creature is unaffected.");
                                effect.Success("The creature is frightened 1.");
                                effect.Failure("The creature is frightened 2.");
                                effect.CriticalFailure("The creature is frightened 3 and fleeing for 1 round.");
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("130bdd00-f06d-4158-87ad-46d2003a9f6a"), "The screech shooter unleashes a frightening wail. All creatures in a 40-foot emanation from you must attempt a DC 30 Will save.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = MAJOR_ID,
                Name = "Screech Shooter (Major)",
                CraftingRequirements = "The initial raw materials must include the larynx of a creature with a frightening screech.",
                Level = 17,
                Price = 1500000,
                Hands = "2",
                Range = 150,
                Reload = 1,
                Damage = "3d10",
                DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
                PotencyId = Potencies.Instances.Major.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("feabfed7-f752-492b-a074-90ddbf14a79e"), "The DC for the activation is 37 and it affects creatures in a 50 - foot emanation.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("38ff1dc1-739b-4234-9df1-31e762a54c5f"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("e241568a-644b-43bc-b339-0f7643f702b1"), Traits.Instances.Emotion.ID);
                                traits.Add(Guid.Parse("7cb76777-b0f1-4ccd-be48-fcde5310af24"), Traits.Instances.Enchantment.ID);
                                traits.Add(Guid.Parse("c3f52cf5-eb56-45eb-a871-6fc43a2d6fad"), Traits.Instances.Fear.ID);
                                traits.Add(Guid.Parse("6047a735-b728-4fba-afcc-3ae3e2c237e9"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("7587a186-8ae9-4ea6-97cf-c963ea042397"), Traits.Instances.Mental.ID);
                            })
                            .RollableEffect(Guid.Parse("de70deba-c235-467a-9008-3046b3fe334d"), effect =>
                            {
                                effect.CriticalSuccess("The creature is unaffected.");
                                effect.Success("The creature is frightened 1.");
                                effect.Failure("The creature is frightened 2.");
                                effect.CriticalFailure("The creature is frightened 3 and fleeing for 1 round.");
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ed6f9419-327d-4876-8cff-71969bbd5a25"), "The screech shooter unleashes a frightening wail. All creatures in a 50-foot emanation from you must attempt a DC 37 Will save.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("48fbc70b-6b8c-4368-86d2-fec32cb61089"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8c86b95c-d1ec-4e67-a4c0-e26c24f014b2"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("37b26473-9d05-43fb-bbb8-54f703024135"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6e9f5163-03df-4de8-bc76-c04d6e89b7a5"), Traits.Instances.Kickback.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("239b33c1-08df-4c3e-9d10-e4dd2017b7ec"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 155
            };
        }
    }
}
