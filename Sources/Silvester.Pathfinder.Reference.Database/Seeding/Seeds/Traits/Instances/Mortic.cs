using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Mortic : Template
    {
        public static readonly Guid ID = Guid.Parse("e394e9a5-5bab-4615-96a9-a461c712e4af");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Mortic",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8281ca2d-4f65-4414-af5d-b976e9123e46"), Type = TextBlockType.Text, Text = "Mortics are living humanoids with close ties to undeath. They have darkvision, negative healing, and vulnerabilities to sacred ground, and they can become undead by holding their breath." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5219822-d018-4963-83c0-cb1b2fee7012"),
                SourceId = Bestiary3.ID,
                Page = 309
            };
        }
    }
}
