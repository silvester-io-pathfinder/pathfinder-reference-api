using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields.Instances
{
    public class WoodenShield : Template
    {
        public static readonly Guid ID = Guid.Parse("0d0453b0-fa8a-4bd5-abf2-a141e9f98514");

        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID,
                Name = "Wooden Shield",
                Price = 100,
                ArmorClassBonus = 2,
                SpeedPenalty = 0,
                Hardness = 3,
                HitPoints = 12,
                BrokenThreshold = 6,
                BulkId = Bulks.Instances.OneBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c4a8e664-b25a-4c2e-8365-4e1eb47723d7"), Type = TextBlockType.Text, Text = "Though they come in a variety of shapes and sizes, the protection offered by wooden shields comes from the stoutness of their materials. While wooden shields are less expensive than steel shields, they break more easily." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e657277d-8963-4063-904b-5b051d69229f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 277
            };
        }
    }
}
