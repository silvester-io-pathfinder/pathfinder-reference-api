using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("128ea756-3037-4a98-9f85-e5ef0c7932e2"), Type = TextBlockType.Text, Text = "A lit candle sheds dim light in a 10-foot radius for 8 hours." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73b403b-3d20-410d-b9dd-7500b7d5bed6"),
                SourceId = CoreRulebook.ID,
                Page = 289  
            };
        }
    }
}
