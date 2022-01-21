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
    public class TentacleCannon : Template
    {
        public static readonly Guid ID = Guid.Parse("7ac804f2-2ecb-43b2-a227-5ac1ad796808");

        public static readonly Guid STANDARD_ID = Guid.Parse("c13fe541-7526-4a3f-b50f-a1b805bd0789");
        public static readonly Guid GREATER_ID = Guid.Parse("4dbd8ab1-6f86-4f7a-811b-68d6266cddb2");
        public static readonly Guid MAJOR_ID = Guid.Parse("526b2f65-e666-40a1-802f-c616ef933255");

        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Tentacle Cannon",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8841e309-2f2b-4e9d-b6ba-cb0cf95c62e0"), "A tentacle cannon is a +1 striking weapon, built using components from squids, krakens, and sometimes even stranger tentacled creatures like alghollthu. It's a distinct type of martial firearm that deals 1d8 piercing damage. It has the capacity 5, concussive, and fatal d12 traits, a range increment of 30 feet, and reload 2. The weapon itself resembles a five-barreled handheld cannon with each barrel made from a hollowed out tentacle.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = STANDARD_ID,
                Name = "Tentacle Cannon",
                CraftingRequirements = "The initial raw materials must include the tentacles and ink glands of a creature with a tentacle Strike and ink.",
                Level = 7,
                Price = 36000,
                Hands = "2",
                Range = 30,
                Reload = 2,
                Damage = "2d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c4e830a1-961e-4974-a144-c965394ee931"), "It's a +1 striking weapon.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("282998f8-ef01-4eed-9e42-3afaf53ab4a8"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("fc3faa9e-485d-4863-bd03-e6b4a1ca606c"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("a8cae479-5bf5-47f3-bea9-e1279e71d8b8"), Traits.Instances.Transmutation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("db7ddbb1-ac30-45d1-aedd-a2862f5a10be"), "You cause one of the tentacles forming the weapon's five barrels to stretch out and attempt to pull and grab a creature within 15 feet. The tentacle attempts to Grapple with a +13 bonus. It can attempt to Grapple any creature, regardless of size. On a success, the tentacle pulls the creature up to 10 feet directly towards you, until it�s in a square adjacent to you.");
                            });
                    })
                    .Add(Guid.Parse("280c8273-6dc0-4c27-aca2-13005cc6e12b"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("The Tentacle Cannon has a creature grabbed.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("706eba5a-3256-499b-9f70-cd6e17d11660"), "You continue to keep the tentacle cannon�s hold on one creature it has grabbed. Attempt another check to Grapple the creature with a +13 bonus.");
                            });
                    })
                    .Add(Guid.Parse("9b3d2746-f3ee-46f6-990a-1674d979773e"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("10bfe385-c854-46aa-a7ed-b5ed7621846b"), "The cannon fires a spray of ink in a 15-foot cone. Creatures in the area must attempt a DC 23 Reflex save. On a failure, the creature is covered in ink and becomes blinded for 1 round and dazzled for 1 minute or until it removes the ink. On a critical failure, the creature becomes blinded and dazzled; both conditions last for 1 minute or until it removes the ink. The creature, or an adjacent creature, can use an Interact action to remove the ink from its eyes to remove the blinded and dazzled conditions.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = GREATER_ID,
                Name = "Tentacle Cannon (Greater)",
                CraftingRequirements = "The initial raw materials must include the tentacles and ink glands of a creature with a tentacle Strike and ink.",
                Level = 13,
                Price = 200000,
                Hands = "2",
                Range = 30,
                Reload = 2,
                Damage = "3d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e97704fa-525a-4b5d-a530-4bb62fbed114"), "A greater tentacle cannon is a +2 greater striking weapon. It has a +20 bonus to Grapple, and its ink spray DC is 30.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("063797d8-9487-4ace-86a7-1a498ad6a202"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("6d954d17-be25-41b6-9449-3d5afcfd0a45"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("66a923f8-47b5-48f9-ad44-28c2ba6cdaa7"), Traits.Instances.Transmutation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ae7bbbc8-83d4-465d-a31b-b447b1018a2d"), "You cause one of the tentacles forming the weapon's five barrels to stretch out and attempt to pull and grab a creature within 15 feet. The tentacle attempts to Grapple with a +20 bonus. It can attempt to Grapple any creature, regardless of size. On a success, the tentacle pulls the creature up to 10 feet directly towards you, until it�s in a square adjacent to you.");
                            });
                    })
                    .Add(Guid.Parse("25f587cc-dc72-4cd0-bb7f-132a5f0ff1d4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("The Tentacle Cannon has a creature grabbed.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("dc41c44b-a05d-43e2-b6d6-5c3221a37359"), "You continue to keep the tentacle cannon�s hold on one creature it has grabbed. Attempt another check to Grapple the creature with a + 20 bonus.");
                            });
                    })
                    .Add(Guid.Parse("cc34978e-6045-4a6c-af9a-5371361f6a75"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7f127044-3c9f-4e9e-a6a0-79dea427a661"), "The cannon fires a spray of ink in a 15-foot cone. Creatures in the area must attempt a DC 30 Reflex save. On a failure, the creature is covered in ink and becomes blinded for 1 round and dazzled for 1 minute or until it removes the ink. On a critical failure, the creature becomes blinded and dazzled; both conditions last for 1 minute or until it removes the ink. The creature, or an adjacent creature, can use an Interact action to remove the ink from its eyes to remove the blinded and dazzled conditions.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = MAJOR_ID,
                Name = "Tentacle Cannon (Major)",
                CraftingRequirements = "The initial raw materials must include the tentacles and ink glands of a creature with a tentacle Strike and ink.",
                Level = 17,
                Price = 1500000,
                Hands = "2",
                Range = 30,
                Reload = 2,
                Damage = "3d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                PotencyId = Potencies.Instances.Major.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("e521ceee-b16a-4e5d-bfa3-b8fe6d870dd5"), "A major tentacle cannon is a +3 greater striking weapon. It has a +27 bonus to Grapple, and its ink spray DC is 37.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c7a3bcfa-b0e2-4346-a2dd-f768f0aff400"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("01add8d8-f2cd-49a7-8d1c-f297093fd0c9"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("357f4ce5-697e-460c-8317-b9410fff861f"), Traits.Instances.Transmutation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("18e227c7-7c9c-4551-aadb-6c2c5b75589a"), "You cause one of the tentacles forming the weapon's five barrels to stretch out and attempt to pull and grab a creature within 15 feet. The tentacle attempts to Grapple with a +27 bonus. It can attempt to Grapple any creature, regardless of size. On a success, the tentacle pulls the creature up to 10 feet directly towards you, until it�s in a square adjacent to you.");
                            });
                    })
                    .Add(Guid.Parse("6659adb5-1589-4510-9575-08a61015f60f"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("The Tentacle Cannon has a creature grabbed.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("edc21ea8-7b1d-4eb8-995e-4139cd4168cf"), "You continue to keep the tentacle cannon�s hold on one creature it has grabbed. Attempt another check to Grapple the creature with a +27 bonus.");
                            });
                    })
                    .Add(Guid.Parse("78ce8a80-75db-4ff8-a384-c6c90b47f7f6"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7b7170fb-bea8-435d-a24c-5d46d2cf81fb"), "The cannon fires a spray of ink in a 15-foot cone. Creatures in the area must attempt a DC 37 Reflex save. On a failure, the creature is covered in ink and becomes blinded for 1 round and dazzled for 1 minute or until it removes the ink. On a critical failure, the creature becomes blinded and dazzled; both conditions last for 1 minute or until it removes the ink. The creature, or an adjacent creature, can use an Interact action to remove the ink from its eyes to remove the blinded and dazzled conditions.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("22848a0e-e778-4a34-841e-0e1fd5801540"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ea09d1b6-5af2-42fa-9c42-ef9458cf0fbd"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("c7d69210-2822-4cd4-ab74-94ba8763b3dc"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d7b7da3d-9533-435f-a883-723042a44279"), Traits.Instances.Capacity.ID, "5");
            builder.Add(Guid.Parse("2fe1b14b-bd8f-4d29-99bf-ec4542d95941"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("b4c5f573-28ef-42be-a2ac-17e6f847fd4b"), Traits.Instances.Fatal.ID, "d12");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("281a1d39-40f2-4cfe-b9a4-f48f6097d54e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 156
            };
        }
    }
}
