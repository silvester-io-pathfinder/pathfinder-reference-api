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
    public class GrowthGun : Template
    {
        public static readonly Guid ID = Guid.Parse("3bcd1b48-8d6e-47f6-9010-77a8032e0a49");
        
        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Growth Gun",
                WeaponCategoryId = WeaponCategories.Instances.Simple.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5149d36a-f7d3-4b47-8526-97312b383836"), "A growth gun is a +1 striking hand cannon made from the regenerative flesh of a hydra, troll, or other similar creature. It has an attached flesh sac that slowly replenishes one shot each round and can be loaded like a normal round of ammunition. It fires regenerating gobbets of flesh, bone, or teeth, determined by the damage type selected for its modular trait. A growth gun can be fired underwater, though it's still limited by the selected damage type as normal.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = Guid.Parse("710c9f13-bbc7-44ac-9233-81ce16328ef1"),
                CraftingRequirements = "The initial raw materials must include the flesh of a creature with regeneration.",
                Name = "Growth Gun",
                Level = 9,
                Hands = "1",
                Price = 70000,
                Range = 30,
                Reload = 1,
                Damage = "2d6",
                DamageTypeId = DamageTypes.Instances.Modular.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("73723e40-3291-43ca-b2a5-c3698890a5bf"), "It's a +1 striking hand cannon.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("90417f88-ed13-4487-a930-7617ce8a354d"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("89cb3cd5-eeff-400f-8716-d2c8c55bf7b9"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("9532b111-01f4-43cd-ac7f-83925ed1b6d8"), Traits.Instances.Transmutation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("60e157f1-ab41-46e2-b3d2-59c099df530f"), "Make a ranged Strike. On a hit, the creature becomes covered in a mass of flesh that continues to grow on the target for a brief time. The creature becomes slowed 1 for 1 round, after which the growth withers and falls off.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d8a1d26e-eca6-48b4-a65a-2d3249a65217"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a3f2d0fa-6dae-42ad-aca3-6067da9faf1e"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("665dea73-2e6d-44a3-9a9a-67a60513c022"), Traits.Instances.Modular.ID, "B, P or S");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f5bf97e-d825-4800-8fea-7853f59bbc9e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 155
            };
        }
    }
}
