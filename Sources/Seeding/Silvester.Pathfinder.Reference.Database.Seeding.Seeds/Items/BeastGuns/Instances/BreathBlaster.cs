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
    public class BreathBlaster : Template
    {
        public static readonly Guid ID = Guid.Parse("61fb5554-d1dc-490a-801e-7f8db12ce36d");

        public static readonly Guid STANDARD_ID = Guid.Parse("598eb884-0fe6-43ab-87ba-a17fb77f3354");
        public static readonly Guid GREATER_ID = Guid.Parse("b69f563a-f39d-4089-854c-64665088889f");
        public static readonly Guid MAJOR_ID = Guid.Parse("6dce77a5-fc4c-47c1-8a1c-05c37338c481");

        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Breath Blaster",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ccf94576-ccf6-4fc8-946f-e5d70e01a87f"), "A breath blaster is a +1 striking blunderbuss most commonly rafted from the trachea of a dragon, though other creatures with breath weapons or the ability to spit energy are occasionally used. The implementation of the dragon�s trachea allows the firearm to unleash a torrent of pure energy in the form of gouts of flame or bolts of electricity.");
            builder.Text(Guid.Parse("a8702a3b-6030-4ef8-87fa-42aa8bf20ea3"), "A breath blaster�s Strikes deal either acid, cold, electricity, fire, or poison damage, depending on the dragon type or other creature from which it was made, though it can otherwise be used like a normal blunderbuss. A breath blaster also can be activated to fire a line of energy in a 30-foot line or 15-foot cone, chosen when it�s created and typically corresponding to the shape of the breath weapon used by the type of dragon or creature from which the breath blaster was created.");
            builder.Text(Guid.Parse("5d444f63-8e5a-40f6-ac4a-51d437080561"), "In theory, the foundational techniques required to create a breath blaster would allow for other damage types, but such breath blasters would require the trachea from the correct dragon or creature type and additional creation techniques, making such a breath blaster rare rather than uncommon.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = STANDARD_ID,
                Name = "Breath Blaster",
                Level = 8,
                Price = 50000,
                Hands = "2",
                Range = 40,
                Reload = 1,
                Damage = "2d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                CraftingRequirements = "The initial raw materials must include the trachea of a ritually hunted dragon or other creature with a breath weapon with the appropriate damage type and area (line or cone) for the breath blaster.",
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1e3cadac-b2ae-477a-9877-464cd38fce41"), "It's a +1 greater striking blunderbuss.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b1e5949f-994d-4268-be5a-6f9fa8f0793d"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("3cb27d38-c36f-4f4d-9a62-b3e8fe08fa6d"), Traits.Instances.Evocation.ID);
                                traits.Add(Guid.Parse("5deef788-c7c8-4a27-bd8c-4c8511723a68"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("0fee59e5-1552-4c39-ba2a-70255742126e"), "You fire the breath blaster, dealing 4d6 damage of the appropriate type in the appropriate area. Creatures in the area must attempt a DC 24 basic Reflex save (or Fortitude save if the damage is poison).");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = GREATER_ID,
                Name = "Breath Blaster (Greater)",
                Level = 14,
                Price = 450000,
                Hands = "2",
                Range = 40,
                Reload = 1,
                Damage = "3d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                CraftingRequirements = "The initial raw materials must include the trachea of a ritually hunted dragon or other creature with a breath weapon with the appropriate damage type and area (line or cone) for the breath blaster.",
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1481a84a-40d5-4eb0-95ec-16f1b9508867"), "It's a +2 greater striking blunderbuss.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c50980ca-00eb-47fc-a97a-b32019ef459c"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("aa19896a-b7c5-45df-9240-6de371ccd356"), Traits.Instances.Evocation.ID);
                                traits.Add(Guid.Parse("940f9c73-d512-4abc-834f-c9e67fcabfb4"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("15219b92-0f52-4aa8-93f1-89a5db329957"), "You fire the breath blaster, dealing 6d6 damage of the appropriate type in the appropriate area. Creatures in the area must attempt a DC 31 basic Reflex save (or Fortitude save if the damage is poison).");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = MAJOR_ID,
                Name = "Breath Blaster (Major)",
                Level = 18,
                Price = 2400000,
                Hands = "2",
                Range = 40, 
                Reload = 1,
                Damage = "3d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                CraftingRequirements = "The initial raw materials must include the trachea of a ritually hunted dragon or other creature with a breath weapon with the appropriate damage type and area (line or cone) for the breath blaster.",
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6e0ed117-48ec-4e59-abd9-d133c77a3cfe"), "It's a +3 greater striking blunderbuss.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4504ef58-f377-489b-8373-2a8a0602af6d"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("18f97c9e-cfbf-439c-9f44-9525fd5f01da"), Traits.Instances.Evocation.ID);
                                traits.Add(Guid.Parse("ebf1200e-d5de-49db-bdac-d0f1ce930ec3"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("41a72c2c-326a-4114-823d-e9281c381f64"), "You fire the breath blaster, dealing 10d6 damage in a 60-foot line or a 30-foot cone, chosen when it's created. Creatures in the area must attempt a DC 38 basic Reflex save (or Fortitude save if the damage is poison).");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("607444b8-7b77-4b7d-8020-55f102a0c173"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("50c106b6-dd9d-4d0a-aa2d-bfc721763ae8"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("05cd4739-4684-4e73-85af-fb8352c702a2"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("96f12ad1-4fee-49e7-b940-27369a5b6515"), Traits.Instances.Scatter.ID, "10 ft.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55cc7b8c-1208-4960-b192-014d9f7db084"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 154
            };
        }
    }
}
