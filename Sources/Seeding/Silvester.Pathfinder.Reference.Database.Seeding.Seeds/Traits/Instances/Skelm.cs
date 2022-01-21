using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Skelm : Template
    {
        public static readonly Guid ID = Guid.Parse("912562bb-0c9e-400c-b254-0754b107ec8a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Skelm",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5bce8349-71fd-4481-a364-0515782a8993"), Type = TextBlockType.Text, Text = "These creatures are monstrous, wrathful misanthropes who seek to control others through anger and spite." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69136ba5-e06c-4469-aac6-500c41363918"),
                SourceId = Bestiary3.ID,
                Page = 310
            };
        }
    }
}
