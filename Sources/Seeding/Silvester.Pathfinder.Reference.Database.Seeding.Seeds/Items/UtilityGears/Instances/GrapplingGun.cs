using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class GrapplingGun : Template
    {
        public static readonly Guid ID = Guid.Parse("d9f246e8-68f3-41bb-bdf9-3db4f85a9a07");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Grappling Gun",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c3d1b975-27dc-4829-8bfd-6f7d58ea600c"), "This wooden, pistol-like device features a large reel coiled with 100 feet of thin metal cord and can fire a grappling hook up to 100 feet. To reload the grappling gun, you must manually recoil the cord by turning the reel's crank, and then lock in the grappling hook. Reloading a grappling gun takes 1 minute.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("91d52770-71df-4bfb-b732-51dc25e3295d"), Traits.Instances.Uncommon.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3d85c7b3-507f-4097-aa4d-e4b835a45361"),
                Name = "Grappling Gun",
                Usage = "Held in 2 hands.",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("21bcd32f-01c5-4b72-bcc7-3c6ea23d6f7b"),
                Name = "Clockwork Grappling Gun",
                Usage = "Held in 2 hands.",
                Level = 1,
                Price = 1500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("22ba7b44-a392-479d-8256-78f44fc5a22d"), "Clockwork controls the reel on this grappling gun, reeling the grappling hook back in when you pull a lever. Reloading a clockwork grappling gun takes three Interact actions.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bee2bb6e-6408-4beb-bae5-d25ccfec2208"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 64
            };
        }
    }
}
