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
    public class WritOfAuthenticity : Template
    {
        public static readonly Guid ID = Guid.Parse("a06f430b-4080-4d4c-bd01-d162e3aacee5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Writ of Authenticity",
                Hands = "1",
                ItemLevel = "2",
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f8b9c763-7c67-4231-aefd-64a32cde6ff3"), Type = TextBlockType.Text, Text = "A typical Pathfinder writ of authenticity confirms the holder's status as a member of the Pathfinder Society and their intended business. Most writs are pieces of fine parchment folded, bound with gold cord, and sealed with three wax seals. The top seal is always the Glyph of the Open Road and the middle one is the Envoy's Alliance open door emblem. The bottom seal uses the preparer's personal sigil. Inside, the text describes a specific instance of a legitimate business activity, with blanks for the Pathfinder to fill in and personalize the writ to the persons and activity desired. Presenting a writ of authenticity grants a +2 item bonus to Make a Request for the associated business, assuming the writ is legitimate and the viewer expects to work with the Pathfinder Society for that activity." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f9ccda3-04d9-40cc-af70-2ac31af93981"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 26
            };
        }
    }
}
