using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Mug : Template
    {
        public static readonly Guid ID = Guid.Parse("2ac8cf6c-028f-4418-96ba-4092b85e5fa5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Mug",
                Hands = "1",
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("839dfc4c-cf39-43c7-9381-aa05b4816143"), Type = TextBlockType.Text, Text = "A mug is a type of cup typically used for drinking hot drinks, such as coffee, hot chocolate, or tea. Mugs usually have handles and hold a larger amount of fluid than other types of cup." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f65d7e8-d958-4a23-9ef2-f2b31420c231"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
