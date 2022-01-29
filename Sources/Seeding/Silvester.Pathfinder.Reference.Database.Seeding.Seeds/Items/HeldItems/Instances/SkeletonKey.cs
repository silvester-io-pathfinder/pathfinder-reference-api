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


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class SkeletonKey : Template
    {
        public static readonly Guid ID = Guid.Parse("8bb174f5-3c5c-488b-b78c-6110d89a91ad");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Skeleton Key",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4bbdfaa7-baa4-4b8f-99df-b4bfff0722d1"), "");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("883cc517-9e97-470b-9a49-94fd3c95f03a"),
                Name = "Skeleton Key",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 5,
                Price = 12500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("203bc5f9-a5f3-40d1-81c2-bdb7395d1556"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Trigger("You attempt to Pick a Lock but haven't rolled yet.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("43e3986e-9bac-43af-8e62-af3d6ac4a471"), "The key casts knock on the lock you're trying to pick.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("70228261-ea11-4007-a171-8df68556c324"),
                Name = "Skeleton Key (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 11,
                Price = 125000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5a0552d3-3ebb-48bc-a998-8091665bca13"), "The key grants a +2 item bonus, and you can activate the key once per hour.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ad519930-e2b5-43ff-bcb3-666da72750ad"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Trigger("You attempt to Pick a Lock but haven't rolled yet.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8ff7a45b-cff8-42ee-94c3-a43f504c5581"), "The key casts knock on the lock you're trying to pick.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0630cc1c-6f66-4d73-93d1-e92c5d2c9591"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6d7c9cf3-3986-46ad-ad33-fe41647bc330"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b0328df-0a39-4c3d-9058-955fd4eed638"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 575
            };
        }
    }
}
