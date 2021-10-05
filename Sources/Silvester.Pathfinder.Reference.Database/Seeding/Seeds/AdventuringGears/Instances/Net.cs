using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Net : Template
    {
        public static readonly Guid ID = Guid.Parse("b9442cf7-650e-4ccc-aff0-26283af75863");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Net",
                Hands = "2",
                Price = 100,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3911900e-01f1-4550-8aff-1ef5a08e45d1"), Type = TextBlockType.Text, Text = "You can use a net either on its own or attached to a rope. When attached to a rope, you can use the net to Grapple a Medium or smaller creature up to 10 feet away (instead of only adjacent creatures). You can continue to Grapple to keep your hold on the target so long as the target remains within 10 feet and you continue to hold the net. The grabbed creature gains a +2 circumstance bonus to Escape unless you are adjacent to them, and it can attempt a DC 16 Athletics check to Force Open the net entirely. Once the target is no longer grabbed, the net is unwieldy until refolded as a Concentrate action that requires two hands; if used without being refolded, Grapple checks made with the net take a –2 penalty." };
            yield return new TextBlock { Id = Guid.Parse("23946c49-c1db-4427-a817-c957a609b2d4"), Type = TextBlockType.Text, Text = "When the net is unattached, you can attempt a ranged attack roll against a Medium or smaller creature within 20 feet. On a hit, the target is flat-footed and takes a –10- foot circumstance penalty to its Speeds until it Escapes, and on a critical hit, it's also immobilized until it Escapes. The Escape DC is 16. A creature adjacent to the target can Interact to remove the net." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa2629ff-fbdc-4153-bb24-e7a5fa321ee6"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
