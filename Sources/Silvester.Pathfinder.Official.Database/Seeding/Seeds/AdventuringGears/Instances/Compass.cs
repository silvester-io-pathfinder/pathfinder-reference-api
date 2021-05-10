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
    public class Compass : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("15b26889-6851-4ce7-8387-3728a52158b5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Compass",
                Hands = "1",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3970cbc1-20a2-40c0-a96e-76985d7daec4"), Type = TextBlockType.Text, Text = "A compass helps you Sense Direction or navigate, provided you're in a location with uniform magnetic fields. Without a compass, you take a –2 item penalty to these checks (similar to using a shoddy item)." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c57c725-c3df-425b-9b04-9e8ab27d017b"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
