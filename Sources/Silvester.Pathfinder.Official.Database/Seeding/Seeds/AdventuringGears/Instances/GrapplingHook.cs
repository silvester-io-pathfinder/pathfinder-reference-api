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
    public class GrapplingHook : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc78d1b-a9fb-4d45-8dd5-fe065566e23e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Grappling Hook",
                Hands = "1",
                ItemLevel = "0",
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("250c575e-96cb-4a61-abc9-5b431ba51640"), Type = TextBlockType.Text, Text = "You can throw a grappling hook with a rope tied to it to make a climb easier. To anchor a grappling hook, make an attack roll with the secret trait against a DC depending on the target, typically at least DC 20. On a success, your hook has a firm hold, but on a critical failure, the hook seems like it will hold but actually falls when you're partway up." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8b95427-77bd-4a53-b96a-d3764e7ced7c"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
