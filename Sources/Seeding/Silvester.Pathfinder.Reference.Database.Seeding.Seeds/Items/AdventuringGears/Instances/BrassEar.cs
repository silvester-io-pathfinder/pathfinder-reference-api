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
    public class BrassEar : Template
    {
        public static readonly Guid ID = Guid.Parse("2f13c997-9bf3-4722-8a85-c683c9867756");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Brass Ear",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e1ddcf8f-c273-4e3d-b8ad-976bd53e0fde"), "A brass ear is a short, flared tube with one end narrow enough to comfortably fit against the ear canal. When using a brass ear to listen through a door, window, thin wall, or similar barrier, if the barrier would normally increase the DC of your Perception check to hear sounds on the other side, the DC increases by only half as much as normal.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ab1b65da-d227-4ca1-a4fc-2c328fd9e332"),
                Name = "Brass Ear",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("852b13ea-b1cc-4028-800f-fbbddaf36362"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
