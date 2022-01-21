using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FirearmCleaningKit : Template
    {
        public static readonly Guid ID = Guid.Parse("05066754-a599-448f-a4c4-bbdec521453e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Firearm Cleaning Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b1bf05de-1178-42d9-9df1-9828ba108e27"), "This kit contains cleaning cloth, oil, small steel brushes, and other minor tools necessary for proper cleaning and maintenance of a firearm. Without a firearm cleaning kit, you can't perform the necessary tasks during your daily preparations to ensure that your firearm isn't at risk of misfiring under normal use conditions.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("959bb3dc-87b8-4fe5-adf2-66314fa69a93"),
                Name = "Firearm Cleaning Kit",
                Hands = "2",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d1444d2-c4ab-4b4e-b6d0-1ef152b1e491"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 179
            };
        }
    }
}
