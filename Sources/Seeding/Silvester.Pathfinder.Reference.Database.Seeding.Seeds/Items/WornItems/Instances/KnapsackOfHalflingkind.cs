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
    public class KnapsackOfHalflingkind : Template
    {
        public static readonly Guid ID = Guid.Parse("db77ee73-e447-4789-93bb-eb1519fa52f4");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Knapsack of Halflingkind"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4b1720cd-8748-45ea-89d0-74bb6e6610a3"), "This sturdy leather satchel contains three compartments fastened with large clasps. The first compartment is lined in blue satin and contains an extradimensional space equivalent to a type II bag of holding.");
            builder.Text(Guid.Parse("b62256af-b25f-4c52-9671-20ed4c93629f"), "The second compartment has no lining. You can pull forth cookware and cooking utensils from it. Once they have been used to prepare a meal, the items transform into plates and silverware, and they evaporate once the meal has been eaten, taking any leftovers with them. The cookware reappears cleaned in the compartment 1 hour later. The compartment provides only kitchenware, not any food.");
            builder.Text(Guid.Parse("2b6eccb8-0c75-483e-879a-0679bc8c6816"), "The third compartment is lined with plush purple velvet and contains berry tarts wrapped in parchment paper. A creature can unwrap and eat one tart with an Interact action to regain 2d8+4 Hit Points. The knapsack produces four tarts per day, which appear at breakfast time. Any tarts not eaten by the end of the day evaporate.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("928fdf29-6e41-46d1-af4b-341fe7f38457"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("205c2c9d-a0b6-4bd7-af68-754a906d309c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("36946c25-ca14-49fb-87a7-99fb0e3e2c55"), Traits.Instances.Extradimensional.ID);
            builder.Add(Guid.Parse("144954ef-5c26-4f14-9344-02c933e97d6f"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("a19ce4e8-1a83-4345-99c1-4bedcb556392"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("bf5fc2b0-e3d7-4e1a-bda9-36ba7b0f7d87"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("9f5fb73e-330a-4162-9048-10e816858d11"),
                Name = "Knapsack of Halflingkind",
                Usage = "Worn backpack.",
                Level = 9,
                Price = 67500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("56a2be71-112d-4392-b665-42de41e573a9"),
                Name = "Knapsack of Halflingkind (Greater)",
                Usage = "Worn backpack.",
                Level = 13,
                Price = 285000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b4597191-20ad-4f77-9280-bdbfabb9b277"), "The berry tarts each restore 4d8+8 Hit Points, and the bag has two additional compartments, each of which can be Activated with an Interact action.")
                    .Text(Guid.Parse("9802c586-97fb-4136-a0f9-bcbd2163b405"), "The fourth compartment is lined in golden velvet. Once per day, you can draw a lucky magic sling bullet from this compartment. If you attack with this sling bullet, you roll twice and use the better result on your attack roll and your damage roll. This is a fortune effect. The stone becomes non-magical if not hurled by the end of your turn. Once activated, this compartment stitches itself shut until the next day.")
                    .Text(Guid.Parse("d774d3bb-fbe3-44e9-ac6d-b12c471cdcb1"), "The bag�s fifth compartment is lined in black wool. Once per day, you can unfold this compartment into a 5-foot-diameter portal on the ground. The first person to Step into the portal from an adjacent square is teleported away. This has the same effect as an 5th-level dimension door spell, except the affected creature takes the knapsack with them. When the portal is used, or at the start of your next turn if it hasn�t been used, the compartment closes automatically and can�t be unfolded until the next day.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fda0e993-c4b9-4fb2-bcdd-3ba1194d8aae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 612
            };
        }
    }
}
