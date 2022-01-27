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
    public class FearGem : Template
    {
        public static readonly Guid ID = Guid.Parse("03a99f40-3826-4450-a816-2810e3fa70f5");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Fear Gem",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("21cf9570-94f5-40f2-a1c0-ce4539a742b8"), "Dark smoke seems to writhe within this obsidian gem. When you activate the gem, you make an Intimidating Strike, as the fighter feat (page 146).");
            builder.Text(Guid.Parse("7d455286-e1b7-4dc9-ab03-12a00a4b72bd"), "If you have the Intimidating Strike feat, increase the frightened condition value from this Intimidating Strike to frightened 2, or frightened 3 on a critical hit.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("65d67617-f17f-4a48-b47d-2b95a08e8856"),
                Name = "Fear Gem",
                Usage = "Affixed to a weapon.",
                Level = 4,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("54c9bbb0-bd02-4f36-8aad-d5378d71a546"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Intimidating Strike");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d596a873-b001-4d4d-93a2-b838a616383d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("738d3e04-bda7-4ba3-9095-5edd46e813d1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("a63f4733-a415-44ac-99f8-48c3c4fc806d"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("67c5df83-814d-442e-af10-00c658e7b83f"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("e1ed7194-c755-4a4f-8847-00fa86339258"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("7c76259a-48cb-4aa3-bfa2-301955d18ec9"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("9e26b3e4-c101-4858-9440-e86995907232"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("944d6e0f-4c64-484c-8e00-dae708af3224"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
