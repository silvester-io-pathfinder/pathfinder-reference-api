using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Cursebound : Template
    {
        public static readonly Guid ID = Guid.Parse("1df52bcb-47c3-4b08-86c4-0f6b811ec0a1");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Cursebound",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0c9bbffe-650f-4351-bd8b-6ada698cd7a8"), Type = TextBlockType.Text, Text = "Spells with this trait increase the severity of your oracular curse when cast. Usually only revelation spells have this trait. You can't cast a cursebound spell if you don't have an oracular curse." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c40e742a-6e7d-40ee-ab61-4ceafe5e851e"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 267
            };
        }
    }
}
