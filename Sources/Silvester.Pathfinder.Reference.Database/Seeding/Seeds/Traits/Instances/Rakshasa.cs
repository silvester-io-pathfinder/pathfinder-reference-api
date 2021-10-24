using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Rakshasa : Template
    {
        public static readonly Guid ID = Guid.Parse("a5fa9ba3-ef36-4180-a603-4bb410aaa56c");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Rakshasa",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6694f8e7-7c60-4a58-a22f-2789a65c0464"), Type = TextBlockType.Text, Text = "Reincarnations of evil souls, rakshasas are fiends that live on the Material Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8733ebb-d814-41db-9837-de1c6cbdb6fe"),
                SourceId = CoreRulebook.ID,
                Page = 347
            };
        }
    }
}
