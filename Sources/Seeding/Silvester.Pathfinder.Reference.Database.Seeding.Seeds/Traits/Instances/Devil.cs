using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Devil : Template
    {
        public static readonly Guid ID = Guid.Parse("5eb9c441-afc9-477d-b2de-523714bff970");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Devil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("654c8135-1ff7-4f7c-95b5-f06f93fd4cf1"), Type = TextBlockType.Text, Text = "A family of fiends from Hell, most devils are irredeemably lawful evil. They typically have greater darkvision, immunity to fire, and telepathy." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbfa40a6-0c98-4a4b-bd06-db5b4a787f82"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
