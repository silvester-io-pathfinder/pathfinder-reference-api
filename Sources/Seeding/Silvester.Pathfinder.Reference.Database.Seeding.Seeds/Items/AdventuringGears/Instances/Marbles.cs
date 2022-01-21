using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Marbles : Template
    {
        public static readonly Guid ID = Guid.Parse("b6aa106f-e798-4956-8606-2f02eb027358");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Marbles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8d232801-c54c-4db2-bc91-a4007bbf5970"), "These tiny round balls are made of polished stone and colorful glass, and come in a bag of 200. You can pour marbles in an empty square adjacent to you with an Interact action. The first creature that moves into that square must succeed at a DC 13 Acrobatics check or Reflex save (its choice) or fall prone. Once a creature enters a space with marbles, enough marbles are scattered that other creatures moving into that space don't need to attempt a roll to avoid falling.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0b17c274-cc5f-46ea-87ff-e55d6a7a0599"),
                Name = "Marbles",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48bc149d-6d15-4901-8ee1-40ad62a62318"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58 
            };
        }
    }
}
