using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Wraith : Template
    {
        public static readonly Guid ID = Guid.Parse("af96ac0d-bc3f-431f-80da-73fc5c10f7b6");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wraith",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3fdb0192-9dbd-4bfe-b59c-b34567d358c4"), Type = TextBlockType.Text, Text = "A wraith is an incorporeal undead creature infused with negative energy and driven by a hatred of all life" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffee5405-ec92-45ef-b9fa-97474324cb96"),
                SourceId = Bestiary.ID,
                Page = 335
            };
        }
    }
}
