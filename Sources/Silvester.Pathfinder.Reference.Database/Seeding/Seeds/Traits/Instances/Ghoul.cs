using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Ghoul : Template
    {
        public static readonly Guid ID = Guid.Parse("0404e102-a30d-45b7-a539-7f54185c88ec");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Ghoul",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cfd5008-348a-4706-9412-8aa3efc01db7"), Type = TextBlockType.Text, Text = "Ghouls are vile undead creatures that feast on flesh." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f17200aa-9df5-454c-bc40-0416b1b59a98"),
                SourceId = Bestiary.ID,
                Page = 636346
            };
        }
    }
}
