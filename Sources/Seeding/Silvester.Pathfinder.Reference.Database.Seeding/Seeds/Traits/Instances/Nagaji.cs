using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Nagaji : Template
    {
        public static readonly Guid ID = Guid.Parse("b8e76a80-57b7-4d40-8642-e3d0dab04347");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Nagaji",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9df4036-4b7f-4174-8a99-f0e52c318d80"), Type = TextBlockType.Text, Text = "Nagaji are brawny humanoids with scaled skin and serpentine heads, many of whom serve or respect nagas." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db5b9af4-0c03-4b40-8f0b-852adf81b71f"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
