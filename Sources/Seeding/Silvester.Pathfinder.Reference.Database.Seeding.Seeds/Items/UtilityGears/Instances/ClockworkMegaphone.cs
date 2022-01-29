using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ClockworkMegaphone : Template
    {
        public static readonly Guid ID = Guid.Parse("d8713359-0b17-4f33-b12a-01b022bdae65");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Clockwork Megaphone",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fe9f649e-e96f-44dd-9fee-601916b32fa5"), "A clockwork megaphone uses cunning clockwork gears to adjust the shape and angle of the cone within the megaphone, allowing you to raise or lower the volume, widen or contract the angle in which you project your voice, or both at the same time. This makes a clockwork megaphone far more useful than an ordinary megaphone for situations where you want to make sure that everyone in a particular venue or location can hear you without being so loud that your voice comes across as a painful shout. It takes 1 minute to wind up a clockwork megaphone, which allows it to remain active for up to 1 hour of adjustments, only counting the time you change the megaphone's settings, not the time you spend speaking. Since it automatically enters standby mode when not in use, this typically means you don't have to wind up the clockwork megaphone for months, or even years, depending on how often you adjust the settings each day.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("178e0290-7e9b-457a-b0b4-de0ed2af408c"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ee925bfc-e7ea-4b7d-a39d-3c8d024b3886"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a6c9df05-e65d-43fd-bc34-d79a2b35f140"),
                Name = "Clockwork Megaphone",
                Level = 1,
                Price = 1500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8df8c7b-9555-49f1-93dc-4d1e4079656a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 87
            };
        }
    }
}
