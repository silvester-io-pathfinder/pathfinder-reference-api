using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class BeaconShot : Template
    {
        public static readonly Guid ID = Guid.Parse("0c6ac624-6000-47d5-934c-890f536d52c0");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Beacon Shot",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1439fa4f-1b2c-44cd-8a02-2ab6940f04b7"), "The shaft of a beacon shot is studded with tiny flecks of glimmering gemstones. When an activated beacon shot hits a target, it embeds itself into that target and spews sparks for 1 minute. If the target is invisible, it becomes merely hidden to creatures who would otherwise be unable to see it. The sparks also negate the concealed condition if the target was otherwise concealed.");
            builder.Text(Guid.Parse("9176d721-da2c-4a05-ae89-a4a1905f1823"), "A creature can remove the arrow or bolt by using an Interact basic action and succeeding at a DC 20 Athletics check.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("b693ae81-a919-498c-9d77-562b590568f4"),
                Name = "Beacon Shot",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("08b6c11b-c4c0-405e-b3a5-4f319907e8c8"), "")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("534a536a-e689-4f1e-ac2d-e96f05e6c777"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
            yield return Ammunitions.Instances.Bolts.ID;
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e03e9576-01f0-45e3-a687-48371889dff7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("94b806ce-0f07-4187-8638-5ad5d5a836a0"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ccdf5d64-8463-47c4-9db4-d34e5e04a7b2"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe923823-07a4-443a-959b-e485b4ef0d5d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 559
            };
        }
    }
}
