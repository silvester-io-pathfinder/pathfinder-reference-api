using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("067483c4-7d31-43f1-8faa-d57b1c9d42f9"), "This very small shield is a favorite of duelists and quick, lightly armored warriors. It's typically made of steel and strapped to your forearm. You can Raise a Shield with your buckler as long as you have that hand free or are holding a light object that's not a weapon in that hand.");
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("3a96482e-2032-4395-88c4-68e8d2649f28"),
                Name = "Buckler",
                Price = 100,
                ArmorClassBonus = 1,
                SpeedPenalty = 0,
                Hardness = 3,
                Hands = "0",
                HitPoints = 6,
                BrokenThreshold = 3,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
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
