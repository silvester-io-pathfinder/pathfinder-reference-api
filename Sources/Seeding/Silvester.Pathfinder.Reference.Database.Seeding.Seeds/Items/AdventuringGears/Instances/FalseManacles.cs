using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FalseManacles : Template
    {
        public static readonly Guid ID = Guid.Parse("2f83877d-1461-4ea7-b630-72ab935a19de");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "False Manacles",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a267c15c-7486-4a13-af92-fc6e9d034e7b"), "These manacles are nearly indistinguishable from real manacles upon inspection, but contain a hidden release that enables a wearer who knows the location of the release to free themselves with a single Interact action. An observer who examines the manacles and succeeds at a DC 20 Perception check notices their false nature. On a critical success, the observer finds the location of the hidden catch as well.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7e5f80e4-e5f6-4731-8388-4df883d3eaf1"),
                Name = "False Manacles",
                Level = 0,
                Hands = "2",
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d46bcf6a-3a91-44fb-abe3-73ff14f8b264"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("a85f2d11-c43f-4e74-bab7-1c55152d79e5"), "A hidden release enables a wearer who knows the location of the release to free themselves with a single interact action.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b43cebe4-9433-4a80-94d1-1003b52e41c3"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 114
            };
        }
    }
}
