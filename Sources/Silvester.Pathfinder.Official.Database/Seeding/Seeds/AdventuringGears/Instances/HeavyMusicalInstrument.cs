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
    public class HeavyMusicalInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("c39b02a3-8ad1-4b2a-99c9-a141e174f52f");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Heavy Musical Instrument",
                Hands = "2",
                ItemLevel = "0",
                Price = 200,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ca009fd2-28f9-4c72-9f0e-4994134aec58"), Type = TextBlockType.Text, Text = "Heavy instruments such as large drums, a full set of chimes, and keyboard instruments are less portable and generally need to be stationary while being played." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7a695b7c-0d9e-410e-a048-912ef33e8193"),
                NameAddendum = "Virtuoso",
                DescriptionAddendum = "A virtuoso instrument gives a +1 item bonus to Performance checks using that instrument.",
                ItemLevel = 3,
                Price = 10000,
                Hands = 2,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4368f848-ca6e-41d7-aa78-2fce1566d40b"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
