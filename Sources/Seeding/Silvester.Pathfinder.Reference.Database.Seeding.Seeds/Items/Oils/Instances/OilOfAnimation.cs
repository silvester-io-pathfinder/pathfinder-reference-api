using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class OilOfAnimation : Template
    {
        public static readonly Guid ID = Guid.Parse("4582a412-9415-4e85-bb52-cf56bc6372f1");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Animation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a5d4cbf2-ca32-4ba1-bf24-6d8756e38d0e"), "You can rub this bronze-colored oil onto a melee weapon to grant it the benefits of the dancing rune (page 583). Once you fail a flat check for the weapon, causing it to fall, this effect ends.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("4c8de6f8-877e-42f5-9ef1-4767a4516926"),
                Name = "Oil of Animation",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 12,
                Price = 33000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("071996e0-ec31-4045-9449-2dcb1fbb376e"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a39a9d06-bec0-4227-9c9d-5fb3bc5370f0"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("736bc3f1-6aa2-4750-ba9d-b77d64e92091"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("b87417c6-6fe7-41c0-a15d-b577b9a483c6"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("315549a5-afb7-43fb-a287-b5ed3a8d1da8"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f58d9c6e-423c-4742-a16f-3b3415043d0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
