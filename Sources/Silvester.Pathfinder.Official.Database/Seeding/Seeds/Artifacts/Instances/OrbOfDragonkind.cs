using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class OrbOfDragonkind : Template
    {
        public static readonly Guid ID = Guid.Parse("6aba5b09-40e2-4e95-99ce-1db9bf9b1c13");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Orb of Dragonkind",
                Destruction = "An orb of dragonkind violently shatters and explodes when exposed to the Breath Weapon of a dragon who is a descendant of the dragon trapped within. The explosion deals damage as the 2-action activation above to all creatures within 90 feet.",
                Usage = "Held in 1 hand.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.OneBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9d542198-3196-4001-a95b-723e2ee36c84"), Type = TextBlockType.Text, Text = "Each of the legendary orbs of dragonkind contains the essence and personality of a powerful dragon, with each of the 10 most famous orbs preserving a different type of metallic or chromatic dragon’s spirit. It is believed that orbs for other types of true dragons exist, though that theory is yet to be confirmed." };
            yield return new TextBlock { Id = Guid.Parse("e1fa14e3-8a5d-42b6-93fc-d4c28316d527"), Type = TextBlockType.Text, Text = "While holding an orb of dragonkind, you are immune to the breath weapon of the dragon variety associated with the orb. An orb of dragonkind also grants a number of additional senses. You can communicate verbally and visually with the bearers of other orbs as if you were in the same room with them. You know if there are any dragons within 10 miles of you at all times; this extends to 100 miles for dragons of the type associated with the orb. If an associated dragon is within 1 mile, you know which direction the dragon is from you and the dragon’s age, such as young, adult, or ancient. Each orb grants a 10th-level arcane innate spell that you can cast at will, determined by the specific orb." };
            yield return new TextBlock { Id = Guid.Parse("a14bec0f-8fd8-4531-98ea-8dbf3ea3409f"), Type = TextBlockType.Heading, Text = "Spell Granted (DC 40)" };
            yield return new TextBlock { Id = Guid.Parse("45f5a2ef-ea83-4612-8a0a-6bc6264f565d"), Type = TextBlockType.Enumeration, Text = "Black Dragon - Darkness" };
            yield return new TextBlock { Id = Guid.Parse("82de367f-d2e2-4783-9f68-78c6a9de3a72"), Type = TextBlockType.Enumeration, Text = "Blue Dragon -  Hallucinatory Terrain" };
            yield return new TextBlock { Id = Guid.Parse("dc33df00-507e-4ffd-927b-6fc4859f38a2"), Type = TextBlockType.Enumeration, Text = "Brass Dragon - Speak with Animals" };
            yield return new TextBlock { Id = Guid.Parse("1600ee15-8184-43c9-a91b-0176a4652bf0"), Type = TextBlockType.Enumeration, Text = "Bronze Dragon - Control Water" };
            yield return new TextBlock { Id = Guid.Parse("14f5c069-e01c-42cc-bba6-852837ce6ab7"), Type = TextBlockType.Enumeration, Text = "Copper Dragon - Hideous Laughter" };
            yield return new TextBlock { Id = Guid.Parse("f79c469b-f540-423c-a94f-0a6f124b5796"), Type = TextBlockType.Enumeration, Text = "Green Dragon - Entangle" };
            yield return new TextBlock { Id = Guid.Parse("23c1524b-a78a-49fd-adae-ed9c66eee9fc"), Type = TextBlockType.Enumeration, Text = "Red Dragon - Wall of Fire" };
            yield return new TextBlock { Id = Guid.Parse("167dac7c-57ee-4a7c-abe0-451610253f3a"), Type = TextBlockType.Enumeration, Text = "Silver Dragon - Detect Alignment (Evil Only)" };
            yield return new TextBlock { Id = Guid.Parse("1c34a392-d6c7-4afd-9bed-045f8f73a67c"), Type = TextBlockType.Enumeration, Text = "White Dragon - Wall of Ice" };
            yield return new TextBlock { Id = Guid.Parse("168a2ff2-1a98-469a-af9f-696d03ddb7b8"), Type = TextBlockType.Text, Text = "The Orb of Gold Dragonkind can convey the innate spells of any of the other orbs, as well as their activated abilities, but it can grant each individual power only once per day. In addition, the bearer of the gold orb can use its 3-action activation to attempt to cast dominate on the bearer of another orb if they are within 1 mile, as if that bearer were a dragon of the associated type within 500 feet. The last reports of the Orb of Gold Dragonkind on Golarion indicate the orb has been destroyed, however. GMs running campaigns in settings other than the Age of Lost Omens might decide the gold orb is still intact for their campaigns." };
            yield return new TextBlock { Id = Guid.Parse("7324742d-6b8c-4cca-af95-6da429d593c2"), Type = TextBlockType.Text, Text = "Bearing an orb of dragonkind earns you the enmity of all dragonkind forever because you profited from the enslavement of the dragon within the orb, even if you later lose the orb." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("e71528ee-38f3-4ca7-80b9-f27866b446ba"),
                Name = "Command",
                Frequency = "Once per round.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("35383177-e9b5-4c4c-a49c-8d879c6714c9"), Type = TextBlockType.Text, Text = "You cast a 10th-level dominate spell (DC 40) on a dragon of the type associated with the orb within 500 feet, except the effect lasts for 1 month rather than unlimited. The dragon does not receive its status bonus to saving throws against magic. The dragon is then temporarily immune to further domination via the orb for 24 hours." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("2b62a10d-7c12-4736-9c0c-70c6c40e291a"),
                Name = "Envision, Interact",
                Frequency = "Three times per day.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("526c3fe6-e4af-4ee5-be47-bc57a1a0e0d1"), Type = TextBlockType.Text, Text = "You breathe an elemental blast that deals 25d6 damage (DC 40 basic Reflex save) in either a 60-foot cone or a 100-foot line (your choice). The breath’s damage type matches the Breath Weapon of the dragon type associated with the orb of dragonkind (acid for the black orb, electricity for the blue orb, and so on)." }
                }
            };

        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Arcane.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce8925dc-8261-47c4-bba5-66c1fb4cbbdc"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 110
            };
        }
    }
}
