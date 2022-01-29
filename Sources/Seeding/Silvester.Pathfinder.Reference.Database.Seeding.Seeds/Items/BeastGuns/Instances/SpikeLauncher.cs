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
    public class SpikeLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("691b5c61-6846-4d65-94e0-6feeec10f06c");
        
        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Spike Launcher",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f986b0a5-92fd-4651-918d-0a93fd9d767f"), "Built from the spiked tail of a manticore, a spike launcher is designed to launch large, spear-like projectiles. A spike launcher is a +1 striking weapon. It's a distinct type of martial firearm that deals 1d8 piercing damage. It has the backstabber, fatal aim d12, and kickback traits with a range increment of 120 feet and reload 2. It uses the critical specialization of the bow weapon group, rather than the firearm critical specialization.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = Guid.Parse("c905204f-be3c-4239-8008-34a45218d855"),
                Name = "Spike Launcher",
                CraftingRequirements = "The initial raw materials must include the tail of a manticore.",
                Level = 6,
                Price = 25000,
                Hands = "1",
                Range = 120,
                Reload = 2,
                Damage = "2d8",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("c16580b3-3dfd-43d2-861b-aa20c86c59fc"), "It's a +1 striking weapon.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9dc3ec7f-815f-4857-9bda-41be7715d4d7"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("702f7169-abae-4e85-8479-f40a28b546d0"), Traits.Instances.Evocation.ID);
                                traits.Add(Guid.Parse("e853e2bc-6237-409d-ad2d-a087f2f85f9f"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("50d4eae1-c71a-4a79-b42f-071a2edbb0c9"), "The spike launcher fires a volley of smaller spikes in a 10-foot burst centered anywhere within its range. Make a Strike with the spike launcher against each creature in the area. On a success, the spike causes the creature to take a -5-foot status penalty to their Speed. On a critical success, the creature becomes immobilized instead. In either case, the creature, or an adjacent creature, can use an Interact action to remove the spike and end the penalty or immobilized condition.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4e962c58-9d1b-4152-ac2d-2ed52cf8f917"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("72e4ea45-29a0-4eba-a21b-ce1c21fc25fa"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2f60ed01-89c1-4736-814e-7ec00b77fe53"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("23687944-0089-424b-b390-7d157cf6667f"), Traits.Instances.Backstabber.ID);
            builder.Add(Guid.Parse("1f2f9f3f-4358-4c10-b81e-ae1228528d10"), Traits.Instances.Fatal.ID, "d12");
            builder.Add(Guid.Parse("1e5889fd-fb07-4260-b45a-028842b34b6a"), Traits.Instances.Kickback.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("906a98c1-0954-42c4-bbe6-98b424c18a09"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 156
            };
        }
    }
}
