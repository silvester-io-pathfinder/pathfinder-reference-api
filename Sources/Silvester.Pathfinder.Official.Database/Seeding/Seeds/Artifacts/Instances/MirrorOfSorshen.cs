using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class MirrorOfSorshen : Template
    {
        public static readonly Guid ID = Guid.Parse("bded304e-fe37-4721-ac02-f50e00ede945");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Mirror of Sorshen",
                Destruction = "The Mirror of Sorshen shatters into a thousand pieces if an intelligent but completely innocent creature resists the mirror’s attraction and then accidentally drops it.",
                Usage = "Bonded.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.TwoBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c7975322-bd0c-4c8f-9110-bac5f85370c1"), Type = TextBlockType.Text, Text = "The silvery glass of this oval mirror displays alluring sights. Its dark wooden frame is studded with small green gems and is carved with the shapes of a male figure on one edge of the glass and a female figure on the other side." };
            yield return new TextBlock { Id = Guid.Parse("cf4b2572-15b2-46c4-80a2-87cfd0336fa9"), Type = TextBlockType.Text, Text = "The mirror can form a bond with a spellcaster who has legendary proficiency in Arcana or Occultism, who becomes the mirror’s owner. Regardless of where the mirror is, as long as the bond remains, the owner is aware of everything the mirror is currently reflecting and can use the mirror’s activations." };
            yield return new TextBlock { Id = Guid.Parse("2c286586-c351-43c1-9d36-0c7dba7a4c19"), Type = TextBlockType.Text, Text = "Whenever an intelligent creature looks in the mirror, they see an image of a person, creature, or item they find irresistible—most often one they find attractive. The specific image varies depending on the observer, even when more than one creature is looking into the mirror at the same time. Observers are fascinated by the images in the mirror unless they succeed at a DC 35 Will save each round. On a failure, they stare blankly at the mirror for as long as it remains in view, and if it leaves their view, they stare toward the last place they saw the mirror for several minutes thereafter. This is an emotion, enchantment, incapacitation, and visual effect. Creatures that are fascinated by the mirror are so deeply entranced that they don’t end their fascinated condition automatically even if a creature uses hostile actions against them or their allies; instead, they can attempt a DC 30 Will save to end the fascination. At the GM’s discretion, a truly innocent creature or a creature that has renounced all worldly pleasures might be immune to the mirror’s fascination." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("3dbb98c7-85be-493e-abc8-faef4b2eab6e"),
                Name = "Envision",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("e16805b1-b157-4841-8e72-91f541d5b768"), Type = TextBlockType.Text, Text = "You force a creature looking at the mirror to attempt an additional Will save against the mirror’s fascination effect, even if they succeeded at their save." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("0d217364-a4c4-42fc-a7e8-02c5e7435348"),
                Name = "Command",
                Requirements = "The target must be fascinated by the mirror.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("9585273c-9413-447b-a537-4eaaaa483c87"), Type = TextBlockType.Text, Text = "You control the target for 30 days, with the effect of a critically failed saving throw against dominate. If the victim sees the mirror again at any point before this duration expires, the control extends for an additional 30 days from the moment it looked at the mirror again. While there is no initial saving throw, the DC to break free due to commands against the creature’s nature is 35." }
                }
            };
        }

        protected override IEnumerable<Guid> GetActionTraits(ArtifactAction action)
        {
            ArtifactAction[] actions = GetActions().ToArray();

            if (action.Equals(actions[0]))
            {
                yield return Traits.Instances.Emotion.ID;
                yield return Traits.Instances.Enchantment.ID;
                yield return Traits.Instances.Incapacitation.ID;
                yield return Traits.Instances.Visual.ID;
            }

            if (action.Equals(actions[1]))
            {
                yield return Traits.Instances.Emotion.ID;
                yield return Traits.Instances.Enchantment.ID;
                yield return Traits.Instances.Incapacitation.ID;
            }
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1755380-e299-4bf5-b5a6-272ce75a3df7"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 110
            };
        }
    }
}
