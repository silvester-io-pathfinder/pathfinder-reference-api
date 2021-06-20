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
    public class Crowbar : Template
    {
        public static readonly Guid ID = Guid.Parse("dde8580a-9312-438f-b404-125e1229dc4b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Crowbar",
                Hands = "2",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("12b0241f-8698-49f6-b434-bf1f664da277"), Type = TextBlockType.Text, Text = "When Forcing Open an object that doesn't have an easy grip, a crowbar makes it easier to gain the necessary leverage. Without a crowbar, prying something open takes a –2 item penalty to the Athletics check to Force Open (similar to using a shoddy item)." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b9d16599-0d0b-4db0-97b6-86043675f8d4"),
                NameAddendum = "Levered",
                DescriptionAddendum = "A levered crowbar grants you a +1 item bonus to Athletics checks to Force Open anything that can be pried open.",
                ItemLevel = 3,
                Price = 2000,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfdfc8cd-8d4a-4d67-bf20-f095666ea579"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
