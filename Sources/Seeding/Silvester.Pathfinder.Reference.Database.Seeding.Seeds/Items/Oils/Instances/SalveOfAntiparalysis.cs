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
    public class SalveOfAntiparalysis : Template
    {
        public static readonly Guid ID = Guid.Parse("5ce16952-9b51-49b2-a7ee-002d8b0fd203");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Salve of Antiparalysis",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d2904fa0-d0bd-460f-99a0-4cbc31f1b076"), "Applying this filmy salve to a creature helps it overcome magical paralysis.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("a55a38fe-afe3-4e3c-81d1-66bdda2457ba"),
                Name = "Salve of Antiparalysis",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 6,
                Price = 4000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f03f07e5-0f4e-469d-9895-db6ff4484a6c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("49f497a3-213f-42b1-98f4-801d72ae32a1"), "The creature recovers as if it were the target of a 3rd-level remove paralysis spell.");
                            });
                    })
                    .Build()
            };

            yield return new OilVariant
            {
                Id = Guid.Parse("4dec6c9c-e56a-435c-a37a-9095e9eb258d"),
                Name = "Salve of Antiparalysis (Greater)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 12,
                Price = 32500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("806a0bc3-59d0-4143-9b41-992b2fb1e8a7"), "A greater salve of antiparalysis can potentially remove petrification.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9c38e4c5-7dcf-44d8-a5b8-13e49e597021"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7c461421-9965-4433-a27b-37db75f3add2"), "The creature recovers as if it were the target of both a 6th-level remove paralysis spell and a stone to flesh spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4625df72-8314-49f6-984b-084ef9b5f4e6"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("4ab52139-c25e-415b-bd9e-a505ea9980ca"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("78d8d74c-3769-494f-9e1b-46a22705b033"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("929b0278-ff3d-4dbf-9613-1dd418b4988f"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("df8708c4-1bfe-4676-b0e2-b91f3c7ab5d2"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c24b92f9-bbbf-486a-8a02-1c6adecd084f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 562
            };
        }
    }
}
