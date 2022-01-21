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
    public class Ladder : Template
    {
        public static readonly Guid ID = Guid.Parse("7769a9fc-e764-47c3-a34a-1eba746e293a");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Ladder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bd148448-e5fd-4cf8-aeba-6f6914b94f1e"), "A piece of equipment consisting of a series of bars or steps between two upright lengths of wood, metal, or rope, used for climbing up or down something.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a5de3d07-a9b7-4171-a4e2-80799a402a9c"),
                Name = "Ladder (10 ft.)",
                Hands = "2",
                Level = 0,
                Price = 3,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("244f6a18-cc4c-46cb-ba34-6c63cca7b02f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
