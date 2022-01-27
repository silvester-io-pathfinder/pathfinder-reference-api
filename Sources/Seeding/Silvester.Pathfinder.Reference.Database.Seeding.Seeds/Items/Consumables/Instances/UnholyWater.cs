using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class UnholyWater : Template
    {
        public static readonly Guid ID = Guid.Parse("456ddd2d-6107-442f-8d61-9ae1fad40e9f");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Unholy Water",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7f3b32ea-7ae2-4bfe-b3c1-c05b9fc3718d"), "An evil deity�s malice lies within this vial of water. You activate a vial of unholy water by throwing it as a Strike. It�s a simple thrown weapon with a range increment of 20 feet. Unlike an alchemical bomb, it doesn�t add the manipulate trait to the attack made with it.");
            builder.Text(Guid.Parse("9a14c202-2986-47b3-b788-bbe296a8f542"), "Unholy water deals 1d6 evil damage and 1 evil splash damage. It damages only celestials and creatures that have a weakness to evil damage.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("bc9a4152-553a-4e75-8edd-753776401406"),
                Name = "Unholy Water",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("30e80769-0c2a-44de-8f80-cc68ba5b772c"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Strike");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1902c0c0-21d1-4380-a5b7-b12162f2acfd"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f5bb540e-6837-48f6-b290-b5ecd14ee7d3"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("3d2b90cd-8bfb-4631-94f1-4a74100c8621"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("a15c0282-ef93-4870-8058-7c1c13250cac"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e43cb5a2-2d77-4aca-8566-7c21468bcb97"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 571
            };
        }
    }
}
