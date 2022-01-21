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
    public class Crowbar : Template
    {
        public static readonly Guid ID = Guid.Parse("dde8580a-9312-438f-b404-125e1229dc4b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Crowbar",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("12b0241f-8698-49f6-b434-bf1f664da277"), "When Forcing Open an object that doesn't have an easy grip, a crowbar makes it easier to gain the necessary leverage. Without a crowbar, prying something open takes a –2 item penalty to the Athletics check to Force Open (similar to using a shoddy item).");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("89ad6452-ff42-4192-aafd-13013f18e850"),
                Name = "Crowbar",
                Level = 0,
                Hands = "2",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b9d16599-0d0b-4db0-97b6-86043675f8d4"),
                Name = "Crowbar (Levered)",
                Level = 3,
                Price = 2000,
                Hands = "2",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                 Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("a68644c2-3915-4a77-b125-4956f718d09a"), "A levered crowbar grants you a +1 item bonus to Athletics checks to Force Open anything that can be pried open.")
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfdfc8cd-8d4a-4d67-bf20-f095666ea579"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
