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
    public class GrapplingHook : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc78d1b-a9fb-4d45-8dd5-fe065566e23e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Grappling Hook",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("250c575e-96cb-4a61-abc9-5b431ba51640"), "You can throw a grappling hook with a rope tied to it to make a climb easier. To anchor a grappling hook, make an attack roll with the secret trait against a DC depending on the target, typically at least DC 20. On a success, your hook has a firm hold, but on a critical failure, the hook seems like it will hold but actually falls when you're partway up.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b7457f6b-e7eb-4034-9e3d-8bf3d4015617"),
                Name = "Grappling Hook",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8b95427-77bd-4a53-b96a-d3764e7ced7c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
