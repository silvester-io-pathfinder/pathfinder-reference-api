using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Staff : Template
    {
        public static readonly Guid ID = Guid.Parse("64e04097-2c65-495f-8f2c-8fbff3b8123a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Staff",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6062dd69-7309-4945-b43d-7212dceb871b"), Type = TextBlockType.Text, Text = "This magic item holds spells of a particular theme and allows a spellcaster to cast additional spells by preparing the staff." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c4fa786-2d3e-4b57-bf87-5069a5c767a7"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
