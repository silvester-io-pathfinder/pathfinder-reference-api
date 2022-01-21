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
    public class BracersOfMissileDeflection : Template
    {
        public static readonly Guid ID = Guid.Parse("0654e4ab-0526-4c3b-8097-f2f0fac6f2a4");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Bracers of Missile Deflection",
           
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a36a91fe-7bda-4a9b-8c36-7b56fd5fb7d5"), "These bracers are made from plates of durable mithral and gleam like the summer sun.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ff9a36c5-eb47-47ac-9402-a2f7e48cef75"), Traits.Instances.Abberration.ID);
            builder.Add(Guid.Parse("7e7e179e-985b-4843-8860-94a4982452de"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("9c5cb00a-9bcc-44dc-bdf2-1794e1a2f8c1"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("783baafd-1ca5-41fc-bf13-20112c99cf61"),
                Name = "Bracers of Missle Deflection",
                Usage = "Worn bracers.",
                Level = 3,
                Price = 5200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("7f3cdfe9-977d-496a-9b00-5225f8462bb0"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Interact")
                             .Trigger("A ranged weapon attack hits you but doesn't critically hit.")
                             .Requirements("You are aware of the attack and not flat-footed.")
                             .Frequency("Once per day.")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("3ec269ec-423f-4180-b259-b6cb78806764"), "The bracers send the missile off-course. You gain a +2 circumstance bonus to AC against the triggering attack. If this would cause the attack to be a failure, the attack misses you.");
                             });
                     })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("4a3f1e7e-126e-4db0-9e51-b1bb40127a18"),
                Name = "Bracers of Missle Deflection (Greater)",
                Usage = "Worn bracers.",
                Level = 9,
                Price = 65000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3fac6073-330d-4eed-b6ed-fba5484428a5"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Trigger("A ranged weapon attack hits you but doesn't critically hit.")
                            .Requirements("You are aware of the attack and not flat-footed.")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("2693b730-13ab-4687-825e-695159b642bf"), "The bracers send the missile off-course. You gain a +2 circumstance bonus to AC against the triggering attack. If this would cause the attack to be a failure, the attack misses you.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb7b2a47-5926-40c5-9bae-87872eaef2f2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
