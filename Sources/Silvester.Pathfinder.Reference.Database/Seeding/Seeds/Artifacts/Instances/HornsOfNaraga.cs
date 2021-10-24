using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
{
    public class HornsOfNaraga : Template
    {
        public static readonly Guid ID = Guid.Parse("c718686d-6681-474a-8bfa-3d89c5040e11");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Horns of Naraga",
                Destruction = "The helm is utterly obliterated if crushed between the jaws of an ancient black dragon’s skull located in a desert while the sun is at its zenith.",
                Usage = "Worn headwear.",
                ItemLevel = 26,
                BulkId = Bulks.Instances.TwoBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3c772c10-e144-498e-b4e9-c8cd7c03eabd"), Type = TextBlockType.Text, Text = "This imposing helm bears the horns of a powerful black dragon. While wearing the Horns of Naraga, you gain greater darkvision and immunity to acid. If you are undead, you gain resistance 40 to positive damage. If you are not undead, the helm quickly saps the life from you, dealing 10d6 negative damage to you every round. If you die from this damage, you rise as an undead of an equal level in 1d4 rounds." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("c65e81aa-a1fd-43f3-a97f-e3fa36fc61dd"),
                Name = "Envision",
                Trigger = "You touch a creature as part of an unarmed attack or melee spell attack roll.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("03356da7-c9d9-4627-b3e7-dd72da589b9e"), Type = TextBlockType.Text, Text = "The creature takes 5d6 negative damage. If you are an undead, you regain Hit Points equal to the negative damage the creature took." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("b25e7a3f-5ab4-425c-8da2-4ada7094cd82"),
                Name = "Command",
                Frequency = "Once per day.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("97a22ccf-affe-470e-ab0b-2c373d3dff8e"), Type = TextBlockType.Text, Text = "The Horns of Naraga transform into Naraga, an ancient black dragon. Naraga appears in an adjacent appropriate space, and if no such space is available, she does not appear. Naraga follows your commands without question. She remains for up to 1 hour or until you use an Interact action to dismiss her, after which she reverts back to the helm. If Naraga is slain, she immediately reverts back to the helm and can’t be summoned for 1 week. You don’t receive any of the helm’s other benefits while it is transformed." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Invested.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb13a8a5-632e-495e-8949-d4efabd73b2e"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 109
            };
        }
    }
}
