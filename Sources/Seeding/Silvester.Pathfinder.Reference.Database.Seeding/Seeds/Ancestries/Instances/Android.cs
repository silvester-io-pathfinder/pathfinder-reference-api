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
    public class Android : Template
    {
        public static readonly Guid ID = Guid.Parse("ee7d3cc2-6e7c-41ec-91a3-7db1a083998e");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Android", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Anati, Daniv, Era-4, Feralia, Gelegor, Ilgos-5, Koresh, Oris, Prime, Urdun, Verity-3, Ymry"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("a60140f8-da84-461e-b483-a7e9711cc22e"), Type = TextBlockType.Text, Text = "Technological wonders from another world, androids have synthetic bodies and living souls. Their dual nature makes them quick-thinking and calm under pressure, but comfortable in stillness and solitude." };
            yield return new TextBlock { Id = Guid.Parse("ff6a3d06-5b08-41a7-b75b-ca269ef54a7f"), Type = TextBlockType.Text, Text = "Androids first arrived on Golarion during the Rain of Stars, when an interstellar vessel from the far-off planet of Androffa crash-landed, scattering debris across Numeria. While some android survivors of this crash still walk Golarion today, most were created from the technological pods, known as foundries, that operate sporadically amid the starship's wreckage. Androids birthed from these mechanical wombs possess mature bodies and newborn souls, both organic and synthetic; they emerge knowing only their creators' language and the motor skills necessary for survival. They have no understanding of their surroundings, origin, or purpose. Most learn how to behave through keen observation while wandering Numeria." };
            yield return new TextBlock { Id = Guid.Parse("9f08d187-969f-429b-9c66-bbd8bc09ce16"), Type = TextBlockType.Text, Text = "Androids tend to be logical introverts, rational and contemplative. Insatiably curious, with an urge to understand themselves and the world around them, androids place great value on intellectual pursuits. They have difficulty interpreting and expressing emotions, both in themselves and in others, which makes them seem distant and uncaring. While androids can forge emotional bonds, they find it more difficult to connect with non-androids." };
            yield return new TextBlock { Id = Guid.Parse("0091d90c-666c-48fd-80ab-ae05763c444d"), Type = TextBlockType.Text, Text = "If you want a character that's a synthetic foreigner in a fantastic world, forced to learn the nuances of reality and society through the powers of observation and logic alone, you should play an android." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("5b8a2654-49ee-4bbc-98cd-a0be3bf55209"), Type = TextBlockType.Enumeration, Text = "Keep your identity a secret, assuming others want to exploit or harm you." };
            yield return new TextBlock { Id = Guid.Parse("6f800cb2-3cb0-4b1a-b9ba-8951464d449c"), Type = TextBlockType.Enumeration, Text = "Plan ahead, preparing multiple contingencies for even simple tasks." };
            yield return new TextBlock { Id = Guid.Parse("e7c60e76-14e2-4796-8067-c7f953b1e69c"), Type = TextBlockType.Enumeration, Text = "Calculate the repercussions of your actions, inventions, and thoughts before sharing them." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("8e444da3-5ec4-47a0-93e5-8e9e97f1c4d2"), Type = TextBlockType.Enumeration, Text = "Assume you understand how to operate technology and that you can capably communicate with constructs and robots." };
            yield return new TextBlock { Id = Guid.Parse("ba26b735-0d4b-41d5-a3a2-545dc07a87c6"), Type = TextBlockType.Enumeration, Text = "Believe you to be immortal and envy your eternal youth and vigor." };
            yield return new TextBlock { Id = Guid.Parse("07ff747c-79e1-4685-8690-9ef852c926d6"), Type = TextBlockType.Enumeration, Text = "Think you have no feelings and that you can't form emotional connections with others." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("b17c730e-f2aa-44a0-92f5-3bdfeb469a71"), Type = TextBlockType.Text, Text = "Androids were created in humanity's image; thus, foundries produce androids that represent all humankind. Androids display great diversity in coloration and ethnicity, height and body shape, and gender identity. Androids breathe, eat, and sleep like a human, although they're incapable of biological procreation. Their bodies contain microscopic nanites, transported by fluid too watery to be blood, that manage their organic processes. These nanites are controlled through biological circuitry that resembles tattoos and is typically located along an android's hands, forearms, face, or neck. Many androids can harness their nanites to increase their bodies' efficiency, causing the circuitry to glow." };
            yield return new TextBlock { Id = Guid.Parse("f6422fbf-76b7-4985-8d9b-48de80f0d141"), Type = TextBlockType.Text, Text = "Androids don't grow old. Instead, their organic appearance becomes less convincing over time, causing them to look more artificial. After a century, most androids feel their time coming to an end and willingly release their souls to theBoneyardto facePharasma'sjudgment. Their bodies then shut down, entering a lifeless hibernation as their nanites begin restoration protocol and reset their synthetic bodies to their original manufactured state. After a few weeks, a new soul enters the android's form, triggering reinitialization. This process, called Renewal, is an event to be celebrated, akin to bearing a child. Those that die by violence can't Renew, so androids go to great lengths to protect themselves and their brethren from harm." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("af77111a-d4fb-4392-a556-c9724b995100"), Type = TextBlockType.Text, Text = "Androids have a history of being exploited, enslaved, and destroyed by their Numerian neighbors, so they hide in order to survive. Most choose to keep their ancestry secret by integrating into human society or by adapting to a nomadic lifestyle. Some androids eschew humanity to live among their kind. Such groups often remain small by necessity; while a pair of androids can avoid danger through careful secrecy, large groups attract too much attention." };
            yield return new TextBlock { Id = Guid.Parse("6e0f40f1-54d3-4529-879a-c409aff3b799"), Type = TextBlockType.Text, Text = "Android communities are efficient and highly organized. Each citizen understands their role and takes pride in filling it effectively. Debates and lectures frequently occur, as androids seek to understand themselves and their world through education and inquiry. These insular and secretive enclaves relocate when discovered." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("3a017df9-64b6-4c9c-b5a8-a7148b5bbe91"), Type = TextBlockType.Text, Text = "Most androids are neutral. They care for their own safety and that of their companions and their kind. Androids interested in religion usually worshipCasandaleeorBrigh, goddesses that unite invention and life. Other popular deities includeDesna,Irori, andGozreh." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("19306e7a-8677-4888-88e3-ebe6c98e5abd"), Type = TextBlockType.Text, Text = "Most androids become adventurers to protect their kin from harm or to research the history of their people, typically by exploring technological ruins. Androids survive through deception, stealth, and subterfuge, which leads many down the path of therogue. Others embrace their thirst for knowledge and understanding by becomingalchemists,monks, orwizards. Typical android backgrounds includehermit,nomad,scholar, andtinker." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("c0ed813b-4330-4419-bfee-34339a57e855"), Type = TextBlockType.Text, Text = "Androids adopt the naming conventions of their surrounding societies, while those raised among their own kind instead select a single name that utilizes Androffan phonology. Occasionally, such androids add a numerical designation to their names, denoting how many generations their body has hosted life as a kind of homage to their bloodline." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("c4bfa22c-9bec-4601-aadd-f4a057c1775e"), Type = TextBlockType.Heading, Text = "Android Settlements" };
            yield return new TextBlock { Id = Guid.Parse("9f300323-1845-46a9-8de1-37dcef591429"), Type = TextBlockType.Text, Text = "Androids are primarily found in Numeria, where they hide among humans or travel as nomads. A large number live openly in Starfall under the protection of the Black Sovereign. The slopes of Silver Mount house multiple android enclaves and archaeological teams, including Enseffa, the center of Androffan society. In the town of Hajoth Hakados, the locals help androids secretly flee Numeria for lands where they face less hatred. Hidden in a series of tunnels and caverns beneath the Numerian Plains, the androids of Szamrak's Haven believe androids are a superior life-form. They hunt for foundries with the intent of liberating all androids, conquering Numeria to found an android-only nation, and eventually returning their people to their home amongst the stars." };
            yield return new TextBlock { Id = Guid.Parse("9423ee71-95b1-4b81-b06e-62dca7d70f1a"), Type = TextBlockType.Heading, Text = "Casandale and Androids" };
            yield return new TextBlock { Id = Guid.Parse("4e35b26e-7ce3-496e-90d8-7e1eab1661f5"), Type = TextBlockType.Text, Text = "Once an artificial intelligence cloned from the mind of an alien android, Casandalee recently ascended as the goddess of artificial life, free thinking, and intellectual apotheosis. Despite the small size and relative obscurity of her religion, the androids of Numeria have embraced Casandalee as their own. They seek to better bridge the gap between artificial and organic lifeforms, thereby improving the lives of androids." };
            yield return new TextBlock { Id = Guid.Parse("e2631581-766b-4600-8fd0-e6a32b2204f7"), Type = TextBlockType.Heading, Text = "Thoughts on Androids" };
            yield return new TextBlock { Id = Guid.Parse("7057362a-4ba4-4bdb-831d-4dfe857882f5"), Type = TextBlockType.Text, Text = "Other people view androids through a lens of magic and superstition. Most consider androids eccentric spellcasters, often confusing them with tattooed Thassilonian wizards. Others see an android's glowing circuitry and assume they're planar scions. In the River Kingdoms, androids are often thought to be fey that imperfectly took on human form and thus can't stand the touch of cold iron. Peoples in Ustalav frequently confuse androids for spirits, believing they can be held back by salt circles or banished through pious prayers." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("855956b2-48f0-4534-a29a-7c0be3b4f3e9"), Type = TextBlockType.Heading, Text = "Constructed" };
            yield return new TextBlock { Id = Guid.Parse("d7a28af9-57b1-43d4-80d7-67af9581089a"), Type = TextBlockType.Text, Text = "Your synthetic body resists ailments better than those of purely biological organisms. You gain a +1 circumstance bonus to saving throws against diseases, poisons, and radiation." };

            yield return new TextBlock { Id = Guid.Parse("7fb30a88-a990-4b16-81a7-8f4845075e19"), Type = TextBlockType.Heading, Text = "Emotionally Unaware" };
            yield return new TextBlock { Id = Guid.Parse("467a9315-7a6a-4281-ba64-48d98f37bfa7"), Type = TextBlockType.Text, Text = "You find it difficult to understand and express complex emotions. You take a �1 circumstance penalty to Diplomacy and Performance checks, and on Perception checks to Sense Motive." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Android.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("eed233e2-e035-4822-88ce-e98b8e2e0599"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("56a97a14-5b46-4c3b-91ee-8dd53ef7b692"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("ffc6333c-be60-421e-807d-fcf4c8a92194"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("2daef153-f0e5-4bf5-baeb-0fd3bdf264c7"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("be5f1dd3-e36e-4f3f-84d7-ef00c588ef07"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("005a85d5-6c93-49da-b0a6-b834e900f3df"), Stats.Instances.Charisma.ID);
            builder.GainSpecificLanguage(Guid.Parse("a615dffb-97cf-4d92-bf55-a79efafb2227"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("70fc17cf-cbf7-435b-a8ee-de7b41470a0a"), Languages.Instances.Androffan.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("9423e0b2-864e-4683-a90e-6e2c8a0f8b85"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add circumstance bonus.
            //TODO: Add circumstance bonus.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6f0b0fa-454f-4284-9fcb-ec05ae81da39"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 69
            };
        }
    }
}
