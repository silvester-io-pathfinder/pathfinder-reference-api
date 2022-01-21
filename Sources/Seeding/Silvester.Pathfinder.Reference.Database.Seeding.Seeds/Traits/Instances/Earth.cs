using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Earth : Template
    {
        public static readonly Guid ID = Guid.Parse("813305c3-52b4-4bd1-b3ad-6b932e7af8d0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Earth",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47e26382-0112-483a-9c29-3dd391139dc2"), Type = TextBlockType.Text, Text = "Effects with the earth trait either manipulate or conjure earth. Those that manipulate earth have no effect in an area without earth. Creatures with this trait consist primarily of earth or have a magical connection to that element. Planes with this trait are mostly solid, with caverns and other hollow pockets." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a24cfb0-a6b7-45d6-b819-c398f872fdae"),
                SourceId = CoreRulebook.ID,
                Page = 631
            };
        }
    }
}
