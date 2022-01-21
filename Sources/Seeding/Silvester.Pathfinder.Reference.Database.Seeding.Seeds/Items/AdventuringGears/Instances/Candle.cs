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
    public class Candle : Template
    {
        public static readonly Guid ID = Guid.Parse("bbf20e5e-8af9-46f4-9429-b7582e34eda4");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Candle",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("128ea756-3037-4a98-9f85-e5ef0c7932e2"), "A lit candle sheds dim light in a 10-foot radius for 8 hours.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0b5c0b7d-e83b-4eba-9ca4-97f75fccbf07"),
                Name = "Candle",
                Hands = "1", 
                Level = 0,
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73b403b-3d20-410d-b9dd-7500b7d5bed6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 289  
            };
        }
    }
}
