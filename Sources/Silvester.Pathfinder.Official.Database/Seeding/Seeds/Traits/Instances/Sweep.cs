using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Sweep : Template
    {
        public static readonly Guid ID = Guid.Parse("2189fed6-32bf-436d-9265-05a5a24eb668");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Sweep",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e72bc2c7-30f7-452e-ab94-d6fe3fea6da6"), Type = TextBlockType.Text, Text = "This weapon makes wide sweeping or spinning attacks, making it easier to attack multiple enemies. When you attack with this weapon, you gain a +1 circumstance bonus to your attack roll if you already attempted to attack a different target this turn using this weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("594571c0-dc91-40a8-910e-e7050e862fee"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
