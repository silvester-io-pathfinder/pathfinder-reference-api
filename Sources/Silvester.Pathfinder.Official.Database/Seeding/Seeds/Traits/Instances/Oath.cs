using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Oath : Template
    {
        public static readonly Guid ID = Guid.Parse("b75b919c-afca-4f94-ad98-f20c43c182f9");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Oath",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ac87a1c-c0ef-4014-9aaa-a423ee3da851"), Type = TextBlockType.Text, Text = "Oaths add an additional tenet to your code. You can usually have only one feat with this trait." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0898317e-eac8-4f50-9db6-2d86d19956b5"),
                SourceId = CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
