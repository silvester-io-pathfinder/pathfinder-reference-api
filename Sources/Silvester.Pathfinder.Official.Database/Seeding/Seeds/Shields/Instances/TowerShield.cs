using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields.Instances
{
    public class TowerShield : Template
    {
        public static readonly Guid ID = Guid.Parse("e1e2e623-f1b9-4ca4-b5d3-c5841769cde3");

        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID,
                Name = "Tower Shield",
                Price = 1000,
                ArmorClassBonus = 2,
                SpeedPenalty = 5,
                Hardness = 5,
                HitPoints = 20,
                BrokenThreshold = 10,
                BulkId = Bulks.Instances.FourBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8fe16bba-3ac9-44cc-bf48-ba9406064f63"), Type = TextBlockType.Text, Text = "These massive shields can be used to provide cover to nearly the entire body. Due to their size, they are typically made of wood reinforced with metal." };
            yield return new TextBlock { Id = Guid.Parse("9b600ffc-3d7d-43d1-8261-ea21bf96144f"), Type = TextBlockType.Text, Text = "When using the Take Cover action while the shield is raised, the armor class bonus becomes +4 instead of +2." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f51f3206-0e03-406f-b31b-9056baffed0a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 277
            };
        }
    }
}
