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
    public class PillowShield : Template
    {
        public static readonly Guid ID = Guid.Parse("2eb52c1d-a222-4a9a-9ccb-ed56a8bec140");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Pillow Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c4a3185b-adb0-47dd-88e5-43b32d576ccd"), "The shield's blue enameled face is cool to the touch, and displays the moon's current phase at night. When you lay your head on the reverse side of this steel shield (Hardness 6, HP 36, BT 18), it becomes as pliant and supportive as the best pillows. If you complete a period of rest using the pillow shield, you can choose to transfer your recovery to the shield. Instead of recovering a number of Hit Points after resting, the shield is restored an equal number of Hit Points instead.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b7ee5649-8482-4fa4-8f9e-78d74f99b500"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0e614b5c-d525-4e28-8025-09b1895d9e87"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c90131e8-6032-42ce-b4dc-1fef2102be4c"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("55a9114c-88da-40d9-92bf-c5bee9282b67"),
                Name = "Pillow Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                BrokenThreshold = 18,
                Hardness = 6,
                HitPoints = 36,
                Price = 8000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("48ee484f-eb53-4a5a-bf60-c0934d3483c4"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7612374e-11d5-46eb-9511-04c677b18e67"), "The shield creates an area of vigilance. It casts alarm centered on itself; you decide whether it creates a mental alarm or an audible alarm. The alarm goes off at the end of the spell's duration or when triggered as normal, whichever comes first.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d5b633b-385e-417b-b70c-fa69b073d99d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 42
            };
        }
    }
}
