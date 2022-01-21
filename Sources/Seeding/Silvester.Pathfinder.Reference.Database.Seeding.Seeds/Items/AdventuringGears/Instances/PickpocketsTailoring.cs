using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class PickpocketsTailoring : Template
    {
        public static readonly Guid ID = Guid.Parse("6cb85bbe-4763-4eaf-a2f4-eda6e296cae7");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Pickpocket's Tailoring",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e024c9bd-8a4e-4541-a172-9f04f762cefa"), "Pickpocket's tailoring modifies an existing outfit by adding concealed interior pockets and strategically opened seams for hiding small objects inside the lining. You gain a +1 item bonus to Stealth checks to Conceal an Object of light Bulk or less in the pockets. When you get a failure (but not a critical failure, which works as normal) on a Stealth check to Conceal such an Object, observers know you're concealing an object somewhere, but they don't find the object unless they succeed at a DC 20 Perception check to locate the seams in the garment.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("dd656d24-1202-40a9-8fed-e5828fa7d1b8"),
                Name = "Pickpocket's Tailoring",
                Usage = "Sewn into clothing.",
                Level = 4,
                Price = 10000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("947cb70b-fae3-4fbe-abe2-85f2435d0dcc"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 50 
            };
        }
    }
}
