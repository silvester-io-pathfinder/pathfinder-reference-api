using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class FlawedOrbOfGoldDragonkind : Template
    {
        public static readonly Guid ID = Guid.Parse("180ce72b-c375-454c-8384-244901734ac5");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Flawed Orb of Gold Dragonkind",
                Destruction = "The Flawed Orb of Gold Dragonkind is resilient, but its imperfect nature leaves it vulnerable. It can be damaged or even destroyed by mundane attacks (Hardness 40, HP 200, BT 100). It has weakness 30 to the Breath Weapons and Strikes of gold dragons.",
                Usage = "Held in 1 hand.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.OneBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c0bdbee5-9cf3-4ef1-9672-c8eed719efc3"), Type = TextBlockType.Text, Text = "Each of the legendary Orbs of Dragonkind contains the essence and personality of a powerful dragon. The Orb of Gold Dragonkind was the most powerful of them all, until it was shattered by Mengkare's draconic breath. Reconstructed at great expense by enslaved spellcasters toiling under the Scarlet Triad's watch, the Flawed Orb of Gold Dragonkind is a shadow of its prior self, yet it remains a potent weapon against dragons of all types." };
            yield return new TextBlock { Id = Guid.Parse("080d1d55-9b19-4c45-8474-09c43333ea86"), Type = TextBlockType.Text, Text = "While carried, the Flawed Orb of Gold Dragonkind grants its owner resistance 30 to the Breath Weapons of gold dragons. The owner also can sense if there are any dragons within 10 miles, or any gold dragons within 100 miles. When within 1 mile of a dragon, they can determine the direction to the dragon and the dragon's age category (such as young, ancient, or wyrm)." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("166a6ae1-4c1a-4942-8fe5-6cd825b31538"),
                Name = "Envision, Interact",
                Frequency = "Three times per day.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[] 
                {
                    new TextBlock { Id = Guid.Parse("18db2077-f59d-41b0-a222-b78ba9b6dcdd"), Type = TextBlockType.Text, Text = "You attempt to overwhelm a dragon's mind—while you cannot control the dragon, you can render it immobile for a short time. Choose a dragon within 60 feet; the dragon can attempt to resist the orb with a DC 30 Will saving throw (or higher with orb shards). Gold dragons take a –4 circumstance penalty to this saving throw. Any stun from this activation ends if the dragon is attacked or otherwise subject to a hostile act other than that of the orb." }
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("7030a780-545c-490c-a24b-e60f4107cf00"),
                    CriticalSuccess = "The dragon is unaffected.",
                    Success = "The dragon is stunned 3.",
                    Failure = "The dragon is stunned for as long as the orb's wielder Sustains the Activation.",
                    CriticalFailure = "As failure, but hostile actions don't end the dragon's stun."
                }
            };
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
                Id = Guid.Parse("6b182779-ce4a-448a-a190-dc2b4b3ac276"),
                SourceId = Sources.Instances.Pathfinder150.ID,
                Page = 75
            };
        }
    }
}
