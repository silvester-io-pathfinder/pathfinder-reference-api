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
    public class MedusasScream : Template
    {
        public static readonly Guid ID = Guid.Parse("5f463925-2cf1-4dc2-b163-4d5d5b572121");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Medusa's Scream",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("35dd8628-f090-4143-8b21-c9c07d516f86"), "The ghastly visage of a slain medusa�s head stares out from this steel shield (Hardness 13, HP 52, BT 26). The shield comes with a thick leather cover to conceal the head.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f6a992bb-5527-4fca-b982-2301ca2ee34a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("10f7e9d7-a7a3-49c8-a42f-a9b9527da09c"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("49e85882-d3b9-41bf-9eb3-580cf130b5dc"),
                Name = "Medusa's Scream",
                CraftingRequirements = "The initial raw materials must include the head of a medusa.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 13,
                BrokenThreshold = 26,
                Hardness = 13,
                HitPoints = 52,
                Price = 300000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1f5c5e35-f4f0-474d-9c54-366aba2414a5"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("2512cfaf-e6eb-4af4-9e26-d9e54fbca9ff"), Traits.Instances.Visual.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("aba435de-083c-4780-a240-a04d7edc6ab1"), "You reveal the medusa's face, focusing its gaze on one creature within 30 feet. The shield casts flesh to stone with a range of 30 feet.");
                            });
                    })
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("79fac76d-7f29-43f3-9df1-8f2cff02df26"),
                Name = "Medusa's Scream (Greater)",
                CraftingRequirements = "The initial raw materials must include the head of a medusa.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                BrokenThreshold = 30,
                Hardness = 15,
                HitPoints = 60,
                Price = 900000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c977f179-99c3-4050-8e00-a1c031609887"), "A greater medusa's scream (Hardness 15, HP 60, BT 30) has a frequency of once per hour for its activation instead of once per day, and the DC is 35.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2e11e8c0-9b47-47d7-a989-f12fcae72049"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per hour.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("258b56ee-063a-4c4d-a414-563feb187a28"), Traits.Instances.Visual.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("221e27de-9996-45c3-ae18-b5f8f343c751"), "You reveal the medusa's face, focusing its gaze on one creature within 30 feet. The shield casts flesh to stone with a range of 30 feet and a DC of 35.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33f6a178-027a-4543-9ecb-3c3c42767b5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
