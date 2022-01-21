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
    public class DaredevilBoots : Template
    {
        public static readonly Guid ID = Guid.Parse("93dc4d23-198e-4d4f-b7bf-6a3ecf43f1ef");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Daredevil Boots",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("00f5e471-1eb3-4090-b55a-ebf87ef815d7"), "These brightly colored, soft-soled boots motivate you to perform risky stunts and grant you the agility to succeed. The boots grant you a +2 item bonus to Acrobatics checks and a +1 circumstance bonus to checks to Tumble Through an enemy�s space.");
            builder.Text(Guid.Parse("4acb28f2-f7ab-4f0b-b848-b8bd4bfc54f0"), "The boots can grip solid surfaces and help you avoid a fall, allowing you to use the Grab an Edge reaction even if your hands aren�t free. You treat falls as 10 feet shorter or, if you have the Cat Fall feat, treat your proficiency rank in Acrobatics as one degree better to determine the benefits of that feat. If you have Cat Fall and are already legendary in Acrobatics, you can choose the speed of your fall, from 60 feet per round up to normal falling speed.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("84bce9bf-69d2-4e69-ae5d-0d0196c073bd"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("7eb04ed5-d6e4-4ab5-8f51-21fb94996294"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("1b56a284-18b6-4d15-9e0f-febf4da81ad9"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("84885886-3d86-429e-800e-7fffbf1e9c2f"),
                Name = "Daredevil Boots",
                Usage = "Worn shoes.",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("c25fcb3f-1f64-42a6-8ec6-d8602e8d049f"),
                Name = "Daredevil Boots (Greater)",
                Usage = "Worn shoes.",
                Level = 17,
                Price = 1400000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6ff4b950-e60e-4f1c-8f47-e2f8e253a76a"), "The bonus to Acrobatics checks is +3, and the bonus to Tumble Through is +2. The boots can be activated.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("680692f1-e53e-4ce5-8287-85ff1d902506"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("f6dc46db-1724-4531-a169-4d05351366b9"), "The boots cast Freedom of Movement on you.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec92bf90-85e9-4592-975e-f5d2ee2a88f1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 609
            };
        }
    }
}
