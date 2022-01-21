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
    public class BurrShield : Template
    {
        public static readonly Guid ID = Guid.Parse("76f5c7e5-4d64-4c75-8229-4cd75a97d0f3");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Burr Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7eb650cd-89ba-4c90-9fc7-cad7875fc8ec"), "This well-crafted wooden shield (Hardness 5, HP 30, BT 15) is covered in numerous seed pods with long spurs. You can Strike with these burrs as though they were +1 striking shield spikes.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("aeadef10-4fa0-498f-9529-3fbe7b6e2f24"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("38bffeee-7505-4e4f-9e6d-39a15846cbc3"), Traits.Instances.Necromancy.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("e21f11d5-5b96-405a-94da-02d285e00400"),
                Name = "Burr Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 5,
                BrokenThreshold = 15,
                Hardness = 5,
                HitPoints = 30,
                Price = 16000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("67569f41-d2cd-4050-b9ce-89b08c7f96f5"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Requirements("Your previous action was a successful Strike with the burrs.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("87cce307-fe59-402a-bb22-8448db9e4262"), " One of the burrs catches on the Strike's target, inflicting 1d10 persistent bleed damage.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00f68d95-4efd-46ef-a3bb-67be4920509b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 181
            };
        }
    }
}
