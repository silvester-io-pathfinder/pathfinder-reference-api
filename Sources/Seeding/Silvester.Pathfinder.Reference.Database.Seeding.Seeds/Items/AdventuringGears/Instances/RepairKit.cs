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
    public class RepairKit : Template
    {
        public static readonly Guid ID = Guid.Parse("2857c2fb-c0a6-4b9a-99f4-c6fd1c7e8f33");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Repair Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("137fea30-babf-4f5e-be3f-d6fad27923f8"), "A repair kit allows you to perform simple repairs while traveling. It contains a portable anvil, tongs, woodworking tools, a whetstone, and oils for conditioning leather and wood. You can use a repair kit to Repair items using the Crafting skill. You can draw and replace a worn repair kit as part of the action that uses it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("26f8adbb-4397-44cd-be85-d8e39c73563c"),
                Name = "Repair Kit",
                Hands = "2",
                Level = 0,
                Price = 200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1a1c5a04-ce71-45ee-8576-852b35726ccf"),
                Name = "Repair Kit (Superb)",
                Hands = "2",
                Level = 3,
                Price = 2500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("877bdb1b-7bea-4b52-88a2-a30f3d15146c"), "A superb repair kit gives you a +1 item bonus to the check.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3ccca65-48ad-4c16-bae0-63b720548909"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
