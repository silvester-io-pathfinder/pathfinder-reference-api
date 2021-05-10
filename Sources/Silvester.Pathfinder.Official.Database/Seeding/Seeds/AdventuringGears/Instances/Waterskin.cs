﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class Waterskin : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("7787539a-8ec2-461f-9c9a-92b7f8e090b2");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Waterskin",
                Hands = "1",
                ItemLevel = "0",
                Price = 5,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6bb4e722-12ee-4eb4-a867-b9f1861876db"), Type = TextBlockType.Text, Text = "When it’s full, a waterskin contains roughly 1 day’s worth of water for a Small or Medium creature." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6483fd5b-441a-4aba-8177-6f7dc051a114"),
                SourceId = CoreRulebook.ID,
                Page = 292
            };
        }
    }
}
