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
    public class ConcealedSheath : Template
    {
        public static readonly Guid ID = Guid.Parse("68bb619b-f10d-4d94-a5a7-0cb71cc4ed69");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Concealed Sheath",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("426aa14e-ebd0-432b-b404-c2c10af93013"), "This leather sheath is large enough to hold an item of up to light Bulk and is typically used for daggers, wands, thieves' tools, and similar objects. You can affix it to the inside of a boot, under a bracer or sleeve, or in other inconspicuous locations to gain a +1 item bonus to Stealth checks and DCs to hide or conceal the item within.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("324b9eee-aaee-4540-b876-d96532795802"),
                Name = "Concealed Sheath",
                Level = 3,
                Price = 2500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("252201d7-de76-47f1-9a5b-219f1a8e68d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
