using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Mummy : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("d021fa33-e35d-48f8-bd7b-08a93d446359");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mummy",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4dc31b28-1a82-4e91-a4c4-a305ece08d97"), Type = TextBlockType.Text, Text = "A mummy is an undead creature created from a preserved corpse." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("277c3e5c-2bbb-4902-83a5-bc13bd3f8e48"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
