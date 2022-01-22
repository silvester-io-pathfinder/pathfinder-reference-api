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
    public class ThuribleOfRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("9d05ed8b-eadd-4b89-9a10-363b7b4711d3");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Thurible of Revelation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("302ff701-79f6-4259-94e8-317c78929626"), "This brass censer dangles on a length of chain. Most thuribles of revelation are adorned with swirling Celestial text, though some are iron and feature Infernal or Abyssal text.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("16c1d893-a28a-4a80-b3c8-d717bb67ff4a"),
                Name = "Thurible of Revelation (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 5500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e343dadd-1783-4931-ba06-7d1ada932ba1"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Cost("Incense worth at least 5 gp.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8201ea25-00ad-4895-95ab-1572388d041a"), "You light the incense inside the censer, and it burns for 1 hour. During that time, as long you are holding the thurible, you gain a +1 item bonus to Religion checks, and any critical failure you roll when you Decipher Writing of a religious nature is a failure instead.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("f6a7c2a5-c402-4a3b-aa4d-2c40344ac494"),
                Name = "Thurible of Revelation (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("172cc758-46e0-4b19-b189-f30ccd768bcb"), "The thurible grants a +2 bonus. Once per day, when you activate the thurible, you can increase its revelations. During that activation, you can hold the thurible up to your eyes with an Interact action to gain the effects of see invisibility for 1 round by peering through the smoke.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0a2de9d0-709f-447f-b2e2-10b5698fba12"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Cost("Incense worth at least 5 gp.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("fe86ef3a-2e9b-431b-9fc9-9788b890523f"), "You light the incense inside the censer, and it burns for 1 hour. During that time, as long you are holding the thurible, you gain a +1 item bonus to Religion checks, and any critical failure you roll when you Decipher Writing of a religious nature is a failure instead.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("a247b80d-c3b5-4071-b9af-c6ebd890e771"),
                Name = "Thurible of Revelation (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 18,
                Price = 1900000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6674679e-6c7f-4864-9d25-ddfec5679b1d"), "The thurible grants a +3 bonus. The greater version shares the once-per-day enhanced revelations of the moderate version, except peering through the smoke also grants you the effects of true seeing.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7746110b-ce47-4fed-87a3-39211dced49f"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Cost("Incense worth at least 5 gp.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("75bcd5f9-12cd-4afe-9deb-5e1f076aafe7"), "You light the incense inside the censer, and it burns for 1 hour. During that time, as long you are holding the thurible, you gain a +1 item bonus to Religion checks, and any critical failure you roll when you Decipher Writing of a religious nature is a failure instead.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d92a5f32-5340-4c14-9db3-09373593db1a"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("48c9a352-a7ab-477f-a785-5b326945d7eb"), Traits.Instances.Divine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1dd7287-64da-43db-8b55-9dd3c560caab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 575
            };
        }
    }
}
