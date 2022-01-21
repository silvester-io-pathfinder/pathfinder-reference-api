using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Powder : Template
    {
        public static readonly Guid ID = Guid.Parse("5bca6792-f180-4637-bf15-d477c1ffe864");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Powder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e04741c8-7bf4-4d6f-b380-a2791460ba5a"), "A bag of powder contains powdered chalk, flour, or similar materials. In addition to other uses for powder, it can be handy while adventuring to help pinpoint invisible creatures. You can throw the powder into an adjacent square as an Interact action. If there's a creature in that square, it becomes temporarily observed until the end of your turn, though the creature still has concealment due to invisibility. The powder quickly falls away or becomes invisible itself, preventing you from tracking the creature indefinitely.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4bc206d1-5cd1-44cb-befc-a68da9ccbe14"),
                Name = "Powder",
                Usage = "Held in 1 hand.",
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
                Id = Guid.Parse("731899b8-0d8b-45e8-a02d-f9b83ff00e50"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
