using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Positive : Template
    {
        public static readonly Guid ID = Guid.Parse("705cbba0-bc4d-4b0f-9f76-9364bde0c6cf");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Positive",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb99bcae-abe3-40a4-9471-c7d716a99d87"), Type = TextBlockType.Text, Text = "Effects with this trait heal living creatures with positive energy, deal positive energy damage to undead, or manipulate positive energy. Planes with this trait are awash with life energy of such intensity that it can harm living creatures. Creatures with this trait are natives of the Positive Energy Plane. They can survive the basic environmental effects of the Positive Energy Plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0489a76-a744-4f21-997a-1d90b54dde65"),
                SourceId = CoreRulebook.ID,
                Page = 635
            };
        }
    }
}
