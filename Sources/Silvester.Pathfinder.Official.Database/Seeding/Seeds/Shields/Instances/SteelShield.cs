using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields.Instances
{
    public class SteelShield : Template
    {
        public static readonly Guid ID = Guid.Parse("ea71685d-64f3-4374-815d-2710b6a1579b");

        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID,
                Name = "Steel Shield",
                Price = 200,
                ArmorClassBonus = 2,
                SpeedPenalty = 0,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                BulkId = Bulks.Instances.OneBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d6cd8f12-9dea-414e-9391-153c6bf81aeb"), Type = TextBlockType.Text, Text = "Like wooden shields, steel shields come in a variety of shapes and sizes. Though more expensive than wooden shields, they are much more durable." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5fde09c-367c-454f-ad51-7e09058d0a8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 277
            };
        }
    }
}
