using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Scrolls.Instances
{
    /*public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("b535e13c-ad8b-4299-909a-f83454c2067b");

        protected override Scroll GetScroll()
        {
            return new Scroll
            {
                Id = ID,
                Name = "",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d5e1304f-d45e-4d9b-885e-862c70643686"), " ");
        }

        protected override IEnumerable<ScrollVariant> GetScrollVariants()
        {
            yield return new ScrollVariant
            {
                Id = Guid.Parse("5baad590-9cf6-40bf-9a7e-a7b18a645c58"),
                Name = "",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = ,
                Price = ,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6bec03a0-6e69-4638-a226-faa2ab55cd0b"), "")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5975afb7-79fd-4aea-aa2c-d67fd5380a70"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b14f21f7-d2a9-4bfc-a3ff-6805d9137542"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("5e7b9b63-b215-469c-abe6-bab44607a7ab"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("614f84f3-e9bf-4290-81b9-9feedc9f2254"), Traits.Instances.Scroll.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06465e59-6617-47c2-bdf5-e30f8131dd7e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 
            };
        }
    }*/
}
