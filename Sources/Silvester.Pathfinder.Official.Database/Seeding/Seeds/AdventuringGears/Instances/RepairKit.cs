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
    public class RepairKit : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("2857c2fb-c0a6-4b9a-99f4-c6fd1c7e8f33");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Repair Kit",
                Hands = "2",
                ItemLevel = "0",
                Price = 200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("137fea30-babf-4f5e-be3f-d6fad27923f8"), Type = TextBlockType.Text, Text = "A repair kit allows you to perform simple repairs while traveling. It contains a portable anvil, tongs, woodworking tools, a whetstone, and oils for conditioning leather and wood. You can use a repair kit to Repair items using the Crafting skill. You can draw and replace a worn repair kit as part of the action that uses it." };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1a1c5a04-ce71-45ee-8576-852b35726ccf"),
                NameAddendum = "Superb",
                DescriptionAddendum = "A superb repair kit gives you a +1 item bonus to the check.",
                ItemLevel = 3,
                Price = 2500,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3ccca65-48ad-4c16-bae0-63b720548909"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
