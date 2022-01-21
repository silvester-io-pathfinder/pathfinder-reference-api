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
    public class DuelistsBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("41298253-516f-438f-8793-9f47ae46bd17");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Duelist's Beacon",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("96189a55-d449-45e7-8403-10797d8fabe2"), "A spiked glove is attached to the front of this buckler (Hardness 6, HP 24, BT 12), functioning as +1 striking shield spikes. Perforations and slits line the defensive side, shining bright light through them when the item's magic is activated.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("33d319c9-686d-43df-b177-e059d71b230c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("fa564a1d-e029-4202-b505-68e001c45845"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("561c194c-3b5b-49ae-8acf-cd3008c65942"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("f0e560e5-0fb3-4537-b8a3-bc42c3c345f2"), Traits.Instances.Magical.ID);
        }
        
        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("b814c744-ede0-4d42-b717-5c93ae42fb11"),
                Name = "Duelist's Beacon",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 45000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5b20a98b-5564-4a9e-8a28-b44454da44c7"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b1a77e7a-3528-434b-bf97-e8b478f6bb95"), "You activate the shield's inner light. Attempt a melee Strike with the duelist's beacon. On a hit, the target must succeed at a DC 22 Fortitude save or be blinded for 1 round. On a critical hit, the target uses the result one degree of success worse than it rolled for its Fortitude save.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea1a7667-b79f-42ca-94d5-ed514314ddce"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 10
            };
        }
    }
}
