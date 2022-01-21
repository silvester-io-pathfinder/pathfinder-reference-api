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
    public class BombLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("421c6f99-6714-42d5-b0a4-1df939d95d45");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Bomb Launcher",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d902ea02-b10a-4701-9772-9324a96a5011"), "This long, hollow tube is held in two hands and braced over the shoulder. Inside, it contains a small metal basket sized to hold alchemical bombs. A chute in the top delivers an alchemical bomb into the internal basket, while a lever on the underside pulls the basket back and locks it in place. Loading an alchemical bomb into a bomb launcher requires a single Interact action. With a pull of a trigger, the basket speeds forward, allowing you to Strike with the loaded alchemical bomb over long distances. Bombs fired with a bomb launcher have a range increment of 60 feet.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1146580c-4123-4e8d-a9c7-4181c290404c"), Traits.Instances.Uncommon.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("77eeb101-e9a9-485a-b75f-a8d214cd5772"),
                Name = "Bomb Launcher",
                Usage = "Held in 2 hands.",
                Level = 1,
                Price = 2000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d70338a-113c-40f7-bb2a-51b6149a1b2c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 64
            };
        }
    }
}
