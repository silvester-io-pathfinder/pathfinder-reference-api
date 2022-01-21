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
    public class KrakensGuard : Template
    {
        public static readonly Guid ID = Guid.Parse("2a53ae3d-0889-4fce-87a8-13eba6a6e961");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Kraken's Guard",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cb91a345-fe90-47f2-af80-979c60574490"), "This steel shield (Hardness 16, HP 96, BT 48) is painted a mottled crimson, and it always glistens as if wet. Its crest is composed of eight appendages that curl around each other, resembling the swirling tentacles of a giant kraken. Two ferocious eyes sit in its center, gleaming with an inner light.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f00b9310-bebb-4663-9f14-90a302802f1b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("bdfb9718-3217-4df2-b059-b7b20db596c1"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("958f9607-bc74-409a-9b6c-773d3115ab81"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("951e3cd1-cf50-4042-82b4-711664886f05"),
                Name = "Kraken's Guard",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 19,
                BrokenThreshold = 48,
                Hardness = 16,
                HitPoints = 96,
                Price = 4000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7c77ecd5-aa4e-4977-8958-04d147b11da4"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Raise a Shield")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("fa2b1c12-3a51-4f17-a7fe-634017b96e09"), "You unleash the kraken's wrath. You Raise the Shield. The shield's appendages briefly extend to impossible length as they wriggle and lash out at your foes, dealing 10d10 bludgeoning damage to all enemies in a 30-foot cone (DC 41 basic Reflex save). The shield remains animated for 1 minute, during which you can use it to Grapple a creature within 10 feet of you without needing a free hand. When you use the shield to Grapple, you gain a +3 item bonus to your Athletics check.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb16854f-8bcf-4c0f-bb87-f29c040cd3ce"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 38
            };
        }
    }
}
