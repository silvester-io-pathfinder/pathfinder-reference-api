using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class PaintSet : Template
    {
        public static readonly Guid ID = Guid.Parse("fcc2417a-52cb-405e-b81c-c51530adedce");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Paint Set",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ace50990-3427-4ad7-ad60-a0883243c914"), "This set of painting supplies includes paints, brushes, jars, a palette, a set of small canvases, and a miniature easel. You can refill your paint set with extra paints and canvas for 1 sp.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b3df56e4-74d7-406a-94f8-f655214fd222"),
                Name = "Paint Set",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89528769-7f19-4f51-80b5-7dff1a422b47"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 59
            };
        }
    }
}
