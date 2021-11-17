using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Chest : Template
    {
        public static readonly Guid ID = Guid.Parse("02af87d2-7224-4e7b-8b77-f10fec77b4e9");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Chest",
                Hands = "2",
                Price = 60,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("71f0bd1c-87f2-4c78-8d78-95e05d085bbe"), Type = TextBlockType.Text, Text = "A wooden chest can hold up to 8 Bulk of items." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b3f0c24-5127-45fc-8685-39cf0c715f74"),
                SourceId = CoreRulebook.ID,
                Page = 289
            };
        }
    }
}
