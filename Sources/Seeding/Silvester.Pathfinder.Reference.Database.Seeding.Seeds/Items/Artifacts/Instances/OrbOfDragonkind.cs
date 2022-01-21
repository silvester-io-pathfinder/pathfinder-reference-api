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
    public class OrbOfDragonkind : Template
    {
        public static readonly Guid ID = Guid.Parse("6aba5b09-40e2-4e95-99ce-1db9bf9b1c13");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Orb of Dragonkind",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9d542198-3196-4001-a95b-723e2ee36c84"), "Each of the legendary orbs of dragonkind contains the essence and personality of a powerful dragon, with each of the 10 most famous orbs preserving a different type of metallic or chromatic dragon's spirit. It is believed that orbs for other types of true dragons exist, though that theory is yet to be confirmed.");;
            builder.Text(Guid.Parse("e1fa14e3-8a5d-42b6-93fc-d4c28316d527"), "While holding an orb of dragonkind, you are immune to the breath weapon of the dragon variety associated with the orb. An orb of dragonkind also grants a number of additional senses. You can communicate verbally and visually with the bearers of other orbs as if you were in the same room with them. You know if there are any dragons within 10 miles of you at all times; this extends to 100 miles for dragons of the type associated with the orb. If an associated dragon is within 1 mile, you know which direction the dragon is from you and the dragon's age, such as young, adult, or ancient. Each orb grants a 10th-level arcane innate spell that you can cast at will, determined by the specific orb.");;
            builder.Heading(Guid.Parse("a14bec0f-8fd8-4531-98ea-8dbf3ea3409f"), "Spell Granted (DC 40)");;
            builder.Enumeration(Guid.Parse("45f5a2ef-ea83-4612-8a0a-6bc6264f565d"), "Black Dragon - Darkness");;
            builder.Enumeration(Guid.Parse("82de367f-d2e2-4783-9f68-78c6a9de3a72"), "Blue Dragon -  Hallucinatory Terrain");;
            builder.Enumeration(Guid.Parse("dc33df00-507e-4ffd-927b-6fc4859f38a2"), "Brass Dragon - Speak with Animals");;
            builder.Enumeration(Guid.Parse("1600ee15-8184-43c9-a91b-0176a4652bf0"), "Bronze Dragon - Control Water");;
            builder.Enumeration(Guid.Parse("14f5c069-e01c-42cc-bba6-852837ce6ab7"), "Copper Dragon - Hideous Laughter");;
            builder.Enumeration(Guid.Parse("f79c469b-f540-423c-a94f-0a6f124b5796"), "Green Dragon - Entangle");;
            builder.Enumeration(Guid.Parse("23c1524b-a78a-49fd-adae-ed9c66eee9fc"), "Red Dragon - Wall of Fire");;
            builder.Enumeration(Guid.Parse("167dac7c-57ee-4a7c-abe0-451610253f3a"), "Silver Dragon - Detect Alignment (Evil Only)");;
            builder.Enumeration(Guid.Parse("1c34a392-d6c7-4afd-9bed-045f8f73a67c"), "White Dragon - Wall of Ice");;
            builder.Text(Guid.Parse("168a2ff2-1a98-469a-af9f-696d03ddb7b8"), "The Orb of Gold Dragonkind can convey the innate spells of any of the other orbs, as well as their activated abilities, but it can grant each individual power only once per day. In addition, the bearer of the gold orb can use its 3-action activation to attempt to cast dominate on the bearer of another orb if they are within 1 mile, as if that bearer were a dragon of the associated type within 500 feet. The last reports of the Orb of Gold Dragonkind on Golarion indicate the orb has been destroyed, however. GMs running campaigns in settings other than the Age of Lost Omens might decide the gold orb is still intact for their campaigns.");;
            builder.Text(Guid.Parse("7324742d-6b8c-4cca-af95-6da429d593c2"), "Bearing an orb of dragonkind earns you the enmity of all dragonkind forever because you profited from the enslavement of the dragon within the orb, even if you later lose the orb.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {            
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("818981d4-2d7e-4197-b0d3-52d093d8fc74"),
                Name = "Orb of Dragonkind",
                Hands = 1,
                Destruction = "An orb of dragonkind violently shatters and explodes when exposed to the Breath Weapon of a dragon who is a descendant of the dragon trapped within. The explosion deals damage as the 2-action activation above to all creatures within 90 feet.",
                Level = 25,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e71528ee-38f3-4ca7-80b9-f27866b446ba"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command")
                           .Frequency("Once per round.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("35383177-e9b5-4c4c-a49c-8d879c6714c9"), "You cast a 10th-level dominate spell (DC 40) on a dragon of the type associated with the orb within 500 feet, except the effect lasts for 1 month rather than unlimited. The dragon does not receive its status bonus to saving throws against magic. The dragon is then temporarily immune to further domination via the orb for 24 hours.");
                           });
                    })
                    .Add(Guid.Parse("2b62a10d-7c12-4736-9c0c-70c6c40e291a"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Frequency("Three times per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("526c3fe6-e4af-4ee5-be47-bc57a1a0e0d1"), "You breathe an elemental blast that deals 25d6 damage (DC 40 basic Reflex save) in either a 60-foot cone or a 100-foot line (your choice). The breath's damage type matches the Breath Weapon of the dragon type associated with the orb of dragonkind (acid for the black orb, electricity for the blue orb, and so on).");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fbb48d59-ae47-4698-a154-26fdb3cdb102"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("54be403d-4bdf-4b91-aa18-426ca8bdc012"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("9496ef9a-988b-4eb4-ad6c-a299d63c0dd6"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("3f8ae458-7d49-4918-a5cb-2ec1837fe2b0"), Traits.Instances.Enchantment.ID);
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
