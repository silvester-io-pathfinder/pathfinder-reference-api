using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class LightWriter : Template
    {
        public static readonly Guid ID = Guid.Parse("4c9afe11-1e90-4c47-a609-904412c86b36");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Light Writer",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5049f0cd-27cf-44d3-b492-1f2e4ab6c523"), "The light writer is a cutting edge invention, first created in Absalom in late 4721, combining magic and clockwork innovation to allow its operator to create a true-to-life, monochromatic portrait of people or a scene over the course of 20 minutes of exposure. It consists of two flat metal squares, one larger than the other, connected by a tube of leather similar to that found on a bellows. The smaller square, which sits at the front of the device, has a small glass lens in the center of it. The larger square contains a specially treated metallic plate on the inside; its exterior also has both a small control stick connected via flexible wire, and a small metal tube attached to the top and pointing forward. The user presses a button onthe control stick to activate the light writer. Upon activation, magical light illuminates the tube, producing a steady light for 20 minutes. This light is captured by the lens and projected onto the metal plate, slowly creating an image of the scene in front of the lens. The plate can then be removed, allowing the image to be displayed anywhere the owner desires. The light writer is mounted on a tripod and must be perfectly still during operation to prevent any defects from appearing in the plate image. If creating a captured image of a living creature, it is equally important for that creature to remain still throughout the process, to avoid a ghostlike blurring of the final image.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ed3b0d4d-27fa-4e8f-a7a9-e40672edd34d"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("4caa8557-96bf-452b-a06b-3aef1c235818"), Traits.Instances.Clockwork.ID);
            builder.Add(Guid.Parse("2183e9f3-6432-44eb-be2c-7aac3beff694"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("43dabd1a-51e1-423f-9247-d4878941fdae"), Traits.Instances.Light.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("18f7813b-0cc3-4ce8-9b9c-419834109e5a"),
                Name = "Light Writer",
                Level = 6,
                Price = 20000,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("cede6a94-d8b6-4071-81d3-77948f37bbec"),
                Name = "Light Writer (Metal Plates)",
                Level = 6,
                Price = 30,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e31bc9f5-8e8c-4ffb-b83d-fe79356a3a4f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 88
            };
        }
    }
}
