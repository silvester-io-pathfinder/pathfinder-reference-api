using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Automaton : Template
    {
        public static readonly Guid ID = Guid.Parse("0ddc1b80-540b-4663-99db-b2e6d98bf72d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Automaton",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4f84ec1-16ad-4bfd-a6c1-61bfc6308a37"), Type = TextBlockType.Text, Text = "Automatons are living constructs sustained by a magical core." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfc8f8ff-cb33-4f38-a839-990c7022f212"),
                SourceId = GunsAndGears.ID,
                Page = 230
            };
        }
    }
}
