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
    public class ShieldOfTheUnifiedLegion : Template
    {
        public static readonly Guid ID = Guid.Parse("1ad65273-93ab-46af-a936-7922a29fa568");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Shield of the Unified Legion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("439aef7f-37f0-43b0-a7a4-bc3f3a1471df"), "This high-grade orichalcum shield (Hardness 16, HP 64, and BT 32) bears a +3 major striking shield boss that cannot be removed. It gleams brightly in any light, drawing attention at all times. When you Raise this Shield, ephemeral reflections of it appear in front of each of your allies within 30 feet, granting them its +2 circumstance bonus to AC for as long as they are within 30 feet of you and your shield is raised.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("82b6af6a-d76c-4a81-b80a-490cbd2e819c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ddfd6a2a-1730-4ed2-82fd-4254c213b27e"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("dd569dde-77aa-44fc-8f59-787f7ad83ab7"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("6b39b5ca-371d-4e01-becc-8e88a1e4797d"),
                Name = "Shield of the Unified Legion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 20,
                BrokenThreshold = 32,
                Hardness = 16,
                HitPoints = 64,
                Price = 7000000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("227d740c-600c-4fa5-b2a8-1a6b6531c7cf"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per minute.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("f40f7c39-a898-4343-8754-c985a7b569d1"), Traits.Instances.Force.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("39fb7ee3-f9f3-4081-a7be-de8f3625b5d1"), "You heft the shield and thrust it forward, causing ephemeral reflections of the shield to surround you and then rush outward in a 90-foot line or 60-foot cone (your choice). Make a shield bash Strike against each enemy within the area, except that the damage dealt is force damage. Each target you hit is moved 10 feet away from you (each target you critically hit is also knocked prone). This is forced movement. These shield bashes count against your multiple attack penalty, but the penalty doesn't increase until after you have made all these attacks.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f17d779b-63f4-406d-a19e-95ccda29adc3"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 75
            };
        }
    }
}
