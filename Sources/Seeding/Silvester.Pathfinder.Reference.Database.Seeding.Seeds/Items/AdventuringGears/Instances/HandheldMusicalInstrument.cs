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
    public class HandheldMusicalInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("00629e82-1fc3-4f7f-b81e-7750bdd86840");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Handheld Musical Instrument",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ea4b6a3b-df9c-49e3-bce8-533e2c21c4de"), "Handheld instruments include bagpipes, a small set of chimes, small drums, fiddles and viols, flutes and recorders, small harps, lutes, trumpets, and similarly sized instruments. The GM might rule that an especially large handheld instrument (like a tuba) has greater Bulk.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("9dfa4e71-d869-4c4a-8adb-8d37054274e2"),
                Name = "Handheld Musical Instrument",
                Hands = "2",
                Level = 0,
                Price = 80,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3f1f65a3-9956-4a35-8ff4-15c6e6e9a97b"),
                Name = "Handheld Musical Instrument (Virtuoso)",
                Hands = "2",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                     .Text(Guid.Parse("f5f21f3a-c137-47b2-a60f-555025308570"), "A virtuoso instrument gives a +1 item bonus to Performance checks using that instrument.")
                     .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de7474cc-8673-4069-8cf5-439a5f9581db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
