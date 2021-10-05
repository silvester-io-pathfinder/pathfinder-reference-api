using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Incapacitation : Template
    {
        public static readonly Guid ID = Guid.Parse("e3085a07-4bd0-42c7-80c3-75a714c596e8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Incapactitation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c7c1d4b-a569-4739-b631-884d86d0ef1f"), Type = TextBlockType.Text, Text = "An ability with this trait can take a character completely out of the fight or even kill them, and it’s harder to use on a more powerful character. If a spell has the incapacitation trait, any creature of more than twice the spell’s level treats the result of their check to prevent being incapacitated by the spell as one degree of success better, or the result of any check the spellcaster made to incapacitate them as one degree of success worse. If any other effect has the incapacitation trait, a creature of higher level than the item, creature, or hazard generating the effect gains the same benefits." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff5d3add-125a-4cd2-9dab-e6ac31ee2307"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
