using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Anadi : Template
    {
        public static readonly Guid ID = Guid.Parse("ef0bc534-d48e-4fad-9348-95c5dc5ca90f");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Anadi",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e79963c4-3003-4350-821c-924049b65954"), Type = TextBlockType.Text, Text = "Anadis are peaceful, reclusive humanoids who live deep within woodlands, jungles, and other untamed areas of wilderness. Their natural forms resemble humanoid spiders covered in beautiful and distinctive markings of varying colors." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84ca49d7-d810-4757-b30d-ae2d0a543090"),
                SourceId = Pathfinder145.ID,
                Page = 84
            };
        }
    }
}
