using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class TearsOfTheLastAzlanti : Template
    {
        public static readonly Guid ID = Guid.Parse("e18f640a-b8dc-42d2-8a31-15b2b31e6082");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Tears of the Last Azlanti",
                Destruction = "The memories and lessons that echo through the Tears of the Last Azlanti give clues about steps needed to destroy the artifact. After you have gained the power of each of the six aeon stones at least once, you are granted visions of six locations across Golarion. At each of these locations, you must replace one of the necklace's aeon stones with a dull gray aeon stone. Once the final stone is replaced, the powers of the necklace are drawn into its new stones. These stones become pieces of throneglass, and the chain and bails disintegrate.",
                Usage = "Worn necklace.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("06e94be7-eb11-4b79-853b-f2853628e951"), Type = TextBlockType.Text, Text = "This gold necklace sports six bails, each with a different aeon stone. The backside of each bail is engraved with a single ancient Azlanti rune: Patience, Remembrance, Resilience, Tenacity, Wisdom, Invention." };
            yield return new TextBlock { Id = Guid.Parse("b30711b0-b616-4073-a826-7fd886735ebb"), Type = TextBlockType.Text, Text = "While a bail is active, you recall pieces of childhood memories, brief stories and lessons spoken to you by Aroden. The knowledge imparted by each bail carries a specific power but also allows you to access the invested and resonant powers of the aeon stone in the active bail's slot as though the stone orbited your head. Each day at dawn, a new bail becomes active; roll 1d6 to determine which bail is active, determined by the table below. Only one bail can be active at any time." };
            yield return new TextBlock { Id = Guid.Parse("a6ed4e2f-1f38-4528-a041-00604b98d9d2"), Type = TextBlockType.Text, Text = "Once per day, you can attempt to exchange the aeon stone in a given bail for another aeon stone with a successful DC 35 Arcana check." };
            yield return new TextBlock { Id = Guid.Parse("004c6bf1-53e1-4ded-baea-5d25d2d035b8"), Type = TextBlockType.Heading, Text = "1 - Patience - Gold Nodule" };
            yield return new TextBlock { Id = Guid.Parse("03d6a790-e939-4e54-b8b5-47fa7bb37e16"), Type = TextBlockType.Text, Text = "Active Power: Telepathy with a range of 100 feet." };
            yield return new TextBlock { Id = Guid.Parse("d0b46ed6-b4e3-43dc-84b6-540404d2be0b"), Type = TextBlockType.Heading, Text = "2 - Remembrance - Tourmaline Sphere" };
            yield return new TextBlock { Id = Guid.Parse("9276c353-5fab-46da-b1bd-4aba3d42b668"), Type = TextBlockType.Text, Text = "Active Power: Cast hypercognition at will." };
            yield return new TextBlock { Id = Guid.Parse("19d49425-1575-403b-9b66-ac0c216116bd"), Type = TextBlockType.Heading, Text = "3 - Resillience - Clear Spindle" };
            yield return new TextBlock { Id = Guid.Parse("e527d499-a44d-4525-a3fe-05fa34d5b4bb"), Type = TextBlockType.Text, Text = "Active Power: Worn armor gains the antimagic property rune." };
            yield return new TextBlock { Id = Guid.Parse("ef1730fe-0a53-45fc-b05e-1fd58b322ebd"), Type = TextBlockType.Heading, Text = "4 - Tenacity - Pink Rhomboid" };
            yield return new TextBlock { Id = Guid.Parse("b9c581cf-1675-4e79-9462-9124a9411acd"), Type = TextBlockType.Text, Text = "Active Power: Wielded weapons gain the vorpal property rune." };
            yield return new TextBlock { Id = Guid.Parse("b9a020ed-856c-4dfa-ac67-63fe48b2fa20"), Type = TextBlockType.Heading, Text = "5 - Wisdom - Orange Prism" };
            yield return new TextBlock { Id = Guid.Parse("9d6f43f2-8b54-4098-9a2f-c5710fcffbd2"), Type = TextBlockType.Text, Text = "Active Power: SKill checks for downtime activities or to Recall Knowledge are one degree of success higher." };
            yield return new TextBlock { Id = Guid.Parse("fa58cbc0-ac62-47c4-a059-4849a4bf2caa"), Type = TextBlockType.Heading, Text = "6 - Invention - Lavender and Green Ellipsoid" };
            yield return new TextBlock { Id = Guid.Parse("daf80aec-92da-40cb-8e51-2045bf1220c8"), Type = TextBlockType.Text, Text = "Active Power: You can craft items up to 5 levels higher than your actual level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Arcane.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Invested.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62d933e1-eaeb-42f7-aa5a-0d33584a234d"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 69
            };
        }
    }
}
