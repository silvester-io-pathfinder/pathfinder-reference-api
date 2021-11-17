using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Poppet : Template
    {
        public static readonly Guid ID = Guid.Parse("3783c37f-1665-400a-84c4-af07bff3ffa5");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Poppet", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Burlap, Buttoneyes, Checker, Clockwhirr, Fivestitch, Nettle, Scramble, Stuffing, Taffeta, Tattercap"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("12cd50a1-bcb2-4e6d-8d3b-7576d93f4cae"), Type = TextBlockType.Text, Text = "Poppets are small, basic constructs that typically help their owners with simple tasks. Occasionally, poppets gain sapience, independence, and a spark of life. Elevated beyond mere helpers or playthings, these poppets are free to chart their own destinies." };
            yield return new TextBlock { Id = Guid.Parse("693e782a-6f3c-4c9d-bfb4-7246bdd8cc04"), Type = TextBlockType.Text, Text = "Most commonly made of cloth, wicker, and wood, poppets are among the simplest of constructs. They serve as helpers to fetch tools, clean dishes, tidy rooms, or perform other light tasks. Their size and appearance vary, but nearly all poppets appear humanoid in shape and between 1 to 3 feet tall. They're usually roughly made with button eyes sewn onto blank faces, strings of yarn in place of hair, and a simple dress or tunic made from coarse, cheap cloth. Wealthy families sometimes purchase poppets as toys, with their squishy bodies and stitched smiles, to keep their children company. Most poppets can't speak and lack the intellect to understand speech beyond preprogrammed orders. Poppets can become familiars, as presentedhere." };
            yield return new TextBlock { Id = Guid.Parse("389a91c2-0cc2-4509-93fb-c4f3592be066"), Type = TextBlockType.Text, Text = "Very, very rarely, a common poppet spontaneously manifests a spark of life—a tiny bit of life essence— and becomes a thinking, independent creature. These events are exceedingly rare; fewer than one in a thousand gain this spark. A poppet might manifest this life essence through a magical fluke in its construction, a brush with ephemeral spirits, or even the fervent wish of a loving child. Whatever their origin, the poppets described here as an ancestry have their own life and free will. They might consider their creators or former owners to be friends, but they acknowledge no one as their master and often leave comfortable homes or workshops to seek their place in the world." };
            yield return new TextBlock { Id = Guid.Parse("fc45f8a8-86da-484d-8364-ebcfce14e691"), Type = TextBlockType.Text, Text = "Sapient living poppets usually refer to themselves as “awakened” to indicate the moment they gained clear and true self - awareness.Poppets might talk about this event as the time they “popped up,” “woke up,” or “sparked alive.” Most poppets celebrate two special anniversaries each year: the day of their initial creation (which, for most poppets, they must learn secondhand or by studying their creator's records) and the day they awoke to true consciousness." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("8071b1be-7c3f-4cdd-8612-5d991d43d6d7"), Type = TextBlockType.Enumeration, Text = "Like surprising others with your unexpected cleverness and eloquence." };
            yield return new TextBlock { Id = Guid.Parse("744f8b3d-4e6c-464f-9b0d-f98c1eb484e1"), Type = TextBlockType.Enumeration, Text = "Seek out other self-aware beings that most people might overlook." };
            yield return new TextBlock { Id = Guid.Parse("650f8894-67d1-4917-bd52-0525d912c958"), Type = TextBlockType.Enumeration, Text = "Rely on your harmless appearance to trick others." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("e003ff99-fa1f-4508-81a4-35289ae891d8"), Type = TextBlockType.Enumeration, Text = "Mistake you for a toy." };
            yield return new TextBlock { Id = Guid.Parse("edb1cc5b-9e82-4270-8008-1fe69f3f1fde"), Type = TextBlockType.Enumeration, Text = "Doubt your ability to handle tasks that require any dexterity or complex thought." };
            yield return new TextBlock { Id = Guid.Parse("05e56260-07ff-4b93-b7af-913835689312"), Type = TextBlockType.Enumeration, Text = "Wonder whether your mundane form conceals other magical marvels." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("ded0d104-f6e8-41dc-bb49-308b80ef60d7"), Type = TextBlockType.Text, Text = "Living poppets are both humanoids and constructs, which gives them some of the benefits and drawbacks of each category. Their bodies are usually made of wood and wicker, but they can be made of cloth, leather, tin, stuffing, or delicate clockwork. Either way, poppets burn or melt quickly and must take care to avoid fire. They virtually never look alike, as each is created from unique and unusual circumstances." };
            yield return new TextBlock { Id = Guid.Parse("0ef6b0d3-7e4d-4351-bed4-7a7c6587d097"), Type = TextBlockType.Text, Text = "Poppets are fully alert and self-aware when they awaken to sentience; although they might not know much at first, they instantly gain intelligence and consciousness. They must breathe and sleep, and they must consume food and water each day; through a sort of magical digestion they can restore rips, tears, or scuffs in their physical form. Poppets don't age the same way fleshy creatures do, but they slowly wear down in physical form as well as in mental acuity. A poppet that tends to their body and mind (and takes care to avoid fire) can live up to 30 years." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("c3fa40d1-d8d6-4a84-b8cc-8ba05997c009"), Type = TextBlockType.Text, Text = "Free-willed poppets are so rare that almost no such poppet has met another. Poppets normally live with larger creatures, though not always their creators, and tend to get along well in societies sized for larger creatures. Most live in cities because that's where toy makers, clockwork crafters, and other specialists have their shops, but poppets created by lonely hermits or reclusive inventors might prefer a life in the wilderness." };
            yield return new TextBlock { Id = Guid.Parse("ba0cd81a-4f06-4243-829b-9ae16cfe8946"), Type = TextBlockType.Text, Text = "Poppets often stay on the lookout for other creatures who, like them, have stumbled into self-awareness. They might have regular conversations with animated objects, golems, houseplants, statues, or toys, in which they're deeply polite out of a desire to leave a good impression for the time when the object “wakes up.”" };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("8c244e1d-471c-4e9f-9cfb-d00aeebefe9a"), Type = TextBlockType.Text, Text = "Ordinary poppets are built as helpers and companions, and awakened poppets tend to retain this drive to aid others. They're therefore generally good, and more poppets are lawful than chaotic. Some spend their time trying to uncover secrets of their creation, find others like them, or keep out of trouble; these poppets are generally neutral in alignment. Poppets aren't typically religious unless a particular faith defined their creation, such as being made from scraps ofIomedaeanaltar cloth or woven from reeds around a sacredGozrenpool. These poppets tend to be vocally religious, even zealous, in their faith. Poppets who find religion later in their lives often revereBrigh,Casandalee, orNethys." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("dfb32c90-da40-43af-b250-bea5b84a7789"), Type = TextBlockType.Text, Text = "Poppets like helping others and experiencing new things; both of these motivations lead naturally into the life of an adventurer. They aren't generally driven by a lust for treasure, but they like adorning themselves with pretty accoutrement and using their finds to better the lives of others. Theacolyte,entertainer, andlaborerbackgrounds are good choices for many poppets, as arecook,scavenger, andservant. Poppets who watched their creator work might have theartist,hermit, ortinkerbackground to reflect what they've seen. Because poppets like to help others, they gravitate toward becomingbardsorchampions. Some might think that poppets' small size and general clumsiness make them poorfightersorrangers, but certain poppets embrace these classes out of a drive to display their bravery and prove the naysayers wrong." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("840e9cf3-3fc4-447d-9239-63ea5b02f360"), Type = TextBlockType.Text, Text = "Poppets generally choose their own names, usually descriptive nicknames based on their materials, patterns, size, or demeanor. They tend to pick up and shed nicknames throughout their lives, and they happily adopt nicknames given to them by people they like. A poppet fashioned to look like a particular person, such as a doll sewn to resemble a deceased child, might proudly take the name of that person." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("8a43c03b-2cb6-4d40-ae94-521879376d39"), Type = TextBlockType.Heading, Text = "Poppet Motives" };
            yield return new TextBlock { Id = Guid.Parse("f7e1cc15-0117-44cd-86d1-4b25dd6f2a19"), Type = TextBlockType.Text, Text = "Nearly all poppets are interested in helping others and finding more creatures like themselves, and both these motivations are excellent for adventure. Yet, a poppet might have any number of other, more personal motives. A poppet might adventure to find a cure for a terminally ill creator, carry out the dying wish of a deceased friend, or complete the life's goal of a spirit that awakened within them, even if the poppet doesn't know who that person was in life. A poppet might take up arms to rescue kidnapped friends or save endangered children. Poppets aren't often greedy, but some might adventure to adorn their simple forms with gemstone eyes, golden thread, or other flashy accoutrements." };

            yield return new TextBlock { Id = Guid.Parse("871c13aa-0b1a-4be1-9ee0-aafc649d0890"), Type = TextBlockType.Heading, Text = "Poppet Settlements" };
            yield return new TextBlock { Id = Guid.Parse("b4f7043f-763f-477f-924a-12d256020ac5"), Type = TextBlockType.Text, Text = "Poppets don't often meet another of their kind, much less settle down together. Poppet-only settlements simply don't exist or are so remote as to be wholly unknown. Instead, poppets are most common in large cities, surrounded by the bustle of crowds. Any place where people appreciate skilled artisans, whether in cloth or clockworks, is a good place to find simple poppets, and thus awakened poppets are more likely to be found in bigger cities like Absalom, Katapesh, and Quantium. Poppets usually have a network of allies to draw upon in their communities; for many poppets, this network includes their creator and their creator's associates, but even poppets who don't know their creator tend to make themselves useful and liked." };

            yield return new TextBlock { Id = Guid.Parse("87571ad5-e72b-44ae-b474-b6955e941ed6"), Type = TextBlockType.Heading, Text = "Reactive Charm" };
            yield return new TextBlock { Id = Guid.Parse("22526fb1-17a8-4cc4-846c-89b47ffaf0e2"), Type = TextBlockType.Text, Text = "It might seem strange to picture a poppet walking into a general store to buy rope and jerky, but such occurrences aren't uncommon in urban areas. Poppets are, after all, designed to handle mundane tasks, so people aren't likely to call attention to a poppet going about routine business in such communities. People might even help the poppet out by leaning a plank so it can reach a counter or adjusting a heavy load—thinking that, by doing so, they're aiding a powerful or influential owner. Talk is likely to circulate, however, if the poppet is active in a small settlement where such helper constructs are unknown, or if the poppet is engaged in some truly unusual tasks, like giving a speech or dragging in a slain monster for a bounty." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("24f85d1b-ec96-4136-b7b4-a85bc87fe91e"), Type = TextBlockType.Heading, Text = "Constructed" };
            yield return new TextBlock { Id = Guid.Parse("9783a522-61f6-4cb9-a5ca-5b226197bd2e"), Type = TextBlockType.Text, Text = "The materials of your body resist ailments that assail the flesh. You gain a +1 circumstance bonus to saving throws against death effects, disease, and poison as well as to saving throws against effects that would give you the drained, paralyzed, or sickened conditions. Your spark of life means that you're a living creature, and you can be healed by positive energy and harmed by negative energy as normal." };

            yield return new TextBlock { Id = Guid.Parse("b40c122f-aff5-4f70-995e-45eb18483875"), Type = TextBlockType.Heading, Text = "Flammable" };
            yield return new TextBlock { Id = Guid.Parse("41348e36-95d5-4a68-a94e-ebd76fafce8a"), Type = TextBlockType.Text, Text = "You have weakness to fire damage equal to one-third your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Construct.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("d3c89047-93db-4a4b-95a1-dda6f0e523a9"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("957f89da-c637-41d6-86aa-37c173fe08a8"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("38ec49ea-3a55-41e0-a709-a4be9c170c10"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("38d71e2d-34af-452f-8a50-47b84a40d935"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("3e987b4d-cccb-4e60-bfbd-df339dc0f000"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("97b7a396-0b86-4b04-b347-bbe3626f7dc0"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificLanguage(Guid.Parse("314c42fc-5cfd-45b1-acf3-20ce235acba4"), Languages.Instances.Common.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("5a68553d-b117-40cd-a787-cc9efcac36c3"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.GainSpecificDamageWeakness(Guid.Parse("202e9810-86e0-4d66-ab65-2d72cd6a73d8"), DamageTypes.Instances.Fire.ID, ModifierType.Divide, modifier: 3, minimum: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ec4bbc6-3a6d-47a5-b28c-16a7be13444f"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 60
            };
        }
    }
}
