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
    public class Compass : Template
    {
        public static readonly Guid ID = Guid.Parse("15b26889-6851-4ce7-8387-3728a52158b5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Compass",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3970cbc1-20a2-40c0-a96e-76985d7daec4"), "A compass helps you Sense Direction or navigate, provided you're in a location with uniform magnetic fields. Without a compass, you take a –2 item penalty to these checks (similar to using a shoddy item).");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b26e72bd-acff-462a-b517-360e69a07bd0"),
                Name = "Compass",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("63c40f21-1e8c-4273-9bec-79fdbaaaa225"),
                Name = "Compass (Lensatic)",
                Hands = "1",
                Level = 3,
                Price = 2000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                     .Text(Guid.Parse("a9fd4757-099e-464a-8c9d-e6ec579d3bee"), "A lensatic compass gives you a +1 item bonus to these checks.")
                     .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c57c725-c3df-425b-9b04-9e8ab27d017b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
