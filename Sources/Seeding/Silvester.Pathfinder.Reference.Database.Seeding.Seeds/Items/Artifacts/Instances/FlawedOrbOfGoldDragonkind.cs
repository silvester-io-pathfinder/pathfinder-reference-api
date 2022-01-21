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
    public class FlawedOrbOfGoldDragonkind : Template
    {
        public static readonly Guid ID = Guid.Parse("180ce72b-c375-454c-8384-244901734ac5");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Flawed Orb of Gold Dragonkind",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c0bdbee5-9cf3-4ef1-9672-c8eed719efc3"), "Each of the legendary Orbs of Dragonkind contains the essence and personality of a powerful dragon. The Orb of Gold Dragonkind was the most powerful of them all, until it was shattered by Mengkare's draconic breath. Reconstructed at great expense by enslaved spellcasters toiling under the Scarlet Triad's watch, the Flawed Orb of Gold Dragonkind is a shadow of its prior self, yet it remains a potent weapon against dragons of all types.");;
            builder.Text(Guid.Parse("080d1d55-9b19-4c45-8474-09c43333ea86"), "While carried, the Flawed Orb of Gold Dragonkind grants its owner resistance 30 to the Breath Weapons of gold dragons. The owner also can sense if there are any dragons within 10 miles, or any gold dragons within 100 miles. When within 1 mile of a dragon, they can determine the direction to the dragon and the dragon's age category (such as young, ancient, or wyrm).");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("a5f07504-9869-4671-8d0e-40f5d304c4be"),
                Name = "Flawed Orb of Gold Dragonkind",
                Destruction = "The Flawed Orb of Gold Dragonkind is resilient, but its imperfect nature leaves it vulnerable. It can be damaged or even destroyed by mundane attacks (Hardness 40, HP 200, BT 100). It has weakness 30 to the Breath Weapons and Strikes of gold dragons.",
                Level = 25,
                Hands = 1,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("166a6ae1-4c1a-4942-8fe5-6cd825b31538"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                        .Kind("Envision, Interact")
                        .Frequency("Three times per day.")
                        .RollableEffect(Guid.Parse("7030a780-545c-490c-a24b-e60f4107cf00"), effect => 
                        {
                            effect.CriticalSuccess("The dragon is unaffected.");
                            effect.Success("The dragon is stunned 3.");
                            effect.Failure("The dragon is stunned for as long as the orb's wielder Sustains the Activation.");
                            effect.CriticalFailure("As failure, but hostile actions don't end the dragon's stun.");
                        })
                        .Details(effect =>
                        {
                            effect.Text(Guid.Parse("18db2077-f59d-41b0-a222-b78ba9b6dcdd"), "You attempt to overwhelm a dragon's mind—while you cannot control the dragon, you can render it immobile for a short time. Choose a dragon within 60 feet; the dragon can attempt to resist the orb with a DC 30 Will saving throw (or higher with orb shards). Gold dragons take a –4 circumstance penalty to this saving throw. Any stun from this activation ends if the dragon is attacked or otherwise subject to a hostile act other than that of the orb.");
                        });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c26974b-dff5-4d41-98d1-4901e913f3fb"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("9fcb0f80-e0e6-4dfd-ba90-686630e3ea22"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("2a1cd524-33cc-447b-9ccb-9b4dee240546"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("065fbaeb-a7db-4c8b-acf2-0f2559683acc"), Traits.Instances.Magical.ID);
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
