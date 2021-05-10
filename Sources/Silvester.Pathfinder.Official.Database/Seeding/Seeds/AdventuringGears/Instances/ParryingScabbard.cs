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
    public class ParryingScabbard : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("901f8786-d591-43a5-b8cd-8cd049434d65");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Parrying Scabbard",
                Hands = "1",
                ItemLevel = "0",
                Price = 50,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2a189668-ef0a-422a-8ff2-4e2e6ab74228"), Type = TextBlockType.Text, Text = "You can draw this reinforced sheath during the same Interact action you use to draw the weapon it holds, wielding the weapon in one hand and the scabbard in your other. A parrying scabbard can be used for your defense much like a weapon with the parry trait: you can spend an action to position it defensively, gaining a +1 circumstance bonus to AC until the start of your next turn. Parrying scabbards are available for any sword that can be wielded in one hand." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cccb7c93-4624-4aa9-99bd-62c38a80543b"),
                SourceId = CoreRulebook.ID,
                Page = 249
            };
        }
    }
}
