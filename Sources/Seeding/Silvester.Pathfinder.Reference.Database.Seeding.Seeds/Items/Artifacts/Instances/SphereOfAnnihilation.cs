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
    public class SphereOfAnnihilation : Template
    {
        public static readonly Guid ID = Guid.Parse("9df2074a-c20d-4472-be2d-4e4db1e267a1");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Sphere of Annihilation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d8d3fb9a-9cae-4afc-8c95-576384d00feb"), "A sphere of annihilation is a floating black sphere that pulls any matter that comes into contact with it into a void, destroying it utterly. Anything or anyone destroyed by the sphere can be brought back only by a deity's direct intervention. The sphere can't be counteracted by dispel magic or similar effects.");;
            builder.Text(Guid.Parse("476e6b56-f4f4-49b1-ab4c-8cca9971ce19"), "The sphere stays entirely still until caused to move by a creature controlling it. Taking control of the sphere requires succeeding at an attempt to activate it. A talisman of the sphere makes it easier to control the sphere.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("c1f8a19d-ce21-4a33-91bc-40f701dde2f3"),
                Name = "Sphere of Annihilation",
                Destruction = "When a gate spell is cast such that its rift overlaps a sphere of annihilation, roll d%. On a result of 1–50, the sphere is destroyed; on a 51–85, the spell is disrupted; and on a 86–100, everything within an 180-foot emanation of the sphere is pulled to another plane through a tear in the spatial fabric. If a rod of cancellation (Pathfinder Advanced Player's Guide) touches the sphere, both items explode, dealing 14d6 bludgeoning damage (DC 35 basic Reflex save) to everything in a 60-foot burst from the point of their destruction.",
                Level = 27,
                RarityId = Rarities.Instances.Rare.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c7b0749b-7de5-4270-a5d6-16a4d7f4e850"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command")
                           .Requirements("You are within 40 feet of the sphere.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("569b9d0d-9449-41f8-9601-3a089033b55f"), "You attempt a DC 30 Arcana or Occultism check to take control of the sphere. If someone else already controls the sphere, this check uses their Will DC if higher. If you succeed, you take control of the sphere. If you fail, the sphere moves 10 feet closer to you (or 20 feet on a critical failure). You keep control as long as you remain within 80 feet of the sphere and Sustain the Activation each round. When you Sustain the Activation, you must attempt a DC 30 Arcana or Occultism check. If you succeed, you direct the sphere to move up to 10 feet in a straight line (or up to 20 feet on a critical success). On a failure, you lose control of the sphere, and it moves 10 feet closer to you in a straight line (or 20 feet on a critical failure).");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4a81cdf3-0577-4f35-9287-f8c408aad626"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("97ed2e85-e5af-4ff8-b911-b8cbfbb5bcf2"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("6e778144-d7e2-41c2-80d8-a67ba13acbd7"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("39212d7d-04bd-433a-b810-92fb810d45a4"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c283627-cafe-494c-b6ec-a90729aba9cd"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 113
            };
        }
    }
}
