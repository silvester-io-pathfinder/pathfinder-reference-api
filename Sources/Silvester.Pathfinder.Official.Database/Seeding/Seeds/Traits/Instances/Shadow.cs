using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Shadow : Template
    {
        public static readonly Guid ID = Guid.Parse("3debe28a-bc99-48a5-b3e0-63305662c938");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Shadow",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9c02a2f-85a8-451e-ad36-5a43d634b568"), Type = TextBlockType.Text, Text = "This magic involves shadows or the energy of the Shadow Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("433f1466-6abf-4ac5-9dec-7d0eccb605cc"),
                SourceId = CoreRulebook.ID,
                Page = 636
            };
        }
    }
}
