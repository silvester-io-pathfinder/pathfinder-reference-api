using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class SmokedGoggles : Template
    {
        public static readonly Guid ID = Guid.Parse("b5dd12b8-a82f-46c1-8da5-9febdf8e8016");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Smoked Goggles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a657dea6-96ed-455c-8d6e-1ca69fae116d"), "These goggles use lenses made out of smoked glass to protect against creatures with gaze attacks. While wearing smoked goggles, you're always considered to be Averting your Gaze, but all creatures have concealment from you. The fact that the goggles conceal creatures is part of what grants the wearer the item's benefits. If you have a way to negate the concealment from the smoked goggles, you no longer gain the benefit, either.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a16b8f84-56ce-4d06-8ace-e25733122fe0"),
                Name = "Smoked Goggles",
                Usage = "Worn eyepiece.",
                Level = 3,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f65bdc6-ad1e-47a0-9e73-96412e44e0d6"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
