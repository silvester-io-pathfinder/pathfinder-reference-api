using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8fe16bba-3ac9-44cc-bf48-ba9406064f63"), "These massive shields can be used to provide cover to nearly the entire body. Due to their size, they are typically made of wood reinforced with metal.");;
            builder.Text(Guid.Parse("9b600ffc-3d7d-43d1-8261-ea21bf96144f"), "When using the Take Cover action while the shield is raised, the armor class bonus becomes +4 instead of +2.");;
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("c0b4bf27-f92c-4b13-9944-e682d268fe84"),
                Name = "Steel Shield",
                Price = 1000,
                ArmorClassBonus = 2,
                SpeedPenalty = 5,
                Hardness = 5,
                Hands = "1",
                HitPoints = 20,
                BrokenThreshold = 10,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
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
