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
    public class Tent : Template
    {
        public static readonly Guid ID = Guid.Parse("b0ab7469-92c8-40c9-a159-6c677814a54d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tent",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a150023c-4541-4e5b-af10-6a40a23928f6"), "Tents provide comfortable rest during the night, preventing the inhabitants from taking penalties or condition effects.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4ffc8ec2-7511-4dff-adff-c65242a40923"),
                Name = "Tent (Pup)",
                Hands = "2",
                Level = 0,
                Price = 80,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("86ae54e1-7224-41e4-9600-44bddc529657"), "A small tent that can serve as a sleeping shelter for up to two people. An additional person could fit, but would make it very uncomfortable.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5b74cfdb-989e-4ff6-b0e9-32e1685a3f9f"),
                Name = "Tent (Four-Person)",
                Hands = "2",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("38eef298-cee7-44d0-9f53-24099ba29c0f"), "A medium sized tent that can serve as a sleeping shelter for up to four people. An additional person could fit, but would make it very uncomfortable.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a38f532c-e8b5-4f20-a079-68890665c748"),
                Name = "Tent (Pavillion)",
                Hands = "2",
                Level = 2,
                Price = 4000,
                BulkId = Bulks.Instances.TwelveBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a6040d9f-340a-445e-acc7-c135b8d9c595"), "A large tent that can serve as a sleeping shelter for up to 10 people. An additional person could fit, but would make it more and more uncomfortable.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("648ef2b0-24cc-4c7f-b8f8-dd55f0a4c2d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
