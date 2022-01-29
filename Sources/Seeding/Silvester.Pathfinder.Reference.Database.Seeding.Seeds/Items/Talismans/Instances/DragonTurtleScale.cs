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
    public class DragonTurtleScale : Template
    {
        public static readonly Guid ID = Guid.Parse("89199127-119a-4db1-8512-92aa1e0c8a5d");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Dragon Turtle Scale",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f080b1fa-a4af-4499-ad68-5cf7cac5e496"), "This shimmering green scale is usually attached to a golden clasp or chain. When you activate the scale, for 1 minute you gain a swim Speed equal to half your land Speed.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("8fcc0b2c-e1c8-443a-8acb-462eb012f1bd"),
                Name = "Dragon Turtle Scale",
                Usage = "Affixed to armor.",
                Level = 4,
                Price = 1300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b838101d-04fa-4094-9742-2bb67c2d7668"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Requirements("you're an expert in Athletics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6f49bcfd-d782-42c0-ac69-b48169fa13df"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8367548e-4d57-4590-a23b-bc78b6f70ea9"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("04e2475f-1cdf-4870-9dd6-1a41bc7c80f3"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("35c9fad8-dc6b-4154-8b82-003c5acabf87"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30affbb9-1059-4871-bf2c-9e4e1d00afb5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
