using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Air : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("1bd3d5af-0df2-4033-95fd-88c312902069");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Air",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("644036f9-1f76-4fea-a66f-b5ee19001d5b"), Type = TextBlockType.Text, Text = "Effects with the air trait either manipulate or conjure air. Those that manipulate air have no effect in a vacuum or an area without air. Creatures with this trait consist primarily of air or have a magical connection to that element. Planes with this trait consist mostly of open spaces and air with various degrees of turbulence, though they also contain rare islands of floating stone and other elements and energies." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b1fc9bc-e113-406a-b0d4-9dfb422fbdff"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
