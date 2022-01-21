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
    public class DrakeRifle : Template
    {
        public static readonly Guid ID = Guid.Parse("c377a100-2c87-4e00-aca9-4e49441b6d2e");

        public static readonly Guid ACID_ID = Guid.Parse("33e2793f-f158-44a0-bb31-48dad0a60b58");
        public static readonly Guid COLD_ID = Guid.Parse("c15a7248-0581-4599-b909-52e184d84690");
        public static readonly Guid ELECTRICITY_ID = Guid.Parse("9088424d-161b-4397-bc93-edf8e6b68e9a");
        public static readonly Guid FIRE_ID = Guid.Parse("9aa6e1a0-1c0b-48a4-9739-122992069ca2");
        public static readonly Guid POISON_ID = Guid.Parse("b4efbb4d-c7e2-4583-a0f7-6f85d8e0a9ed");

        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Drake Rifle",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("200698c5-18fa-4c65-8f4d-f3e1622e39ef"), "A drake rifle is a firearm made from the saliva glands of a drake. The firearm launches small bursts of empowered spittle instead of typical rounds of ammunition. A drake rifle is a +1 weapon. It�s a distinct type of martial firearm that deals 1d10 damage with a range increment of 150 feet and reload 1. It deals acid, cold, electricity, fire, or poison damage, depending on the drake from which it was made. On a critical hit, the spittle clings to the target and they take persistent damage of the same type as the weapon equal to 1d4 + the number of weapon damage dice. A drake rifle does not add critical specialization effects.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = ACID_ID,
                Name = "Drake Rifle (Acid)",
                CraftingRequirements = "The initial raw materials must include the saliva glands of a ritually hunted drake with a breath weapon that deals acid damage.",
                Level = 4,
                Price = 10000,
                Range = 150,
                Reload = 1,
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Acid.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c196fe31-69e5-4845-9a9d-fa50c05eff73"), ActionTypes.Instances.ThreeActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("587f1594-b3da-4229-8cc3-264d54a10985"), Traits.Instances.Evocation.ID);
                                traits.Add(Guid.Parse("af226206-a4f6-436c-a2a0-0b6fa6b4d62c"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("89eeb40f-7424-4729-bf4a-05421109ed92"), "You fire a large, specialized burst designed to hamper your foes. Make a ranged Strike with the drake rifle. As long as the Strike isn't a critical failure, the drake rifle deals 1 acid splash damage per weapon damage die to the target and creatures within 5 feet of the target.");
                                effect.Text(Guid.Parse("9115b5eb-7158-4967-b124-41425cd4dfbf"), "On a hit, clinging acid makes it painful and sickening for the target to move. The target becomes sicked 1.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = COLD_ID,
                Name = "Drake Rifle (Cold)",
                CraftingRequirements = "The initial raw materials must include the saliva glands of a ritually hunted drake with a breath weapon that deals cold damage.",
                Level = 4,
                Price = 10000,
                Range = 150,
                Reload = 1,
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Cold.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("f7b3be87-59a2-4a33-a4bb-3328e7ae48b5"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Frequency("Once per day.")
                           .Traits(traits =>
                           {
                               traits.Add(Guid.Parse("c0a84277-bcc6-48a8-b4bf-70262650bcbc"), Traits.Instances.Evocation.ID);
                               traits.Add(Guid.Parse("fa7155c5-bf53-485b-9899-02789acfd7a1"), Traits.Instances.Magical.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("3b88b09b-0b4f-4106-bf1c-52a62be9c410"), "You fire a large, specialized burst designed to hamper your foes. Make a ranged Strike with the drake rifle. As long as the Strike isn't a critical failure, the drake rifle deals 1 cold splash damage per weapon damage die to the target and creatures within 5 feet of the target.");
                               effect.Text(Guid.Parse("967e9e9a-8f5b-4bfb-b777-01a2fd49cc47"), "On a hit, frozen spittle clings to the target. The target takes a 10-foot status penalty to their Speed for 1 minute.");
                           });
                   })
                   .Build()
            };

            yield return new BeastGunVariant
            {
                Id = ELECTRICITY_ID,
                Name = "Drake Rifle (Electricity)",
                CraftingRequirements = "The initial raw materials must include the saliva glands of a ritually hunted drake with a breath weapon that deals elecitrical damage.",
                Level = 4,
                Price = 10000,
                Range = 150,
                Reload = 1,
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Electricity.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("2140944b-38aa-451b-a9de-f04af94ed5d7"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Frequency("Once per day.")
                           .Traits(traits =>
                           {
                               traits.Add(Guid.Parse("4d206d30-0d52-45a1-befd-a5910d080469"), Traits.Instances.Evocation.ID);
                               traits.Add(Guid.Parse("498cee32-1909-44d3-8d6a-5200ea88cc94"), Traits.Instances.Magical.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("19d67c4f-7403-42c0-af4b-37ea2a0306f8"), "You fire a large, specialized burst designed to hamper your foes. Make a ranged Strike with the drake rifle. As long as the Strike isn't a critical failure, the drake rifle deals 1 electricity splash damage per weapon damage die to the target and creatures within 5 feet of the target.");
                               effect.Text(Guid.Parse("c072d1a4-7879-4804-8ea9-cf3307c90ed2"), "On a hit, small bursts of electricity continue to spark and jolt the target. The target becomes dazzled and flat-footed for 1d4 rounds.");
                           });
                   })
                   .Build()
            };


            yield return new BeastGunVariant
            {
                Id = FIRE_ID,
                Name = "Drake Rifle (Fire)",
                CraftingRequirements = "The initial raw materials must include the saliva glands of a ritually hunted drake with a breath weapon that deals fire damage.",
                Level = 4,
                Price = 10000,
                Range = 150,
                Reload = 1,
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Fire.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("e974f61a-40ee-4557-b6f7-a3d0326a8625"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Frequency("Once per day.")
                           .Traits(traits =>
                           {
                               traits.Add(Guid.Parse("b0420359-2afa-4d6f-a1c7-fbb33b97d8ac"), Traits.Instances.Evocation.ID);
                               traits.Add(Guid.Parse("e3a34b71-efc6-4a5d-9bf0-ad53bdd114f2"), Traits.Instances.Magical.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("5c70caaa-7bc7-498c-8854-e87cbb3ca02c"), "You fire a large, specialized burst designed to hamper your foes. Make a ranged Strike with the drake rifle. As long as the Strike isn't a critical failure, the drake rifle deals 1 fire splash damage per weapon damage die to the target and creatures within 5 feet of the target.");
                               effect.Text(Guid.Parse("c2138c57-9fd3-4049-a9d7-f500e8ecfe7a"), "On a hit, a massive explosion knocks the target back. The target is pushed 10 feet away from you, and if it's on the ground, it falls prone.");
                           });
                   })
                   .Build()
            };

            yield return new BeastGunVariant
            {
                Id = POISON_ID,
                Name = "Drake Rifle (Poison)",
                CraftingRequirements = "The initial raw materials must include the saliva glands of a ritually hunted drake with a breath weapon that deals poison damage.",
                Level = 4,
                Price = 10000,
                Range = 150,
                Reload = 1,
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Poison.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("e93330d7-66d6-42da-a049-903e1ae1b0be"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Frequency("Once per day.")
                           .Traits(traits =>
                           {
                               traits.Add(Guid.Parse("8ebd806e-3b82-42a4-a49d-e89f0e84be11"), Traits.Instances.Evocation.ID);
                               traits.Add(Guid.Parse("b963bb47-627c-4735-8908-07320e5b4f4b"), Traits.Instances.Magical.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("4e891d1c-7fce-4064-9c0d-5f9f95b2a6d6"), "You fire a large, specialized burst designed to hamper your foes. Make a ranged Strike with the drake rifle. As long as the Strike isn't a critical failure, the drake rifle deals 1 poison splash damage per weapon damage die to the target and creatures within 5 feet of the target.");
                               effect.Text(Guid.Parse("c9ef1c6c-3ca0-4bfb-981f-5bbd5147e130"), "On a hit, noxious vapors fill the target's lungs. The target becomes enfeebled 1 and clumsy 1 for 1 minute.");
                           });
                   })
                   .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2af0369e-7994-4679-9b4e-01d55bb59aa6"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("726e30d9-2d73-49fe-9550-3392530be5de"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b00d32a-187d-4de7-be35-7a45f41ac04b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 154
            };
        }
    }
}
