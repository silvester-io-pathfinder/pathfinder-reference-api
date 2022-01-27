using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class OnyxPanther : Template
    {
        public static readonly Guid ID = Guid.Parse("3321d430-f4fa-4e00-9f59-8b2fbe336257");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Onyx Panther",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fda5c90c-eca2-4cd9-9547-75382e38892f"), "This small stone is a stylized panther shape. When you activate it, you can move your full Speed(instead of half) during the triggering Sneak and any other time you Sneak this turn.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("dd902aa9-2148-4ea0-a64a-9e3619664120"),
                Name = "Onyx Panther",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a582b065-66ae-4867-a819-a7ea02a02959"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You use a Sneak action.")
                            .Requirements("You are trained in Stealth.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("49b1d5f9-4042-4ae8-a378-6732e1566638"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e5fa9a92-e684-4a1b-9d9c-ffca7dc52370"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("b24bfb82-58f3-446b-842d-a77a52019734"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("9573046a-f94a-463e-9d1d-730b65c33678"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56a93382-cd01-48f3-b7b2-8004b97dafc2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
