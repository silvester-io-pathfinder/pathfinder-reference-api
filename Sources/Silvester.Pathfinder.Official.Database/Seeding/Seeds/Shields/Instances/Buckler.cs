using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields.Instances
{
    public class Buckler : Template
    {
        public static readonly Guid ID = Guid.Parse("1baaf531-78b3-4cde-ad0c-225dae0e7891");

        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID,
                Name = "Buckler",
                Price = 100,
                ArmorClassBonus = 1,
                SpeedPenalty = 0,
                Hardness = 3,
                HitPoints = 6,
                BrokenThreshold = 3,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("067483c4-7d31-43f1-8faa-d57b1c9d42f9"), Type = TextBlockType.Text, Text = "This very small shield is a favorite of duelists and quick, lightly armored warriors. It’s typically made of steel and strapped to your forearm. You can Raise a Shield with your buckler as long as you have that hand free or are holding a light object that’s not a weapon in that hand." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a8df412-a2ab-4426-9aad-904ff92ac3c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 277
            };
        }
    }
}
