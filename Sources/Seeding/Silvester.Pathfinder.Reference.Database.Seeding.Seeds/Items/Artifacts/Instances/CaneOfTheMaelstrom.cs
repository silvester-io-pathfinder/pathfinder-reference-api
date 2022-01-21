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
    public class CaneOfTheMaelstrom : Template
    {
        public static readonly Guid ID = Guid.Parse("6876bf26-aa49-47df-93b8-0cf49c35c732");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Cane of the Maelstrom",
            };
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("72d4aad0-1a1a-489b-93a6-9c5d6da874be"),
                Name = "Cane of the Maelstrom",
                Destruction = "Trapping a lawful demigod in the hallucinatory terrain created by the cane and leaving it imprisoned for a year and a day causes a deific overload that destroys the artifact. When the artifact is destroyed, the terrain imprisoning the demigod crumbles away and the demigod is freed.",
                Level = 22,
                Hands = 1,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("392e639b-bfb6-4e0b-8f51-43b60355d39b"), "A large crystal of warpglass floats above the head of this silvery purple +3 anarchic greater striking club. If you successfully Strike a creature, the cane also affects the target with a warpwave. While you carry the cane, you hear a constant, distracting chorus of laughing, incoherent Protean whispers and sing-song voices in your mind. Blatant acts of self-indulgence or narcissism quell these whispers, from a few minutes up to a full day depending on the scope of the act, but they immediately return when you use the artifact's powers. The gradually rising chorus eventually drives away rational thought and renders the cane's owner insane, even if staved off from time to time with self-centered acts. As the artifact's abilities pull material from the Maelstrom, it doesn't function in areas where planar connections are severed.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fb27b55d-9b89-44a7-9365-bc5ad95f9325"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You are targeted by a ranged attack from an opponent you can see.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("744dac82-97e4-46f9-ba6a-91493d29ca9b"), "You draw a temporary shield of chaotic turbulence with a cerulean flash. You gain a +3 circumstance bonus to AC against the triggering attack.");
                            });
                    })
                    .Add(Guid.Parse("4e84e886-4a8a-4daa-baf3-ff4b4e9c1f34"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("10 minutes (Command, Envision, Interact)")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e078704a-8b1d-4cc6-9a38-ee220614a933"), "The Cane of the Maelstrom casts a 5th-level hallucinatory terrain spell and infuses the illusion with quasi-real substance drawn from the primal chaos of the Maelstrom. Creatures that don't disbelieve the illusion treat structures and terrain created through the spell as though they were real, ascending illusory stairs, becoming trapped by illusory quicksand, and so on. If no creature disbelieves the illusion during its duration, the changes become wholly real and permanent when its duration expires.");
                            });
                    })
                    .Add(Guid.Parse("ed064ae6-c820-403f-89d3-dece3f1d6c3f"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("One minute (Interact)")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("356d28ce-6dc9-43fe-995a-cdd55eceaf6a"), "The Cane of the Maelstrom casts a 5th-level creation spell, except the duration is unlimited and you can create delicate or complex objects by succeeding at an applicable Crafting skill check when you activate this ability.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("41553d84-2b99-4559-9ddc-85d6108609ec"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("8d89c2a2-c3fc-407b-af69-ea1165849d72"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("1fdf0389-baea-48d4-a84d-2fdad6188b40"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("25498366-1a42-4340-b5fc-6b76cabbf5ad"), Traits.Instances.Cursed.ID);
            builder.Add(Guid.Parse("30178e54-418f-4b2e-b3e9-c5510645cd63"), Traits.Instances.Divine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4aa889bc-7c0f-4842-9569-5a76167d6ab4"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 73
            };
        }
    }
}
