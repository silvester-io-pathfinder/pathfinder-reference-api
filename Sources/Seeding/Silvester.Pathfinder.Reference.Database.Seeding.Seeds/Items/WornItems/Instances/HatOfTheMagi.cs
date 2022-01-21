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
    public class HatOfTheMagi : Template
    {
        public static readonly Guid ID = Guid.Parse("424cd329-9654-4d11-aeac-3149501697bf");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Hat of the Magi",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6fe9ebcb-5cd3-4af8-8d04-485ce5c525ee"), "This hat comes in many forms, such as a colorful turban or a pointy hat with a brim, and can bear symbols or runes. It grants you a +1 item bonus to Arcana checks and allows you to cast the prestidigitation cantrip as an arcane innate spell.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d2339596-9bd2-48e7-b781-0996d5e77aaa"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("790c96ae-38f8-4b80-bf79-3b35adccccbf"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("d8f8c71a-7cfc-4950-ac12-7fbd1a9bf87e"), Traits.Instances.Invested.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("6e121735-0e22-444e-ba6c-8ab06df9c27d"),
                Name = "Hat of the Magi",
                Usage = "Worn headwear.",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("34b093eb-ba5f-4d78-8bf4-bd73b77a4640"),
                Name = "Hat of the Magi (Greater)",
                Usage = "Worn headwear.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("63d6a4f7-a5b4-4478-ae43-12714693768d"), "This larger, fancier hat grants a +2 bonus and can be activated.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("66036f3a-5431-48fe-8622-eafcd5608d89"), ActionTypes.Instances.ThreeActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("a08ff5b7-df83-4746-8e4f-4ef77479391c"), "You cast a 4th-level arcane Summon Elemental spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afa888d7-e537-4003-b556-f5001856a1cb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 611
            };
        }
    }
}
