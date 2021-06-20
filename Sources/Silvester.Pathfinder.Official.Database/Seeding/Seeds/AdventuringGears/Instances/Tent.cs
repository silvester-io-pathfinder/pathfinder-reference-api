using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a150023c-4541-4e5b-af10-6a40a23928f6"), Type = TextBlockType.Text, Text = "Tents provide comfortable rest during the night, preventing the inhabitants from taking penalties or condition effects." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4ffc8ec2-7511-4dff-adff-c65242a40923"),
                NameAddendum = "Pup",
                DescriptionAddendum = "A small tent that can serve as a sleeping shelter for up to two people. An additional person could fit, but would make it very uncomfortable.",
                ItemLevel = 0,
                Price = 80,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5b74cfdb-989e-4ff6-b0e9-32e1685a3f9f"),
                NameAddendum = "Four-Person",
                DescriptionAddendum = "A medium sized tent that can serve as a sleeping shelter for up to four people. An additional person could fit, but would make it very uncomfortable.",
                ItemLevel = 0,
                Price = 500,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a38f532c-e8b5-4f20-a079-68890665c748"),
                NameAddendum = "Pavillion",
                DescriptionAddendum = "A large tent that can serve as a sleeping shelter for up to 10 people. An additional person could fit, but would make it more and more uncomfortable.",
                ItemLevel = 2,
                Price = 4000,
                Hands = 2,
                BulkId = Bulks.Instances.TwelveBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("648ef2b0-24cc-4c7f-b8f8-dd55f0a4c2d8"),
                SourceId = CoreRulebook.ID,
                Page = 288
            };
        }
    }
}
