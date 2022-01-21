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
    public class EssencePrism : Template
    {
        public static readonly Guid ID = Guid.Parse("5e4e2abd-2eb8-44ee-95e4-817d36a5b3c0");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Essence Prism",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8d123bc6-d298-4886-948b-01d5cc061436"), "This enormous, multifaceted prism normally rests on a pedestal, eerily refracting many-colored lights even when no light source is present. In reality, the prism refracts the four magical essences into the visible spectrum. A creature adjacent to the prism can adjust its facets with an Interact action to change between two polarities. Two essences flow from two input streams into the prism, where the prism combines them into a single output stream; alternatively, a single essence flows from one input stream into the prism and is split into two output streams. A creature that enters and stays within an input essence stream for 1 minute is slowly encased in solid magic, at which point it is paralyzed until anyone reverses the prism's flow or finishes activating the prism. A creature stepping into an output essence stream is gently pushed back and out of the stream.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("bca5dfc7-167e-4928-8f77-44d6d6b6ced0"),
                Name = "Essence Prism",
                Destruction = "Forcing the essence prism to combine two incompatible demigods destroys the prism, though it might also result in a new divinity.",
                CraftingRequirements = "",
                Level = 28,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                Addendum = new TextBlockBuilder()
                       .Text(Guid.Parse("410b4117-6168-488b-ac3a-433d6c06f2f7"), "")
                       .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("fd1bb5d1-e5d4-45a5-bbf1-b1559e81d240"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                     {
                         action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("52360ff5-47b3-4e11-a87a-91a444a598b0"), "You alter and rearrange the facets of the essence prism, adjusting the essences to select for a single quality, which might be associated with mental essence, like a personality trait; material essence, like a physical quality; vital essence, like a belief or instinct; or spiritual essence, like an alignment component such as good or lawful. You must succeed at a secret DC 30 skill check with a skill associated with a magical tradition that uses the essence you chose (for instance, Arcana or Occultism for mental essence, as arcane and occult magic both use mental essence). On a failure, you accidentally set the prism for some other quality.");
                            });
                     })
                    .Add(Guid.Parse("31005c6f-88f3-4a6b-8266-e26341a980e0"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact (1 minute)")
                            .Requirements("The prism has only one input stream, and a creature is encased in magic in the input stream.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("bacf08cd-633f-4bc3-b824-510a5b9476c9"), "Over the course of the next hour, the creature in the input stream has its essences refracted through the prism, creating two cocoons of magic in the output streams that each contain a new creature. At the end of the process, the original creature is gone, and the two new creatures break free of their cocoons. Each creature is part of the original, separated from the rest based on the last quality set by the prism's first activation. For instance, if you set the prism to “good,” one creature would have all the original creature's good aspects and the other would be the original creature's evil side. Unless you selected a physical quality, both new creatures look just like the original. The new creatures are usually 2 levels lower than the original, but if the original creature was strongly biased with respect to the quality you chose (for instance, if splitting out the good and evil side of a redeemer), the stronger creature is 1 level lower and the weaker creature is 3 or more levels lower. If calibrated correctly, this activation can also reverse the effect of the third activation.");
                            });
                    })
                    .Add(Guid.Parse("8edfe177-96be-4e73-a572-d31bd61160b7"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact (1 minute)")
                            .Requirements("The prism has two input streams, and a creature is encased in magic in each of the input streams")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("63ab1eaa-09b9-4368-ab66-fc94bcd86161"), "Over the course of the next hour, the essences of both creatures in the input streams are refracted through the prism, creating a cocoon of magic in the output stream that contains a new creature. At the end of the process, the original creatures are gone, and the new creature breaks free of its cocoon. The new creature is an amalgam of the originals, with a new personality blended from both, and is usually 1 or 2 levels higher than the higher level of the original creatures unless the lower-level creature was much weaker. This activation also reverses the effect of the second activation.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7515a210-a73b-444a-8c93-7f3156ba0411"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("8bd28946-ee66-48a1-a0b8-59e0402d4273"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("6a19979d-9c0f-442f-ac7e-6aba2ad44ec8"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a44b9a2-d6d7-4043-8034-d7583e5b513a"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 108
            };
        }
    }
}
