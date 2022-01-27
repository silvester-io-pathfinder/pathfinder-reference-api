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
    public class MonkeyPin : Template
    {
        public static readonly Guid ID = Guid.Parse("e8b2ff74-a9f2-4e35-aa81-eae92f294a1b");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Monkey Pin",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7f4decc0-4469-4a67-8b8a-391fbb85631d"), "This small brass pin is in the shape of a monkey climbing a tree. When you activate this talisman, use a Climb action. If you succeed, you move your full Speed during the Climb. If you roll a critical failure, you get a failure instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("9fc25c0b-689d-4cd6-a4ba-02491730d16f"),
                Name = "Monkey Pin",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("89435248-d804-4dae-96c0-63fe81e8b9ba"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Climb")
                            .Requirements("You are trained in Athletics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("68f3d779-156f-4634-9aba-9fecda94f2d9"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("5044400a-03fc-4c32-843a-1632533b2987"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("d4383544-f83a-4dc7-a297-482c784b73ec"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d7f0a6c8-a1a6-4923-94d0-02a046955c4a"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdbe4096-a47f-41f6-959d-5a857262b233"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
