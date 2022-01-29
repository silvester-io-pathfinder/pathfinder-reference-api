using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class HandwrapsOfMightyBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("07f24a76-a40a-41f8-973d-bcaa43e7808c");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Handwraps of Mighty Blows",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c01f652b-818d-408e-8fee-b9e9bc9f3246"), "As you invest these embroidered strips of cloth, you must meditate and slowly wrap them around your hands. These handwraps have weapon runes etched into them to give your unarmed attacks the benefits of those runes, making your unarmed attacks work like magic weapons. For example, +1 striking handwraps of mighty blows would give you a +1 item bonus to attack rolls with your unarmed attacks and increase the damage of your unarmed attacks from one weapon die to two (normally 2d4 instead of 1d4, but if your fists have a different weapon damage die or you have other unarmed attacks, use two of that die size instead).");
            builder.Text(Guid.Parse("872cce33-a77a-4552-a83e-88def0e0c245"), "You can upgrade, add, and transfer runes to and from the handwraps just as you would for a weapon, and you can attach talismans to the handwraps. Treat the handwraps as melee weapons of the brawling group with light Bulk for these purposes. Property runes apply only when they would be applicable to the unarmed attack you're using. For example, a property that must be applied to a slashing weapon wouldn't function when you attacked with a fist, but you would gain its benefits if you attacked with a claw or some other slashing unarmed attack.");
            builder.Text(Guid.Parse("60f74b65-26cc-454f-9ad3-9ae0152e69e5"), "The types below list the most typical combinations of fundamental runes.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3a199606-47ab-4ccb-98af-f5d420e27e19"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("0cf53e55-931f-43b7-9396-b6edddcc455b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("bbf167c4-e79e-493f-a8bd-878b849400bd"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("522695ec-d2d6-40f4-8808-9b2e99b11560"),
                Name = "Handwraps of Mighty Blows",
                Usage = "Worn gloves.",
                Level = 2,
                Price = 3500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("999c1d92-97ac-45f9-975a-1e2316e73f08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 611
            };
        }
    }
}
