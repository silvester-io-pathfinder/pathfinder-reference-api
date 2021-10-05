using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Rations : Template
    {
        public static readonly Guid ID = Guid.Parse("a11b6ffd-1981-406c-8dc4-e535f00773e1");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Rations",
                Hands = "1",
                Price = 40,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b667fbce-b973-490e-858c-eb442b49fcd5"), Type = TextBlockType.Text, Text = "Contains a week's worth of food and drink." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5bc3747-76e5-43c5-a5fe-1fd6c050ec23"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
