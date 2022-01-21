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
    public class Lock : Template
    {
        public static readonly Guid ID = Guid.Parse("93f381c5-9d0f-4b47-a652-7ae50f5d5fb5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Lock"
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("657fb33a-533a-4138-a4e1-b348704713d8"),
                Name = "Lock (Poor)",
                Hands = "2",
                Level = 0,
                Price = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1801788c-e3d1-48e0-93f6-542fc1e038c6"), "Picking a poor lock requires two successful DC 15 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("40e0eb38-8162-4562-b875-743e53276321"),
                Name = "Lock (Simple)",
                Hands = "2",
                Level = 1,
                Price = 200,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ea7ffe87-5458-4d16-b620-1bb8fb35a445"), "Picking a simple lock requires three successful DC 20 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("86ff25f4-1577-428f-b220-c271c58b8437"),
                Name = "Lock (Average)",
                Hands = "2",
                Level = 3,
                Price = 1500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("13a67ee4-35bd-4eb3-ab30-ef954ae177f3"), "Picking an average lock requires four successful DC 25 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("007d34fc-a615-4980-9e52-a48ad6380eeb"),
                Name = "Lock (Good)",
                Hands = "2",
                Level = 9,
                Price = 20000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6dff25a8-705c-45ae-b989-915935b03f44"), "Picking a good lock requires five successful DC 30 Thievery checks.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("8cc2785d-d1e9-4c35-8b60-3b9b7cc4dfcc"),
                Name = "Lock (Superior)",
                Hands = "2",
                Level = 17,
                Price = 450000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a2a79a7e-b733-432d-a3e1-df03ea95dd3a"), "Picking a superior lock requires six successful DC 40 Thievery checks.")
                    .Build()
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9b4cdbfb-ef66-4252-8abc-3333ba9be0da"), "A lock can be used to secure chests, rooms, trapdoors, hatches or other kinds of stowing fascilities.");;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a66ba719-19fd-470b-977a-06d1fceedb5f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
