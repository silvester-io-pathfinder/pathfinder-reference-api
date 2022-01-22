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
    public class ExplosiveAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("303f8e98-876d-44d7-bd37-a836e981fcc3");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Explosive Ammunition",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("82085290-da69-4731-b93f-e2a318870018"), "This piece of ammunition is coated in gritty black soot. ");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("947fb8af-3c96-4a60-a922-07c1974f869e"),
                Name = "Explosive Ammunition",
                Level = 9,
                Price = 13000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3fecb313-5ed7-4998-9e0e-da50ae240865"), "When activated explosive ammunition hits a target, the missile explodes in a 10-foot burst, dealing 6d6 fire damage to each creature in the area (including the target). Each creature must attempt a DC 25 basic Reflex save.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f7c644ae-89c9-435c-ab18-2c966f7d53a9"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("acd4ba8e-6242-4d60-8080-f6f6a4aa6cb1"),
                Name = "Explosive Ammunition (Greater)",
                Level = 13,
                Price = 52000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("dc5e88cc-8f4e-4d85-8a86-f76ebb7c1e58"), "When activated explosive ammunition hits a target, the missile explodes in a 10-foot burst, dealing 10d6 fire damage to each creature in the area (including the target). Each creature must attempt a DC 30 basic Reflex save.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e1e22977-0c7d-4bb8-bc8c-4f7503316ba8"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6e1da02c-559e-49da-bf6d-07f42485362d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("24a44c71-b5ae-4b49-9114-5a0d9df03c89"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("6bc856e0-3b2e-410a-83be-c951cca7cd71"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("32aa5ca3-0c5d-4a59-86d8-637ce56c3eb7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73692529-4560-47a6-988d-7e43046a44ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 559
            };
        }
    }
}
