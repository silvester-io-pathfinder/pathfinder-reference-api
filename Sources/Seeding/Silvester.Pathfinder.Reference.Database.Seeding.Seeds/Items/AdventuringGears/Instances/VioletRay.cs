using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class VioletRay : Template
    {
        public static readonly Guid ID = Guid.Parse("eea288b2-2a6f-4ad8-915d-0691824b5f32");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Violet Ray",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("350033d3-0099-40cd-96bb-34c611d2e5e7"), "One of the many wondrous devices brought into the world by Stasian technology is the seemingly miraculous violet ray. Physicians claim it anything from headaches to heartburn, or nausea to deafness, all with an easy and painless treatment. The device is a glass vacuum with an insulated handle connected to a small Stasian coil. When powered, the glass tube fills with purple light and becomes warm to the touch. Pressing the tube to one's body is said to increase blood flow, eliminate toxins, and many other beneficial effects. A violet ray functions as a set of healer's tools and provides a +2 item bonus to Medicine checks to Administer First Aid, Treat Disease, Treat Poison, or Treat Wounds.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("91c5163c-be62-4a14-aa2e-097d9fa6d2a9"),
                Name = "Violet Ray",
                Usage = "Held in 2 hands.",
                Level = 12,
                Price = 189300,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cdff4f36-2c27-46fb-a604-d24ff99b8806"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7284b8f7-8421-46c8-8369-6451a44f15a9"), "You apply the violet ray to an adjacent creature and attempt to counteract the blinded, clumsy, confused, deafened, drained, enfeebled, sickened, or stupefied condition with a counteract level of 6 and a counteract modifier of +22, using the source of the condition to determine the condition's counteract level and DC. If the condition was caused by an ongoing effect and you don't remove that effect, the condition returns after 1 minute. Each use of this ability can only counteract a single condition.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f07e2a8-89d9-4879-8a16-54452f88ad3f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 83
            };
        }
    }
}
