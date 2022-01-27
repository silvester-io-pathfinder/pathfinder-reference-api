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
    public class SneakyKey : Template
    {
        public static readonly Guid ID = Guid.Parse("1db9baee-8242-45f7-a4c8-06384790866d");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Sneaky Key",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3fc17b43-699c-47a3-802c-253e283c16a0"), "This small silver skeleton key can be pinned to armor or a sleeve. When you turn the key to activate it, for the next minute, if the outcome of any your attempts to Pick a Lock is a critical failure, you get a failure instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("2f02885f-749a-4e73-90fe-ed844e8daaeb"),
                Name = "Sneaky Key",
                Usage = "Affixed to armor.",
                Level = 5,
                Price = 2200,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ed68bed8-aee2-470b-93e0-898222bd0548"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Requirements("You are an expert in Thievery.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("098deb68-2c9b-4433-8d96-c131d73a6076"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("79671077-0134-4d31-86fb-d670246f27fa"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7877b99d-a763-4a17-b154-1aedcf337efc"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ca9ab237-8c66-4bb1-8794-9843da87203e"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c19ca85f-ce32-4e4b-a965-3fc01fb13cd4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
