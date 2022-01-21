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
    public class ParryingScabbard : Template
    {
        public static readonly Guid ID = Guid.Parse("901f8786-d591-43a5-b8cd-8cd049434d65");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Parrying Scabbard",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2a189668-ef0a-422a-8ff2-4e2e6ab74228"), "You can draw this reinforced sheath during the same Interact action you use to draw the weapon it holds, wielding the weapon in one hand and the scabbard in your other. A parrying scabbard can be used for your defense much like a weapon with the parry trait: you can spend an action to position it defensively, gaining a +1 circumstance bonus to AC until the start of your next turn. Parrying scabbards are available for any sword that can be wielded in one hand.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("9b836a81-2453-4365-83ad-ef49a0cfadcc"),
                Name = "Parrying Scabbard",
                Hands = "1",
                Level = 0,
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cccb7c93-4624-4aa9-99bd-62c38a80543b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 249
            };
        }
    }
}
