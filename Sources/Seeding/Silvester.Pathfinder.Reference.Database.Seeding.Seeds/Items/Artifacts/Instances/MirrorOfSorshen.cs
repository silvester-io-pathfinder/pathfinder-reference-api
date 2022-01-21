using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
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
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c7975322-bd0c-4c8f-9110-bac5f85370c1"), "The silvery glass of this oval mirror displays alluring sights. Its dark wooden frame is studded with small green gems and is carved with the shapes of a male figure on one edge of the glass and a female figure on the other side.");;
            builder.Text(Guid.Parse("cf4b2572-15b2-46c4-80a2-87cfd0336fa9"), "The mirror can form a bond with a spellcaster who has legendary proficiency in Arcana or Occultism, who becomes the mirror's owner. Regardless of where the mirror is, as long as the bond remains, the owner is aware of everything the mirror is currently reflecting and can use the mirror's activations.");;
            builder.Text(Guid.Parse("2c286586-c351-43c1-9d36-0c7dba7a4c19"), "Whenever an intelligent creature looks in the mirror, they see an image of a person, creature, or item they find irresistible—most often one they find attractive. The specific image varies depending on the observer, even when more than one creature is looking into the mirror at the same time. Observers are fascinated by the images in the mirror unless they succeed at a DC 35 Will save each round. On a failure, they stare blankly at the mirror for as long as it remains in view, and if it leaves their view, they stare toward the last place they saw the mirror for several minutes thereafter. This is an emotion, enchantment, incapacitation, and visual effect. Creatures that are fascinated by the mirror are so deeply entranced that they don't end their fascinated condition automatically even if a creature uses hostile actions against them or their allies; instead, they can attempt a DC 30 Will save to end the fascination. At the GM's discretion, a truly innocent creature or a creature that has renounced all worldly pleasures might be immune to the mirror's fascination.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("7809d538-11be-4d01-a573-0458d8743f22"),
                Name = "Mirror of Sorshen",
                Usage = "Bonded.",
                Destruction = "The Mirror of Sorshen shatters into a thousand pieces if an intelligent but completely innocent creature resists the mirror's attraction and then accidentally drops it.",
                Level = 25,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3dbb98c7-85be-493e-abc8-faef4b2eab6e"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Envision")
                           .Traits(traits => 
                           {
                               traits.Add(Guid.Parse("9c95ae09-6963-4edd-be8e-a7c2c4b6915a"), Traits.Instances.Emotion.ID);
                               traits.Add(Guid.Parse("23672b89-2b26-4b36-9a0c-044f074e483a"), Traits.Instances.Enchantment.ID);
                               traits.Add(Guid.Parse("f8dddd10-3010-41ef-9566-6e1f5c4c5cf4"), Traits.Instances.Incapacitation.ID);
                               traits.Add(Guid.Parse("1baaadb7-8c8a-4de0-85ce-10ca6ffe7db5"), Traits.Instances.Visual.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("e16805b1-b157-4841-8e72-91f541d5b768"), "You force a creature looking at the mirror to attempt an additional Will save against the mirror's fascination effect, even if they succeeded at their save.");
                           });
                    })
                    .Add(Guid.Parse("0d217364-a4c4-42fc-a7e8-02c5e7435348"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command")
                           .Requirements("The target must be fascinated by the mirror.")
                           .Traits(traits =>
                           {
                               traits.Add(Guid.Parse("8bad9254-08ae-41c6-a64d-eaf78abec226"), Traits.Instances.Emotion.ID);
                               traits.Add(Guid.Parse("985d3c90-343c-4322-906a-fc1c36c98a0d"), Traits.Instances.Enchantment.ID);
                               traits.Add(Guid.Parse("c134250d-92ce-49b6-ac83-8a6490f5f321"), Traits.Instances.Incapacitation.ID);
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("9585273c-9413-447b-a537-4eaaaa483c87"), "You control the target for 30 days, with the effect of a critically failed saving throw against dominate. If the victim sees the mirror again at any point before this duration expires, the control extends for an additional 30 days from the moment it looked at the mirror again. While there is no initial saving throw, the DC to break free due to commands against the creature's nature is 35.");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2889c7fc-06a3-4047-bad6-00687173bb53"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("54e81037-5ccd-4403-bf16-379a238892c9"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("7ec9f54f-c3aa-46b6-8788-8d337aa10f6d"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("89c725aa-f438-48d8-867c-5a62b4b64754"), Traits.Instances.Magical.ID);
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
