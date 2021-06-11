using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
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
                Destruction = "Trapping a lawful demigod in the hallucinatory terrain created by the cane and leaving it imprisoned for a year and a day causes a deific overload that destroys the artifact. When the artifact is destroyed, the terrain imprisoning the demigod crumbles away and the demigod is freed.",
                Usage = "Held in 1 hand.",
                ItemLevel = 22,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("392e639b-bfb6-4e0b-8f51-43b60355d39b"), Type = TextBlockType.Text, Text = "A large crystal of warpglass floats above the head of this silvery purple +3 anarchic greater striking club. If you successfully Strike a creature, the cane also affects the target with a warpwave. While you carry the cane, you hear a constant, distracting chorus of laughing, incoherent Protean whispers and sing-song voices in your mind. Blatant acts of self-indulgence or narcissism quell these whispers, from a few minutes up to a full day depending on the scope of the act, but they immediately return when you use the artifact's powers. The gradually rising chorus eventually drives away rational thought and renders the cane's owner insane, even if staved off from time to time with self-centered acts. As the artifact's abilities pull material from the Maelstrom, it doesn't function in areas where planar connections are severed." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("fb27b55d-9b89-44a7-9365-bc5ad95f9325"),
                Name = "Envision",
                Trigger = "You are targeted by a ranged attack from an opponent you can see.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("744dac82-97e4-46f9-ba6a-91493d29ca9b"), Type = TextBlockType.Text, Text = "You draw a temporary shield of chaotic turbulence with a cerulean flash. You gain a +3 circumstance bonus to AC against the triggering attack." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("4e84e886-4a8a-4daa-baf3-ff4b4e9c1f34"),
                Name = "Command, Envision, Interact",
                RequiredTime = "10 minutes.",
                Frequency = "10 minutes.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("e078704a-8b1d-4cc6-9a38-ee220614a933"), Type = TextBlockType.Text, Text = "The Cane of the Maelstrom casts a 5th-level hallucinatory terrain spell and infuses the illusion with quasi-real substance drawn from the primal chaos of the Maelstrom. Creatures that don't disbelieve the illusion treat structures and terrain created through the spell as though they were real, ascending illusory stairs, becoming trapped by illusory quicksand, and so on. If no creature disbelieves the illusion during its duration, the changes become wholly real and permanent when its duration expires." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("ed064ae6-c820-403f-89d3-dece3f1d6c3f"),
                Name = "Interact",
                RequiredTime = "1 minute.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("356d28ce-6dc9-43fe-995a-cdd55eceaf6a"), Type = TextBlockType.Text, Text = "The Cane of the Maelstrom casts a 5th-level creation spell, except the duration is unlimited and you can create delicate or complex objects by succeeding at an applicable Crafting skill check when you activate this ability." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Divine.ID;
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
