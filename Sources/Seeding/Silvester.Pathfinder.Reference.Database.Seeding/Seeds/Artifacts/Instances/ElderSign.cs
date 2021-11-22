using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class ElderSign : Template
    {
        public static readonly Guid ID = Guid.Parse("891ae18b-dc47-4426-9148-8aa4669ad0c7");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Elder Sign",
                Destruction = "The only way to destroy an elder sign is to use it to banish a Great Old One.",
                Usage = "Held in 1 hand.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.OneBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("06dc3b48-0a47-4205-b8cf-ca57d93219d2"), Type = TextBlockType.Text, Text = "This stone tablet is carved with the symbol of a five-branched twig. There are only a limited number of elder signs, and each time one is destroyed, the universe's doom creeps inexorably closer. Reciting one of three different occult mantras (DC 20 Occultism check to do so correctly) allows three different activations. All three abilities work only on a creature connected to the Elder Mythos or a cosmic horror, such as a wendigo or gug; the activations refer to them as “eldritch creatures.”" };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("21a00b42-f9bc-4482-9200-1158558dad95"),
                Name = "Command, Envision, Interact",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("650c5752-e8e3-4737-a190-1a37baebbfe8"), Type = TextBlockType.Text, Text = "The elder sign casts a 10th-level banishment spell on an eldritch creature. Even if the creature isn't extraplanar, the elder sign can still banish it, sending it back to the part of the Material Plane from which it originated. If the creature is a Great Old One, the elder sign banishes it automatically (as if it critically failed its save) but is then forever destroyed." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("3c4bcde6-3b6d-4066-8e5d-790cac0612f8"),
                Name = "Command, Envision, Interact",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("39c315bd-a1aa-411d-842a-1dbdab708f75"), Type = TextBlockType.Text, Text = "The elder sign casts dispel magic on an effect from an eldritch creature, using a counteract level of 10 and +30 modifier for the roll." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("1b990d52-6b74-430e-9630-1ae9005328c8"),
                Name = "Command, Envision, Interact",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("7cd71ff0-ec4e-4e77-9742-7c9235417d17"), Type = TextBlockType.Text, Text = "The elder sign casts dimensional lock, though it wards against travel by only eldritch creatures. Each time the elder sign casts dimensional lock in this way, the previous dimensional lock spell ends." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f73771fe-67ce-4d15-bedf-55db48c52f1e"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 108
            };
        }
    }
}
