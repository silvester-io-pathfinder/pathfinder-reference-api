using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Sahkil : Template
    {
        public static readonly Guid ID = Guid.Parse("27f056b5-b6f7-41fb-92b3-fa235dd593ca");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sahkil",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("130de427-1dc9-4b8b-aaca-c428cb551309"), Type = TextBlockType.Text, Text = "Sahkils are fiends that delight in spreading fear and unease among mortal creatures. They typically have darkvision, immunity to fear, and weakness to good." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43f54862-80e1-4250-996b-fd37cfa0e244"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 84
            };
        }
    }
}
