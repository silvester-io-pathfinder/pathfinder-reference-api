using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class DeployableCover : Template
    {
        public static readonly Guid ID = Guid.Parse("c97a3e1d-8fe3-4ce0-94d1-54cf8e8ddf6e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Deployable Cover",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ef11bc5b-a727-4789-8729-11da63900905"), "This thick mat of canvas, foliage, and wood is mounted on a tripod of flexible metal struts, folded into a batonlike shape, and clamped shut. You can rapidly deploy it on the ground with an Interact action to create cover. Deployable cover is large enough to Take Cover behind, allowing you (and others) to gain standard cover when you use the Take Cover action. Before it can be used again, deployable cover must be carefully folded and clamped shut, which takes 1 minute.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ccd164c4-3eff-4de7-91fb-de0af34d89fb"), Traits.Instances.Uncommon.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("e6bd83bc-8f54-4810-be84-f5611dab5e68"),
                Name = "Deployable Cover",
                Usage = "Held in 2 hands.",
                Level = 1,
                Price = 1500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("3fd0f198-5470-4045-94ee-faeb5ce6f5da"),
                Name = "Ballistic Cover",
                Level = 2,
                Price = 3500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("310f64d1-ff2b-426f-89ef-4e94127ee1f0"), "Specially crafted to protect against bullet fire, a ballistic cover also works against other physical projectiles, such as arrows, bolts, and thrown weapons. While a creature has cover from Taking Cover behind a ballistic cover, it gains resistance 2 to piercing damage from ranged weapons and ranged unarmed attacks.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08cf2d79-eaea-4648-a41e-98843db6deca"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 64
            };
        }
    }
}
