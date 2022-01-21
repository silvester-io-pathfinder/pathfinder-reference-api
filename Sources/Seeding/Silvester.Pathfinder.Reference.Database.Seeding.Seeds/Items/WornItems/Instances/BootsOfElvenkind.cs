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
    public class BootsOfElvenkind : Template
    {
        public static readonly Guid ID = Guid.Parse("c94c7fe5-5cb5-4300-a907-35b658b9c067");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Boots of Elvenkind",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5b2ba940-88cd-4919-9190-9d1646e6cfa7"), "These tall, pointed boots are made from soft, supple black or green leather and are decorated with trim and buckles of gold. When worn, the boots allow you to move more nimbly, granting you a +1 item bonus to Acrobatics checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c7316ab5-27b9-4bc1-bada-14a7b01e0f37"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("c604aeb8-7ff5-4011-8d2d-e6901efe05a8"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3e9432e2-f66f-49d9-8067-e8d03985eecd"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("4b863514-484e-427a-a35c-95d69553c8d3"),
                Name = "Boots of Elvenkind",
                Usage = "Worn shoes.",
                Level = 5,
                Price = 14500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("97d82f2d-73e8-4293-aec2-e9abed373a80"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Envision")
                             .Frequency("Once per hour.")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("383486ac-0fb9-46a4-9828-f86e94ef6e0f"), "Until the end of your turn, you ignore difficult terrain when moving on the ground. If you're wearing a cloak of elvenkind, you also gain a +5-foot status bonus to your land Speed until the end of your turn.");
                             });
                     })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("f1c5938c-4439-4644-8aef-bf29749bcc52"),
                Name = "Boots of Elvenkind (Greater)",
                Usage = "Worn shoes.",
                Level = 11,
                Price = 125000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("fe791af9-89db-4ad5-be7f-2aa057436b8b"), "The boots grant a +2 bonus. If you're also wearing a cloak of elvenkind, greater boots of elvenkind constantly grant the effects of pass without trace (DC 30) in forest environments.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("82b34898-24d1-45c8-9970-14e0169e7287"), ActionTypes.Instances.FreeAction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Envision")
                             .Frequency("Once per hour.")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("91d177b2-087b-4f11-83bf-12ffde8dba10"), "Until the end of your turn, you ignore difficult terrain when moving on the ground. If you're wearing a cloak of elvenkind, you also gain a +5-foot status bonus to your land Speed until the end of your turn.");
                             });
                     })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b57a44a2-ef45-46da-ba5b-abaaf58b193e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 606
            };
        }
    }
}
