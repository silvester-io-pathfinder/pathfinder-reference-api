using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class ForgefathersSeal : Template
    {
        public static readonly Guid ID = Guid.Parse("abb06321-d119-48af-a60b-edac04a3ec43");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Forgefather's Seal",
                Destruction = "Using the Forgefather's seal ability to bring the dead back to life on an evil demigod causes it to shatter in a violent explosion that destroys the seal and the statue made as part of the sacrifice, erasing all knowledge of the user from existence. It does, however, bring the evil demigod back to life.",
                Usage = "Etched onto armor.",
                ItemLevel = 24,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0fc0294d-916b-46ec-89bc-1c169be0921e"), Type = TextBlockType.Text, Text = "This rune was created by Torag, god of the forge, protection, and strategy, and shared with his greatest artisans and warriors. Torag designed a small number of these seals as gifts to allied good deities; each one is nearly identical but has a different spell effect when using the reaction activation; for instance, Sarenrae's seal casts sunburst instead of earthquake." };
            yield return new TextBlock { Id = Guid.Parse("602ffa00-2543-4898-8b60-63c7c07ecaa7"), Type = TextBlockType.Text, Text = "A seal constantly rings with the quiet sound of a hammer striking an anvil when etched onto a runestone. A Forgefather's seal can be etched only onto armor that can bear two or more property runes, and it is so powerful that it takes the place of two property runes. While wearing armor etched with a Forgefather's seal, you gain fire resistance 40. You ignore the armor's check penalty and Speed penalty (if any); if the armor is light or medium, increase its item bonus to AC by 1. In addition, any shield you wield automatically recovers 10 Hit Points at the start of your turn each round." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("47df6f9c-d990-4700-b193-56d0f5a5648f"),
                Name = "Interact",
                Trigger = "You are hit by an attack.",
                Frequency = "Once per hour.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("606dc3d9-d0a2-4de7-9f1b-8c33619ca9be"), Type = TextBlockType.Text, Text = "The Forgefather's seal glows and your armor shakes as it absorbs the blow. The attack's damage is reduced by 100 and you cast earthquake (DC 40), centered directly on the triggering creature. You decide the area of the earthquake when you Cast the Spell, from as small as the size of the creature and up to a 60-foot burst." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("396e2173-b3a9-4c83-92e6-0928eff79bb4"),
                Name = "Interact",
                Frequency = "Once per day.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("94eaf58d-ef4d-4f49-931e-0416823bed8c"), Type = TextBlockType.Text, Text = "You call upon on the restorative powers of the seal to repair an item within reach. The rune instantly restores the item to full Hit Points, even if the item was destroyed, using the effects of the remake spell, so long as the majority of the item is available for the repair. The seal can restore even magic items and artifacts of its level or lower. Once you have used this ability, the seal's ability to automatically repair shields becomes inactive until the next time you make your daily preparations." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("c3c4bfd4-1578-4bcb-ab20-142465ec754a"),
                Name = "Envision",
                Trigger = "You have not acted yet on your turn.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("8242ca8f-1943-4ed3-b208-576b4a3cea50"), Type = TextBlockType.Text, Text = "You call upon Torag to defend your allies and those around you, sacrificing yourself in the process. Creatures of your choosing within 60 feet recover all their Hit Points. If any of the creatures are dead, they are instead brought back to life with half of their maximum Hit Points. The chosen creatures also gain a +4 status bonus to AC and saving throws, and fast healing 15 for 1 hour. You can use this ability to bring back to life a creature that requires a miracle spell or divine intervention to raise from the dead, as long as you choose no other creatures within 60 feet to recover. Once you use this activation, you are turned into a perfect statue made from stone or metal that depicts you in a glorious pose honoring your sacrifice, and you can never be restored. The Forgefather's seal remains on this statue and can be transferred to another suit of armor or a runestone as normal." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Divine.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f52662e4-4661-42b0-8e4f-76a243137558"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 109
            };
        }
    }
}
