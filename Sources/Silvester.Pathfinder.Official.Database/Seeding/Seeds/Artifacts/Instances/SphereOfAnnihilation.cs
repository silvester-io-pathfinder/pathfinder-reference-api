using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
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
                Destruction = "When a gate spell is cast such that its rift overlaps a sphere of annihilation, roll d%. On a result of 1–50, the sphere is destroyed; on a 51–85, the spell is disrupted; and on a 86–100, everything within an 180-foot emanation of the sphere is pulled to another plane through a tear in the spatial fabric. If a rod of cancellation (Pathfinder Advanced Player’s Guide) touches the sphere, both items explode, dealing 14d6 bludgeoning damage (DC 35 basic Reflex save) to everything in a 60-foot burst from the point of their destruction.",
                ItemLevel = 27,
                BulkId = Bulks.Instances.TwoBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d8d3fb9a-9cae-4afc-8c95-576384d00feb"), Type = TextBlockType.Text, Text = "A sphere of annihilation is a floating black sphere that pulls any matter that comes into contact with it into a void, destroying it utterly. Anything or anyone destroyed by the sphere can be brought back only by a deity’s direct intervention. The sphere can’t be counteracted by dispel magic or similar effects." };
            yield return new TextBlock { Id = Guid.Parse("476e6b56-f4f4-49b1-ab4c-8cca9971ce19"), Type = TextBlockType.Text, Text = "The sphere stays entirely still until caused to move by a creature controlling it. Taking control of the sphere requires succeeding at an attempt to activate it. A talisman of the sphere makes it easier to control the sphere." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("c7b0749b-7de5-4270-a5d6-16a4d7f4e850"),
                Name = "Command",
                Requirements = "You are within 40 feet of the sphere.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[] 
                {
                    new TextBlock { Id = Guid.Parse("569b9d0d-9449-41f8-9601-3a089033b55f"), Type = TextBlockType.Text, Text = "You attempt a DC 30 Arcana or Occultism check to take control of the sphere. If someone else already controls the sphere, this check uses their Will DC if higher. If you succeed, you take control of the sphere. If you fail, the sphere moves 10 feet closer to you (or 20 feet on a critical failure). You keep control as long as you remain within 80 feet of the sphere and Sustain the Activation each round. When you Sustain the Activation, you must attempt a DC 30 Arcana or Occultism check. If you succeed, you direct the sphere to move up to 10 feet in a straight line (or up to 20 feet on a critical success). On a failure, you lose control of the sphere, and it moves 10 feet closer to you in a straight line (or 20 feet on a critical failure)." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
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
