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
    public class IronCudgel : Template
    {
        public static readonly Guid ID = Guid.Parse("6c702978-3db5-446c-981c-b2c6669fce04");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Iron Cudgel",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("718101da-eeff-4d04-befa-af72e85eb681"), "This miniature club is typically affixed to a weapon by an iron chain. When you activate the cudgel, you use Brutal Finish, as the fighter feat (page 151). You must meet the normal requirements, including those of the press trait.");
            builder.Text(Guid.Parse("fd2fdb19-a97f-4e02-9f67-63d900dde8ad"), "If you have the Brutal Finish feat, add two additional weapon damage dice on a success or a failure.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("f6927f88-c5a1-4715-a68d-9933fe494cbf"),
                Name = "Iron Cudgel",
                Usage = "Affixed to a weapon.",
                Level = 14,
                Price = 90000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("aeb284d7-32f5-4283-aa52-bb65f3af5609"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Brutal Finish")
                            .Requirements("You are a master with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9b25f995-4d0a-4b24-a9d8-195917708be0"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("54de51d7-9160-4a2d-9bcf-9af6421e32dd"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b9156088-6b72-441f-a628-f3a64b466a81"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("bc03d47f-043b-4f42-9970-18d1b01cc4ce"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d95ff77d-1dff-4f91-b0c2-5de9c74aba5b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
