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
    public class ForceShield : Template
    {
        public static readonly Guid ID = Guid.Parse("fa88426b-a5f5-4ff8-85cc-7ed75bbdd7ef");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Force Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("362ea26e-8b93-48f8-9b2c-a1915204dc32"), "The edges of this elaborately engraved steel shield (Hardness 8, HP 32, BT 16) bear tiny glass tiles set in mosaic patterns.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d77b3547-8d10-4e6a-8518-8b3361594f01"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c3531e83-d5c4-4e0e-b7f6-3c334b225b4f"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1f010df2-251c-4fbb-b487-d4335525ad4b"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("e22d88d9-bf64-4f0b-a73f-061472b0acaf"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("fbadbbd5-8aca-4a86-9565-54b090bbc831"),
                Name = "Force Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                BrokenThreshold = 16,
                Hardness = 8,
                HitPoints = 32,
                Price = 65000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8e31c25b-d48e-478a-870e-995109f05018"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("c6ace9f2-c995-43e3-ac71-7ad76183c1a1"), "The shield surrounds you with a bubble of force that protects you from harm, granting you resistance 5 to physical damage for 1 minute. The activation ends if you cease holding the shield.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d0a45c3-4953-42d5-8e91-df6b50a18366"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
