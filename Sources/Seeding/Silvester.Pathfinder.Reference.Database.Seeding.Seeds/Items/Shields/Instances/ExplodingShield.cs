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
    public class ExplodingShield : Template
    {
        public static readonly Guid ID = Guid.Parse("e1c2ad3b-e747-4c62-a155-76f32f3a1cf2");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Exploding Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("80d51eec-06f3-42f0-97ae-6d9f817020eb"), "The magic within this wooden shield (Hardness 3, HP 12, BT 6) lashes out at your foes as the shield is destroyed.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("240f2896-2f8a-475b-996f-bd62e24d9fbe"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("5ab6599f-c6c5-4a9d-b1e0-c45788230d8f"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("57707e1c-ed0f-4529-b10e-7828a14d7a76"),
                Name = "Exploding Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 5,
                BrokenThreshold = 6,
                Hardness = 3,
                HitPoints = 12,
                Price = 2500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9bf46cab-11b9-41c3-9086-8add56e51a08"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Trigger("The Exploding Shield is destroyed.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("46800e30-7a1d-4e71-b02c-d1594c2f8569"), "The shield explodes outward, dealing 4d6 piercing damage to each creature in a 15-foot cone (DC 19 basic Reflex save).");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adf30967-0538-4576-91bc-f2a0a0127fcb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 260
            };
        }
    }
}
