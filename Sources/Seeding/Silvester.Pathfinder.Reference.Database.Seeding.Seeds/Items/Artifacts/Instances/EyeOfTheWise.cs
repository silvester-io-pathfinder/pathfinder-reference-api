using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class EyeOfTheWise : Template
    {
        public static readonly Guid ID = Guid.Parse("68d3579e-e06f-49d1-90d6-d414cb6b38cc");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Eye of the Wise",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dcc038e9-e37a-4dde-8500-315430bd9228"), "This fist-sized, 12-rayed black star sapphire is sacred to Yuelral, the elven goddess of magic and jewels, and most accounts of its creation attribute its crafting to a circle of her worshippers. In addition to the abilities listed below, the gem functions as a portal key for Jewelgate at Alseta's Ring.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("fe136d4b-8322-4209-bc53-24a708466313"),
                Name = "Eye of the Wise",
                Level = 11,
                Hands = 1,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                  .Add(Guid.Parse("2d1bc28d-1b4e-408d-8070-ed1e5be6f3ce"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                  {
                      action
                          .Kind("Interact")
                          .Details(effect =>
                          {
                              effect.Text(Guid.Parse("f30a0a33-3689-48ab-8ad3-c3eb38949d53"), "You touch the Eye of the Wise to a gem worth at least 10 gp, whereupon the Eye of the Wise assumes the appearance of the touched gemstone. While this connection is active, the carriers of the Eye of the Wise and of the other gemstone can communicate telepathically with one another over any distance, as long as both are on the same plane. This connection is broken if the other gemstone is damaged, if the Eye of the Wise becomes attuned to another gemstone, or if the bearer of the Eye of the Wise Dismisses the activation.");
                          });
                  })
                  .Add(Guid.Parse("9867095f-815a-487e-953a-e564ca0e34d7"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                  {
                      action
                          .Kind("Interact")
                          .Requirements("")
                          .Frequency("")
                          .Traits(traits =>
                          {
                              traits.Add(Guid.Parse("1710b2ca-a2b1-4011-a6c0-9cb91fb00579"), Traits.Instances.Divination.ID);
                              traits.Add(Guid.Parse("b71d1785-933c-4e5e-9210-9ee2e462af56"), Traits.Instances.Scrying.ID);
                          })
                          .Details(effect =>
                          {
                              effect.Text(Guid.Parse("cd759e79-e988-4d07-8f55-16e08196f23b"), "You hold the Eye of the Wise up to your own eye and peer through it. The Eye of the Wise grows transparent and grants you a +2 item bonus to attempts to Decipher Writing, Disable a Device, Identify Magic, Pick a Lock, Seek, or Sense Motive. You can Sustain this activation as long as you hold the gem in place.");
                          });
                  })
                .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3671273d-7757-4c7b-ab98-7a03d9a40872"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("50ecf9ea-5c72-4e69-a78c-2cf5de0476c9"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("28b596c6-f871-4c1d-b72d-ca7dc0f0958e"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("c7cc981c-a3bb-46ff-bd08-689aa405b991"), Traits.Instances.Invested.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("502d5295-e966-4580-866e-b218155302ad"),
                SourceId = Sources.Instances.Pathfinder147.ID,
                Page = 72
            };
        }
    }
}
