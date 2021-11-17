using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Elemental : Template
    {
        public static readonly Guid ID = Guid.Parse("2be55e11-ce05-4acf-bc5b-f6d7b4c8b980");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Elemental",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa67a9a9-cad1-403a-9ed6-94e3e6eadd95"), Type = TextBlockType.Text, Text = "Elementals are creatures directly tied to an element and native to the Elemental Planes. Elementals don’t need to breathe." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3365c33-bc0e-4230-aa8c-9237259bcf48"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
