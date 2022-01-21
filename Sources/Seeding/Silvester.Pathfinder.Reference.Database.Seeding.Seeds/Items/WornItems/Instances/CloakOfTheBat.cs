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
    public class CloakOfTheBat : Template
    {
        public static readonly Guid ID = Guid.Parse("6c1b3c8b-96dd-4391-8f2c-cccde5814465");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Cloak of the Bat",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5551b62e-35ee-48cb-8353-083ed0ab0986"), "Sewn from several long strips of luxurious brown and black silk, this cloak grants you a +2 item bonus to Stealth checks as well as to Acrobatics checks to Maneuver in Flight. You can also use your feet to hang from any surface that can support your weight, without requiring any check, though you still must attempt Athletics checks to Climb in order to move around while inverted.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("55cbdb95-3932-42d7-baf6-01b1cfb6705f"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("22b1fa6e-7a3a-45bf-b1e9-c923d0ae0513"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c73d0bca-a767-414e-a962-432fdc1ae6e9"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("569c3abf-05b7-43e3-8c26-06a78b11dded"),
                Name = "Cloak of the Bat",
                Usage = "Worn cloak.",
                Level = 10,
                Price = 95000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3a962c51-8539-4d89-914a-dcad5723c8dd"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("8651c92b-b359-45a2-abdd-036e6f7dabff"), "You can either transform the cloak into bat-like wings that grant you a fly Speed of 30 feet for 10 minutes, or have the cloak turn you into a bat by casting a 4th-level pest form spell on you. Type cloak of the bat;");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("005982c7-9264-4fa0-b21c-5d45bb7e5103"),
                Name = "Cloak of the Bat (Greater)",
                Usage = "Worn cloak.",
                Level = 17,
                Price = 1300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("e5200718-7a7a-4881-a1a0-4eabe72f527a"), "The item bonus is +3, and you can activate the cloak any number of times per day.")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f2907e38-d580-4962-a98c-59fdc3c58afa"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("0d8070ca-5983-4e0a-9840-8614d9d4bac9"), "You can either transform the cloak into bat-like wings that grant you a fly Speed of 30 feet for 10 minutes, or have the cloak turn you into a bat by casting a 4th-level pest form spell on you. Type cloak of the bat;");
                            });
                    })
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("687db0ed-a5b3-4c25-b07d-c5cd29c72aca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 608
            };
        }
    }
}
