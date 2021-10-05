using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class ShotOfTheFirstVault : Template
    {
        public static readonly Guid ID = Guid.Parse("6d49f646-8b41-4a43-b9d8-7c730f97603e");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Shot of the First Vault",
                Destruction = "If 10 shots of the First Vault are all fired at the same group of keketar or izfiitar proteans within 1 minute of each other, each shot was a hit, and the shots are then recalled, the shots collide as they attempt to re-form and crumble to dust.",
                ItemLevel = 23
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("32aaf212-68dc-4678-a62a-7c46c7bea848"), Type = TextBlockType.Text, Text = "Legends claim that some long-forgotten god stole the original bundle of shots of the First Vault from Abadar’s repository. Since then, individual pieces have turned up throughout the multiverse. When you pick up a shot of the First Vault, it immediately reshapes itself to function with any ranged weapon and establishes you as its owner until another creature picks it up. As its owner, you can use the shot’s single-action activation after shooting it." };
            yield return new TextBlock { Id = Guid.Parse("88fbfc31-ba17-4cb9-8413-22289a8ed5a1"), Type = TextBlockType.Text, Text = "Instead of rolling weapon damage dice, a shot of the First Vault deals 25 damage plus any bonuses or additional damage as if 25 were the result of the weapon’s damage dice; the damage type matches that normally dealt by the weapon. Upon damaging a creature, the shot of the First Vault shatters, and the fragments ricochet to hit any other enemies within 30 feet, making attack rolls with the same attack bonus. The shattered fragments remain lodged in the creatures they damage; the creatures are clumsy 2 while the fragments remain in place. A total of 3 actions, which have the manipulate trait, are required to remove the fragments from yourself or an adjacent creature; alternatively, a single action and a successful DC 30 Medicine check can be used. A critical failure on this Medicine check deals 10 persistent bleed damage to the creature with the embedded fragment." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("240918f8-e501-46d0-824d-11bc93abb51c"),
                Name = "Command",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[] 
                {
                    new TextBlock { Id = Guid.Parse("6d5849c7-5a14-4029-add2-e87113a5b784"), Type = TextBlockType.Text, Text = "You recall the shot of the First Vault, which automatically reloads itself into your weapon. If the shot had fragmented, the fragments violently dislodge themselves, dealing 15 persistent bleed damage to each creature in which they were embedded. The fragments then unite to re-form the shot of the First Vault, which automatically reloads itself into your weapon." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("f7d637df-294b-418d-b058-6de02620a003"),
                Name = "Interact",
                Requirements = "The shot is loaded in your ranged weapon, or at hand if your ranged weapon has a reload of 0.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("3b2fe04f-3994-4665-906d-1132b2d0891b"), Type = TextBlockType.Text, Text = "You line up a perfectly aimed attack directly toward the First Vault. You Strike a creature, then the shot of the First Vault attempts to bring your target with it as it returns to the First Vault. Unless your attack roll is a critical failure, the creature must attempt a DC 45 Reflex save; this effect has the incapacitation trait. Regardless, the shot of the First Vault returns to the First Vault." }
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("9e8de994-dbcb-446a-b539-7bb5cca5d953"),
                    CriticalSuccess = "The creature is unaffected.",
                    Success = "The creature is moved 1d20×50 feet in the direction you fired. If this causes it to hit a solid object, it takes 50 bludgeoning damage.",
                    Failure = "The creature is transported to a random location on the plane of Axis.",
                    CriticalFailure = "The creature is transported to the First Vault. Unless it is capable of eluding Abadar’s precautions, it is likely unable to escape the Vault on its own."
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Divine.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3daaf1e-b2c7-4fa2-bcbd-2f8506817a04"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 112
            };
        }
    }
}
