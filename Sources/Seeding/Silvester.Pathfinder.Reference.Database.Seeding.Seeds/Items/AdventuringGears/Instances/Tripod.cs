using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Tripod : Template
    {
        public static readonly Guid ID = Guid.Parse("d91b1e70-29ea-4316-9f0a-b294ced87aeb");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Tripod",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("be354302-cc13-48d9-b236-fa36f3003cb3"), "Tripods are designed for use with kickback weapons, as a way for gunslingers with lower strength to accurately use these more powerful weapons by sacrificing mobility instead. They can be set up and attached to a firearm with a single Interact action using one hand, setting the tripod in your square. While this sturdy piece of engineering is in use, you don't take the -2 penalty for firing a kickback weapon, even if your Strength isn't high enough to avoid the penalty. However, you must retrieve the tripod with a single Interact action before you can move the firearm to a different position. Normally, when you're hidden or undetected, you become observed if you do anything except Hide, Sneak, or Step. However, deploying or retrieving a tripod with an Interact action doesn't automatically make you observed, so long as you don't set up or remove the tripod when it's in a spot where creatures can see the tripod itself.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c2bd71c0-4c87-4af0-a59d-81dd79b9b0c8"),
                Name = "Tripod",
                Hands = "2",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93e54e59-271a-4bab-9d92-5d447883b111"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 179
            };
        }
    }
}
