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
    public class PrimevalMistletoe : Template
    {
        public static readonly Guid ID = Guid.Parse("99fbb2bc-cfdb-4d0c-8972-3ed81e8daabc");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Primeval Mistletoe",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("12fb4511-bf8d-4a3d-9a1b-3305b5f25997"), "This sprig of berry-festooned holly and mistletoe doesn't wilt or rot. It can be used as a primal focus, and it also grants the creature holding it a +1 item bonus to Nature checks.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("87d153a1-df9f-48e0-872a-87426ae0ea02"),
                Name = "Primeval Mistletoe",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 23000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("352485f5-785d-4168-9131-f8edd0bc348e"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per 10 minutes.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("7591c377-e673-4c3b-b312-c399e09a7d2f"), "You squeeze juice from one of the berries and smear it onto a non-magical club or staff to cast shillelagh upon it.");
                            });
                    })
                    .Add(Guid.Parse("c67e58e3-bdf3-477f-9621-bfa3a977e3b2"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("88225d02-6aa2-4f67-bace-8a7bd56278e3"), "You twine the sprig around the wrist of one hand and touch a tree to cast tree shape upon yourself, except instead of a becoming a tree, you become a vine on the touched tree.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("b2545d64-02fd-4de1-88fd-c1b3c4f02407"),
                Name = "Primeval Mistletoe (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 14,
                Price = 390000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7b7fcf91-1b79-4104-b291-19be1da5ae73"), "The sprig grants a +2 bonus and can be activated in one additional way.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b961b61e-ce24-4dcb-949b-25d030c6c1dc"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per 10 minutes.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("9b305d77-c8c6-45ae-8afa-902e1abc2ac3"), "You squeeze juice from one of the berries and smear it onto a non-magical club or staff to cast shillelagh upon it.");
                            });
                    })
                    .Add(Guid.Parse("0f3a6da9-f77d-4688-b617-08ae95f1a1d6"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("cd57b2da-548b-4c9f-a96b-f7c55317a373"), "You twine the sprig around the wrist of one hand and touch a tree to cast tree shape upon yourself, except instead of a becoming a tree, you become a vine on the touched tree.");
                            });
                    })
                    .Add(Guid.Parse("ec32acc2-1548-47ed-92c4-cff4fb3e0865"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("a4885100-4554-4021-a6df-83d95f24d1e2"), "You plant the greater primeval mistletoe into an area of natural earth or stone. Once planted, the plant immediately sprouts into an area of holly bushes that don't impede movement and that pulse with positive energy, replicating the effects of a field of life spell. This lasts for up to 1 minute, as long as you continue to Sustain the Activation. When this magic ends, the holly bushes revert back into the original greater primeval mistletoe.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("bb58e04f-e6d4-4df1-b0c2-249df346aa50"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("f3d0d655-6136-43ad-aa34-44972d055484"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b3cc777-c953-4a80-91b7-9e78858f4927"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
