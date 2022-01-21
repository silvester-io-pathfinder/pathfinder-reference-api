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
    public class WritOfAuthenticity : Template
    {
        public static readonly Guid ID = Guid.Parse("a06f430b-4080-4d4c-bd01-d162e3aacee5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Writ of Authenticity",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f8b9c763-7c67-4231-aefd-64a32cde6ff3"), "A typical Pathfinder writ of authenticity confirms the holder's status as a member of the Pathfinder Society and their intended business. Most writs are pieces of fine parchment folded, bound with gold cord, and sealed with three wax seals. The top seal is always the Glyph of the Open Road and the middle one is the Envoy's Alliance open door emblem. The bottom seal uses the preparer's personal sigil. Inside, the text describes a specific instance of a legitimate business activity, with blanks for the Pathfinder to fill in and personalize the writ to the persons and activity desired. Presenting a writ of authenticity grants a +2 item bonus to Make a Request for the associated business, assuming the writ is legitimate and the viewer expects to work with the Pathfinder Society for that activity.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4553587d-ee5f-404f-b488-e17671d46704"),
                Name = "Writ of Authenticity",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Price = 500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f9ccda3-04d9-40cc-af70-2ac31af93981"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 26
            };
        }
    }
}
