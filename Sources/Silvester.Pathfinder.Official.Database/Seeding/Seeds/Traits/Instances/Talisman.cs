using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Talisman : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("05b76c29-f5d4-4152-ae80-a94301f70c6a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Talisman",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("423a3690-e244-4d7b-9097-cc850f973820"), Type = TextBlockType.Text, Text = "A talisman is a small object affixed to armor, a shield, or a weapon (called the affixed item). You must be wielding or wearing an item to activate a talisman attached to it. Once activated, a talisman burns out permanently." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("937d3787-156c-48b0-948d-99099a321a92"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
