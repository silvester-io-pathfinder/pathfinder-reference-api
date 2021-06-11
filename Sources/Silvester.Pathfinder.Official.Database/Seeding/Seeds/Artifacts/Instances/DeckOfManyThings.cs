using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class DeckOfManyThings : Template
    {
        public static readonly Guid ID = Guid.Parse("564a769a-4de0-403f-ab79-acdd44224011");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Deck of Many Things",
                Destruction = "Trick the Grim Reaper into drawing the Skull card.",
                Usage = "Held in 1 hand.",
                ItemLevel = 22,
                BulkId = Bulks.Instances.NegligibleBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9679dece-dc9f-4b26-99c8-a948042e8d9b"), Type = TextBlockType.Text, Text = "These 22 cards of heavy vellum, usually stored in a box or a pouch, bear images or glyphs depicting symbols of magical power. Looking at a card without activating it shows the card face but has no magical effect. Once the deck is face down, the cards randomize themselves—if you look at the top card multiple times, you may find it changes. Any card removed from the deck goes missing after a few seconds, reappearing in the deck." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("e833f07b-3c0e-400a-9d21-e568b2234a95"),
                Name = "Envision, Interact",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("b697d6ab-decb-4a53-a5ad-ae9df2f74733"), Type = TextBlockType.Text, Text = "You declare how many cards you will draw facedown from the deck, then draw your first card. The card takes effect immediately. Any further cards must be drawn within the next hour, and any card you don’t voluntarily draw flits off the deck and affects you anyway. You can never activate the same deck of many things again. Once a card is drawn, it produces its effect immediately and then disappears back into the deck, which immediately shuffles itself. (The Dullard and Jester are exceptions, as described in their entries below.) The effects of each card are as follows." },
                    new TextBlock { Id = Guid.Parse("71465159-4a85-4e6d-b4b9-aceb992b3e7a"), Type = TextBlockType.Enumeration, Text = "Balance - Your alignment changes to a radically different one. If you fail to adhere to that alignment, you lose a level and all the benefits you gained at that level. Your XP total doesn't change when you lose a level this way." },
                    new TextBlock { Id = Guid.Parse("d0c62ece-5781-47ef-ae80-516cd53284e5"), Type = TextBlockType.Enumeration, Text = "Comet - If you alone defeat the next low-threat or harder hostile enemy or enemies you encounter, you gain enough XP to reach the next level. Otherwise, you gain no benefit." },
                    new TextBlock { Id = Guid.Parse("ca6d0818-3323-4f4e-9247-f34f35ee54ab"), Type = TextBlockType.Enumeration, Text = "Donjon - You're imprisoned by a 10th-level imprisonment ritual. This uses the prison option, typically sequestering you in a distant part of the world. You also lose all your items. Cease drawing cards." },
                    new TextBlock { Id = Guid.Parse("d9b6215f-b5cb-4234-9519-d48256a195ec"), Type = TextBlockType.Enumeration, Text = "Dullard - Immediately reduce your Intelligence score by 1d4+1. You can then draw an additional card, and the Dullard card then disappears forever." },
                    new TextBlock { Id = Guid.Parse("43c6afc1-40f7-42ff-82f9-101f81635a04"), Type = TextBlockType.Enumeration, Text = "Euryale - (curse) A medusa's image curses you with a permanent –1 status penalty to all saving throws. This can be removed by only a deity or the Fates card." },
                    new TextBlock { Id = Guid.Parse("e7b2c9d7-5623-4ceb-ae21-e23bd60f0f2c"), Type = TextBlockType.Enumeration, Text = "The Fates - The Fates respin the fabric of reality to save you from any situation you choose. This can reverse even a past event, and you can make the decision instantly even if the event would slay you. This intervention saves only you, not anyone else affected by the event. There's no limit on how long you can wait before using this effect." },
                    new TextBlock { Id = Guid.Parse("67013058-c964-465c-be8a-ab662f3ed0b1"), Type = TextBlockType.Enumeration, Text = "Flames - A fiend becomes filled with anger, jealousy, envy, or some other reason to despise you. Its hatred for you doesn't cease until either it or you is dead. It attacks you or otherwise attempts to foil you within 1d20 days. The GM determines the specifics of the fiend." },
                    new TextBlock { Id = Guid.Parse("9a8139e2-2aa0-45cd-bccc-9331b15aec66"), Type = TextBlockType.Enumeration, Text = "Fool - You lose 1d10×100 XP unless you choose to draw two more cards." },
                    new TextBlock { Id = Guid.Parse("4491450d-2b0c-4f2b-9696-5af12e34f3ef"), Type = TextBlockType.Enumeration, Text = "Gem - Gain your choice of 25 pieces of jewelry worth 200 gp each or 50 gems worth 100 gp each." },
                    new TextBlock { Id = Guid.Parse("585c3a9c-3a4b-4413-9dd2-8a57b968bb53"), Type = TextBlockType.Enumeration, Text = "Jester - You can either draw two more cards or gain 1d10×100 XP. The card then disappears forever." },
                    new TextBlock { Id = Guid.Parse("265ec20d-9794-4491-ab84-ba051040dc9d"), Type = TextBlockType.Enumeration, Text = "Key - Gain a magic weapon of 12th level or higher. The GM determines the item and what runes it has, if any." },
                    new TextBlock { Id = Guid.Parse("f3441de6-b82a-47c4-8900-a40cfb05ceee"), Type = TextBlockType.Enumeration, Text = "Knight - A palace guard arrives and swears unfailing loyalty to you." },
                    new TextBlock { Id = Guid.Parse("c12386e0-788a-4870-97fd-cb6d076444d1"), Type = TextBlockType.Enumeration, Text = "Moon - Roll 1d4 to determine how many wishes the card grants you, which also affects the phase of the moon depicted on the card (1: crescent moon; 2: half moon; 3: gibbous moon; 4: full moon). These wishes each take one action to speak and have the effect of a wish spell." },
                    new TextBlock { Id = Guid.Parse("4e2985d4-0965-4fd3-a78c-c35166f48223"), Type = TextBlockType.Enumeration, Text = "Rogue - One NPC ally becomes filled with hatred and immediately turns against you forever. The NPC might keep this hatred secret until an opportune moment." },
                    new TextBlock { Id = Guid.Parse("9a3ecfc4-209f-42da-adbe-b0c0751e7f82"), Type = TextBlockType.Enumeration, Text = "Ruin - You lose all your nonmagical possessions, including any wealth and property." },
                    new TextBlock { Id = Guid.Parse("e1884dc4-e163-4c5f-8e87-f40f3058effa"), Type = TextBlockType.Enumeration, Text = "Skull - You must immediately battle a lesser death. If slain in the battle, you can never be revived, except by a deity." },
                    new TextBlock { Id = Guid.Parse("2c29c9ab-8e81-4835-8e59-b4517e609dfa"), Type = TextBlockType.Enumeration, Text = "Star - Gain an ability boost you must use immediately on one ability score of your choice." },
                    new TextBlock { Id = Guid.Parse("72f3de70-80b7-42e5-b5a1-8f3c0ac22484"), Type = TextBlockType.Enumeration, Text = "Sun - Gain 1,000 XP and a beneficial permanent magic item of 6th to 11th level, chosen by the GM." },
                    new TextBlock { Id = Guid.Parse("c387c5ec-78b3-46a9-95e4-c68a4c7fb7a5"), Type = TextBlockType.Enumeration, Text = "Talons - All your magic items disappear permanently, except for the deck and any artifact of higher level than the deck." },
                    new TextBlock { Id = Guid.Parse("4e729a2c-7537-4aec-981a-fb8fb0b4e1b7"), Type = TextBlockType.Enumeration, Text = "Throne - You gain a permanent +4 status bonus to Diplomacy checks, and you now own a small castle in any open area you wish. You must choose its location within 1 hour." },
                    new TextBlock { Id = Guid.Parse("afdc9b9a-6944-4b29-9fe3-9e3cd54e1eee"), Type = TextBlockType.Enumeration, Text = "Vizier - Upon request, you can learn the solution to any one problem or the correct answer to any one question, unless that information is obscured by a deity. This doesn't necessarily give you the means to act on that solution. You have 1 year to take the vizier's advice or lose its benefits." },
                    new TextBlock { Id = Guid.Parse("63a015d5-e196-4cd7-aebc-a8afcde821e3"), Type = TextBlockType.Enumeration, Text = "The Void - Your mind becomes trapped forever. This card is fickle, but it often throws the psyche into a prison in an object on a distant plane or planet. Wish or similarly powerful magic can reveal your psyche's location, but it doesn't bring you back. Your comatose body continues to function. Cease drawing cards." },
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b988d02-7eaa-4d5d-ab3d-5b7b75110617"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 107
            };
        }
    }
}
