using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class FloatingShield : Template
    {
        public static readonly Guid ID = Guid.Parse("cd2d6b62-a6f8-4c64-a74b-676c5a155196");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Floating Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f236d5f2-6580-4c3f-91a5-d34061fcd5f6"), "A floating shield is usually carved with wing motifs. This buckler (Hardness 6, HP 24, BT 12) can protect you on its own.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d5313c2c-a913-461c-a3e8-a5ccc10d9b65"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5fc7eac0-c01e-4776-99b2-158477767c94"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("b9b3ee21-5a22-4221-a37a-dca000ef735f"),
                Name = "Floating Shield",
                Usage = "Strapped to 1 hand.",
                Hands = "0",
                Level = 11,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 125000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ffe392d7-440c-4144-aa7e-fa677f3ad533"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e6438eed-169d-4a9f-8385-97f7f11130d0"), "The shield magically releases itself and floats off your arm into the air next to you, granting you its bonus automatically, as if you had Raised the Shield. Because you're not wielding the shield, you can't use reactions such as Shield Block with the shield, but you gain its benefits even when using both of your hands. After 1 minute, the shield drops to the ground, ending its floating effect. While the shield is adjacent to you, you can Interact to grasp it, ending its floating effect early.");
                            });
                    })
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("c5a1182f-a8cc-4269-8a59-b9da166e8bb0"),
                Name = "Greater Floating Shield",
                Usage = "Strapped to 1 hand.",
                Hands = "0",
                Level = 16,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 900000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e15780ca-4910-4f6c-97d2-34f1a77b0283"), "You can activate the shield any number of times per day.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("97af1c59-ca8a-4db2-bc56-3b8c193e6046"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("856899ef-b760-4e8d-a513-e44afc431506"), "The shield magically releases itself and floats off your arm into the air next to you, granting you its bonus automatically, as if you had Raised the Shield. Because you're not wielding the shield, you can't use reactions such as Shield Block with the shield, but you gain its benefits even when using both of your hands. After 1 minute, the shield drops to the ground, ending its floating effect. While the shield is adjacent to you, you can Interact to grasp it, ending its floating effect early.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff45ee5a-0f1c-4e1f-923c-f2b18fad684e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
