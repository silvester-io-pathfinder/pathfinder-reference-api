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
    public class Lantern : Template
    {
        public static readonly Guid ID = Guid.Parse("6c60bda0-dcce-4507-980b-370cb919c9ed");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Lantern",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("74e5c5e5-3303-4bb6-a982-281e89cd6149"), "A lantern sheds bright light and requires 1 pint of oil to function for 6 hours.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a33954b8-34d4-47bc-8a43-d7999bf649fa"),
                Name = "Hooded",
                Hands = "1",
                Level = 0,
                Price = 70,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ce17c438-2ceb-430e-99ba-f0cbacb10cf6"), "A hooded lantern sheds light in a 30-foot radius (and dim light in the next 30 feet) and is equipped with shutters, which you can close to block the light. Closing or opening the shutters takes an Interact action.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5ae2a0fc-0840-44a9-a9af-044ab1412416"),
                Name = "Bull's Eye",
                Level = 0,
                Price = 100,
                Hands = "1",
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("23a73658-0fd2-4cdd-8747-1802abdc5d0b"), "A bull's-eye lantern emits its light in a 60-foot cone (and dim light in the next 60 feet).")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cb4bae4-fcb4-49d8-b285-31bf3f49bd1e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
