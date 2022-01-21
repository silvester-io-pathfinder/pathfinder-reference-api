using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class NetLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("8ab3b65d-9d60-446d-abe1-45721b45c266");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Net Launcher",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c7490c4b-15ac-4ff9-a3b6-c8592e4b06bd"), "This wide, hollow tube is two to three feet long and fires an unattached net at much greater range than one can be thrown. A net launcher can be wielded while propped up on your shoulder or cradled under your arm. A net must be carefully folded to be launched without tangling. Properly loading a net into a net launcher takes 1 minute. A net fired with a net launcher can target a Medium or smaller creature within 40 feet, rather than 20 feet.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dd710392-9d0c-43f2-8f64-9470da0f8da5"), Traits.Instances.Rare.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4ac05b93-3ee8-49a6-9a5d-ed7c53b1fa8f"),
                Name = "Net Launcher",
                Usage = "Held in 2 hands.",
                Level = 1,
                Price = 1600,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63d35936-5578-44f9-99b2-524c2f0247df"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 65
            };
        }
    }
}
