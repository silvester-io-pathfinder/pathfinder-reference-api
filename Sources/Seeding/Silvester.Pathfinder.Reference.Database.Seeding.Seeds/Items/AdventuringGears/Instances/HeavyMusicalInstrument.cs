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
    public class HeavyMusicalInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("c39b02a3-8ad1-4b2a-99c9-a141e174f52f");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Heavy Musical Instrument",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ca009fd2-28f9-4c72-9f0e-4994134aec58"), "Heavy instruments such as large drums, a full set of chimes, and keyboard instruments are less portable and generally need to be stationary while being played.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c42495e2-3766-48be-aec1-dc00ed5b0bb5"),
                Name = "Heavy Musical Instrument",
                Hands = "2",
                Level = 0,
                Price = 200,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7a695b7c-0d9e-410e-a048-912ef33e8193"),
                Name = "Heavy Musical Instrument (Virtuoso)",
                Hands = "2",
                Level = 3,
                Price = 10000,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("778131b9-66f6-4415-881d-a812a75a23a6"), "A virtuoso instrument gives a +1 item bonus to Performance checks using that instrument.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4368f848-ca6e-41d7-aa78-2fce1566d40b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
