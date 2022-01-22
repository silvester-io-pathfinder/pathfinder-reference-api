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
    public class MarvelousMedicines : Template
    {
        public static readonly Guid ID = Guid.Parse("1c5beb1a-9904-4522-ad79-90575a1ad754");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Marvelous Medicines",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2e6e6dc9-170f-4421-b867-fb3691349096"), "This set of healer�s tools contains a seemingly endless supply of bandages, herbs, and healing items of impeccable quality, granting you a +2 item bonus to Medicine checks.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("b106303e-89cf-4b9d-88ad-3caf63607ece"),
                Name = "Marvelous Medicines",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 12,
                Price = 180000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("edff3208-35ed-4c19-98fb-ea9e9639f9de"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Treat Poison")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("b0f67559-417b-41bf-9d85-68c2d2f7e516"), "You can activate the tools when you use them to Treat Poison in order to produce the effects of neutralize poison. Once these medicines have been used to treat a patient�s poison, they can�t be used again to treat the same affliction for that patient.");
                            });
                    })

                    .Add(Guid.Parse("e3c7588c-9318-4830-8968-99de600dc9f2"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Treat Disease (8 hours)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("b15abf78-1e22-43a5-b20e-7038081aca13"), "You can activate the tools when you use them to treat Disease in order to produce the effects of remove disease. Once these medicines have been used to treat a patient�s disease, they can�t be used again to treat the same affliction for that patient.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("31ec8060-e3c0-4304-87fe-791826154834"),
                Name = "Marvelous Medicines (Greater)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 18,
                Price = 1900000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("81e449c2-b171-49b9-b4bf-101476186f07"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Treat Poison")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f9322b37-9264-4e8c-9d3b-5df0d6b73662"), "You can activate the tools when you use them to Treat Poison (at 6th level) in order to produce the effects of neutralize poison. Once these medicines have been used to treat a patient�s poison, they can�t be used again to treat the same affliction for that patient.");
                            });
                    })

                    .Add(Guid.Parse("86560724-c4ab-418a-8b95-b7f7f045e915"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Treat Disease (8 hours)")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ced7ccd2-b6d5-4f3d-bb66-bc271ec5c6c4"), "You can activate the tools when you use them to treat Disease (at 6th level) in order to produce the effects of remove disease. Once these medicines have been used to treat a patient�s disease, they can�t be used again to treat the same affliction for that patient.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("72f9b276-15da-41e4-87dc-b4d934d589b0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ff4371a0-cb9b-4606-af14-78c6bf65c173"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6dc5cc51-5e63-45c0-833b-cbdd99db43f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 574
            };
        }
    }
}
