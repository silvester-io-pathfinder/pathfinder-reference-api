using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class CommunicationBangle : Template
    {
        public static readonly Guid ID = Guid.Parse("5c7c6a0d-bfc6-42b1-a265-9509e0ea7fad");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Communication Bangle",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3ab90d6b-d457-4262-9379-23a8783398b7"), "This simple brass ring is meant to be worn as an ornamentation piece to an outfit, oftentimes as a bangle on the wrist, as the ring closure of a scarf or sash, or as an ornamentation piece of a headdress. While decorative, this serves a cover for the bangle's function as a message bearer. Messages can be coded into the bangle, either through a series of raised dots and dashes or a pattern of notches of different depths and spacings. A bangle is large enough to hold a simple message consisting of a few words like “Danger. Flee.” or “Meeting. Sunset. Fountain.” Coding a message into a bangle requires 1 minute of time. All Pathfinders with access to communication bangles are taught how to code and read most basic messages, but anyone with a bangle can develop their own communication system. A creature inspecting a bangle can discover its true purpose by succeeding at a DC 20 Perception check. Deciphering a message requires a creature to succeed at a Society check against the coder's Deception DC.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("6552f269-f27a-4f1e-ab28-f5439946b469"),
                Name = "Communication Bangle",
                Level = 1,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2dea4f8-a15c-4e72-a738-99eefdb62b56"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 26
            };
        }
    }
}
