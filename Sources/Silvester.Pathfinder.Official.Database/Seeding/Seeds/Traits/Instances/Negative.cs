using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Negative : Template
    {
        public static readonly Guid ID = Guid.Parse("6e756612-0271-492f-9be0-0d9c58827821");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Negative",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b7e8e1f-44c8-409f-8e71-23258c4d5dea"), Type = TextBlockType.Text, Text = "Effects with this trait heal undead creatures with negative energy, deal negative damage to living creatures, or manipulate negative energy. Planes with this trait are vast, empty reaches that suck the life from the living. Creatures with this trait are natives of the Negative Energy Plane. They can survive the basic environmental effects of the Negative Energy Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87244427-6cfc-4703-ac48-4c1951a0b942"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
