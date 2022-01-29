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
    public class PhylacteryOfFaithfulness : Template
    {
        public static readonly Guid ID = Guid.Parse("ab429818-0a7e-40f5-b4de-a79e0a9739b0");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Phylactery of Faithfulness",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("16bdf4e2-b89e-4a16-a872-85d7ef62632c"), "This tiny box holds a fragment of religious scripture sacred to a particular deity. The box is worn by affixing it to a leather cord and tying it around your head just above your brow. You don't gain any benefit from the phylactery if you don't worship the affiliated deity. The phylactery grants you religious wisdom, which manifests as a +2 item bonus to Religion checks. Just before you perform an action that would be anathema to the phylactery's deity, the phylactery warns you of the potential transgression in time for you to change your mind.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7e64a8b7-f5ac-4536-866d-509ee19e86e3"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("54ab1e1f-76c8-428d-8fdd-566da3ccf128"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("1973c416-f6a6-4ccb-9e30-d84d2cdd2278"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("c04fc96e-03e6-4fda-8d20-5502799e25cc"),
                Name = "Phylactery of Faithfulness",
                CraftingRequirements = "You worship the phylactery's deity.",
                Usage = "Worn circlet.",
                Level = 9,
                Price = 68000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dfb3e958-5933-4f48-a13a-163f1f92c144"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("67a3afd1-2c49-4c5d-8dcc-8bc56b4321ca"), "You ask for guidance about a particular course of Action, gaining the effects of an augury spell.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("b59e3a6c-440d-4bab-baa5-62561153d2b9"),
                Name = "Phylactery of Faithfulness (Greater)",
                CraftingRequirements = "You worship the phylactery's deity.",
                Usage = "Worn circlet.",
                Level = 17,
                Price = 1300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("36389550-e2b5-4c1b-b772-2e1a5c014cdf"), "The phylactery grants a +3 item bonus, and you can activate it once every 30 minutes.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1825b3ef-9c60-49eb-8bb0-e4ce0f0e705b"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per 30 minutes.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("374b0ab2-1f6d-41ce-9614-4a4ba6a77f6e"), "You ask for guidance about a particular course of Action, gaining the effects of an augury spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fda4a1e7-3541-40be-80b6-5e663d79efda"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 614
            };
        }
    }
}
