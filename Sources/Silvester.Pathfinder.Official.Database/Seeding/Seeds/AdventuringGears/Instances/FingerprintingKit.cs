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
    public class FingerprintingKit : Template
    {
        public static readonly Guid ID = Guid.Parse("ff7fb3c9-3f56-4260-9aa3-77bf06844661");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Fingerprinting Kit",
                Hands = "2",
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("91545dab-c971-4e6e-a899-b5910fec53a3"), Type = TextBlockType.Text, Text = "Rarely found outside of major metropolises, fingerprinting kits are a state-of-the-art, non-magical means of linking suspects to the scene of a crime." };
            yield return new TextBlock { Id = Guid.Parse("12967d10-82b4-4f9f-9a23-6f9efd9942cf"), Type = TextBlockType.Text, Text = "The kit consists of two parts. The first, a delicate brush and a jar of extremely fine dust, is used to reveal fingerprints left behind by most humanoid creatures. The dust sticks to the natural oils left behind on smooth surfaces. When you use the kit to determine whether or not creatures left behind a fingerprint at a crime scene, the GM rolls a secret Thievery check against the Thievery DC of every creature capable of leaving prints that has interacted with the scene. On a success, you locate a clear print from that creature and carefully transfer it to a special sheet of sticky paper. (Note that fingerprints can last for days, and prints collected in this manner often include those of victims, witnesses, and unrelated passersby.) At the GM's discretion, the print-leaving creature might get a bonus to its Thievery DC for taking special precautions. In other cases, finding a print might be impossible (such as if the creature was wearing gloves or if the location has been significantly compromised)." };
            yield return new TextBlock { Id = Guid.Parse("515187c9-f8ee-4fc0-9742-6180ecbad31b"), Type = TextBlockType.Text, Text = "The second part of the kit is a small sheaf of paper and a pad soaked in ink. By forcing a humanoid creature with fingerprints to roll a finger across the pad and then press it to the paper, you can obtain an image of the unique whorls in that creature's fingerprints. These can then be compared to any prints found at a crime scene. Successfully determining whether or not two prints match requires a DC 15 Perception check—the GM should roll this check secretly as well, since a failed check may result in false information." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e3d5cf6-e1ce-4c09-b686-ccd09600541a"),
                SourceId = Pathfinder157.ID,
                Page = 77
            };
        }
    }
}
