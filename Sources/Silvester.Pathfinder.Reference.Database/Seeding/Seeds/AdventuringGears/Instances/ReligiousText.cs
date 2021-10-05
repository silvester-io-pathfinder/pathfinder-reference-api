using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class ReligiousText : Template
    {
        public static readonly Guid ID = Guid.Parse("81704384-9bf8-495f-8afd-18c68b8074b8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Religious Text",
                Hands = "1",
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("83c25aee-3ec2-46aa-bdc7-b7c122829968"), Type = TextBlockType.Text, Text = "This manuscript contains scripture of a particular religion. Some divine spellcasters, such as clerics, can use a religious text as a divine focus to use certain abilities and cast some spells. A religious text must be held in one hand to use it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb548dc0-965a-49a6-9d87-fc756f2c7c68"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
