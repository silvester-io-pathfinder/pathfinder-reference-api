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
    public class EmeraldGrasshopper : Template
    {
        public static readonly Guid ID = Guid.Parse("57262299-a94c-4c8c-b484-5f6f1a1ddfdb");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Emerald Grasshopper",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("20f1fff6-58d0-4baa-ac9b-d8bd91c5ae31"), "This metal grasshopper studded with emeralds is usually clasped to the legs of a suit of armor. When you activate it, if you succeed at the Athletics check, you Leap up to 50 feet vertically and up to 10 feet horizontally. If you critically succeed, you can Leap up to 75 feet vertically and 20 feet horizontally. If you don�t end your jump on solid ground, you flutter in the air until the end of your turn, then fall harmlessly at a rate of 60 feet per round until you reach the ground.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("1065ca8b-5b52-46e7-aacf-f869fbd83447"),
                Name = "Emerald Grasshopper",
                Usage = "Affixed to armor.",
                Level = 5,
                Price = 3000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f9465e8d-23df-4544-b530-96b6e5580172"), "")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("59de2813-4f47-4622-971c-20d1d8cf339a"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You attempt a High Jump but haven�t rolled yet.")
                            .Requirements("You are an expert in Athletics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e692d583-a3a7-47b0-8ef0-79a45abb3a18"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("3e21a39c-a71e-47fe-8f1c-a428cd9e6e2d"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fd15fe51-4627-4a1a-9c5f-cbb23a55e9ea"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("8dd355cc-6d90-45c9-9af4-53408fb1b5ff"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9356e6b7-be5f-4a21-b15f-b24b1d3e295d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
