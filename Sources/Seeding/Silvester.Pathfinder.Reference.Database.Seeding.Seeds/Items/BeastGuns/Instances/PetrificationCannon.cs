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
    public class PetrificationCannon : Template
    {
        public static readonly Guid ID = Guid.Parse("917b86ee-5e41-4b60-92bf-0e17eb633196");
        
        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Petrification Cannon",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("11a8c01f-3661-48aa-baa1-85c84745cf35"), "Built from the taxidermic body of a basilisk, a petrification cannon functions as a +2 greater striking double-barreled musket. A petrification cannon can be activated to fire a beam of energy that transforms flesh into stone.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = Guid.Parse("631366ff-3820-42fb-ad22-4cf030cefe00"),
                Name = "Petrification Cannon",
                CraftingRequirements = "The initial raw materials must include the body of a basilisk.",
                Level = 15,
                Price = 650000,
                Hands = "2",
                Range = 60,
                Reload = 1,
                Damage = "3d6",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("04fc1c95-7058-4deb-b947-d2c913198357"), "It's a +2 greater striking double-barreled musket.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0b2acfa7-c3bc-433e-8e4d-37e3953efe0a"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("d572b785-7ad9-4e3a-ad74-356c76ac526e"), Traits.Instances.Magical.ID);
                                traits.Add(Guid.Parse("69438dec-8f44-4b04-8ae7-fc7735875465"), Traits.Instances.Transmutation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("50c317e6-8391-486e-89b6-6993e35e1d45"), "A beam of coiling energy leaps from the petrification cannon at a target within 60 feet. The target must attempt a Fortitude save against DC 34 with the effects of flesh to stone.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dbd80a08-d59e-4852-8087-b0ea0b77a7fc"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("b5fb617c-677e-445c-bd2b-e7285a411f86"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("ea56445f-7f88-45b8-b7c3-8b1a40d1c309"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("e5c6828a-b24a-40a9-bf05-acdd1acc05ee"), Traits.Instances.DoubleBarrel.ID);
            builder.Add(Guid.Parse("2e7778fa-8b43-4f9c-acca-4b614e47bed5"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("420c5c02-f856-4b4d-a9ec-312a45ccfb83"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 155
            };
        }
    }
}
