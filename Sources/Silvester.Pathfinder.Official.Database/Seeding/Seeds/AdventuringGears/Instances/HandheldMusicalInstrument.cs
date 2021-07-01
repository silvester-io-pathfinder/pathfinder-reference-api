using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                Price = 80,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ea4b6a3b-df9c-49e3-bce8-533e2c21c4de"), Type = TextBlockType.Text, Text = "Handheld instruments include bagpipes, a small set of chimes, small drums, fiddles and viols, flutes and recorders, small harps, lutes, trumpets, and similarly sized instruments. The GM might rule that an especially large handheld instrument (like a tuba) has greater Bulk." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3f1f65a3-9956-4a35-8ff4-15c6e6e9a97b"),
                NameAddendum = "Virtuoso",
                DescriptionAddendum = "A virtuoso instrument gives a +1 item bonus to Performance checks using that instrument.",
                ItemLevel = 3,
                Price = 5000,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de7474cc-8673-4069-8cf5-439a5f9581db"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
