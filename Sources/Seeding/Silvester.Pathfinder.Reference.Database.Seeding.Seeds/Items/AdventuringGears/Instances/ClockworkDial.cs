using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ClockworkDial : Template
    {
        public static readonly Guid ID = Guid.Parse("9ed3bf9d-c04e-4e0b-8b24-cdd6ca326dc9");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Clockwork Dial",
            };
        }
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d79d1424-cbbc-4837-8090-7728b9ff80e6"), "This small timepiece allows you to accurately track time, useful for coordinating attacks, cooking, and all other sorts of activities, without the steadiness or care necessary to use an hourglass. As always, spell durations are too inexact to be reliably tracked, as they don't last precisely the duration listed. Protected within a brass or steel case, the clockwork mechanism of this device is turned using a small key. Most dials have a maximum duration of 1 hour, with each turn of the key adding 10 minutes to the timer, though some are crafted with longer or shorter durations and intervals. Setting the timer requires one free hand and an Interact action.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("54bdb0c3-5908-43ea-b987-f1afa5afbd32"),
                Name = "Clockwork Dial",
                Hands = "1",
                Level = 0,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aa3b1fa-c4a2-40b4-8aae-a6f6044d4744"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
