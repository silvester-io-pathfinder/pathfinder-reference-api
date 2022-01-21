using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("83c25aee-3ec2-46aa-bdc7-b7c122829968"), "This manuscript contains scripture of a particular religion. Some divine spellcasters, such as clerics, can use a religious text as a divine focus to use certain abilities and cast some spells. A religious text must be held in one hand to use it.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("6ba7a35c-fcb1-4a91-8aa4-58fadb6a82a0"),
                Name = "Religious Text",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb548dc0-965a-49a6-9d87-fc756f2c7c68"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
