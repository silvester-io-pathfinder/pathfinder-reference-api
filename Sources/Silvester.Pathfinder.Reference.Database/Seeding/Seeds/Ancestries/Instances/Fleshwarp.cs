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
    public class Fleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("762e407c-f7f6-45e5-b96b-ced2482b1f76");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Fleshwarp", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Borble, Dag, Feff, Hurn, Kemp, Omber, Ostro, Shurni, Surm, Wumpin"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("1af885ac-520f-4e8d-9187-d33e03b4265d"), Type = TextBlockType.Text, Text = "Fleshwarps are people whose forms were created or radically transformed by magic, alchemy, or unnatural energies. Their unorthodox appearance can make it difficult for them to find a place for themselves in the world." };
            yield return new TextBlock { Id = Guid.Parse("1cee5b2b-9998-44a0-88d3-94ce47587c66"), Type = TextBlockType.Text, Text = "Magic and science that can warp bone and twist sinew are all too common on Golarion. Fleshwarps are those who have been permanently altered by such methods—sometimes a sapient being created whole cloth from inanimate flesh, but often a victim unwillingly transformed by strange energies or sadistic creators." };
            yield return new TextBlock { Id = Guid.Parse("d954382f-4840-45b4-bdbb-8e0bc6c16a5a"), Type = TextBlockType.Text, Text = "The ancestry name “fleshwarp” is an umbrella term, since on Golarion the actual fleshwarping process is more infamously well-known than are alterations caused by uncontrolled magic, technology, or fringe science. Whether practiced by Thassilonian wizards, Nexian fleshcrafters, or the drow of the Darklands, fleshwarping is the craft of reshaping flesh and mind in vats of foul magical reagents. This has led some scholars of monsters to argue that only those beings created by traditional fleshwarping should be considered fleshwarps. Regardless of the source of their altered forms, fleshwarps bear their new shape forever, transformed beings living a wild and strange existence beyond what was possible for their original ancestry." };
            yield return new TextBlock { Id = Guid.Parse("5fb0b888-deed-4686-a756-207ce67c5564"), Type = TextBlockType.Text, Text = "Although fleshwarps are humanoid, no two look the same. One might possess limbs in unusual places and skin as smooth as glass, while another might have a thick matting of spiny fur. Some might have animalistic features, like a boar snout, scales, or cloven hooves. Others have entirely alien appearances, such as bulging eyes on the backs of their hands. Some may have only subtly uncanny features that differentiate them, such as glowing teeth, smoking eyes, or fingernails made of bone. The only commonality among fleshwarps is their mismatched nature. Let your imagination run wild when creating a fleshwarp character!" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is tough and hardy, can change their form as they grow, and can use their wholly unique appearance to inspire awe or fear in others, you should play a fleshwarp." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("0e2aafff-4e94-41a4-9bc8-962f5395f90e"), Type = TextBlockType.Enumeration, Text = "Embrace your unusual appearance to inspire respect or fear." };
            yield return new TextBlock { Id = Guid.Parse("5a200c44-cb85-4447-99a2-876b0786af34"), Type = TextBlockType.Enumeration, Text = "Be used to relying on yourself." };
            yield return new TextBlock { Id = Guid.Parse("eb50ffd9-172a-44c7-893c-731fe4b1f14f"), Type = TextBlockType.Enumeration, Text = "Distrust large groups of people, particularly mobs, based on past experiences." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("39e3a997-4bbe-409f-a6b5-9828952709f6"), Type = TextBlockType.Enumeration, Text = "Find your physiology fascinating or terrifying." };
            yield return new TextBlock { Id = Guid.Parse("5b24bc76-bf19-449e-a3db-c963000e6261"), Type = TextBlockType.Enumeration, Text = "Assume you are an expert on strange creatures or occult phenomena." };
            yield return new TextBlock { Id = Guid.Parse("a6dff438-fc7f-461f-ab8e-c0036543394f"), Type = TextBlockType.Enumeration, Text = "Consider you an enigmatic and unpredictable—and perhaps even dangerous—outsider." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("0549c8d2-f0d1-4bcb-a264-4257af692f9d"), Type = TextBlockType.Text, Text = "Fleshwarps are humanoids, ranging from 5 to 7 feet tall and from just under 100 pounds to more than 300 pounds. The proportion and appearance of their limbs and features differ widely, but fleshwarps functionally have two legs, two arms, and a single head; a fleshwarp with more limbs than this should consider an appropriate ancestry feat to reflect this variance, or one of their limbs might be vestigial and mostly nonfunctional. Fleshwarps differ widely in their appearance due to the unique circumstances of their creation. Even fleshwarp siblings or two people transformed through the same procedure might look wildly different." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("cc8beed1-baeb-40b1-9f65-9683e904ae86"), Type = TextBlockType.Text, Text = "Fleshwarps are so few in number that congregations of them are rare. They most often live on their own, with a small family group, or at the outskirts of a community. Some thrive in cities, however, where they can remain anonymous among the crowds while pursuing careers that allow them to avoid contact with people who might fear or persecute them." };
            yield return new TextBlock { Id = Guid.Parse("4c674966-e729-4445-9272-ad877f05add1"), Type = TextBlockType.Text, Text = "Fleshwarps value endurance and are quick to learn from others, so those who come into contact with others of their kind usually share stories that help each other survive, hide, or thrive more effectively. How a fleshwarp formed can be a painful or horrifying subject, one they consider rude to discuss with anyone besides close friends or loved ones." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("b6b35c8d-142e-48f4-8ec8-ab2ad3329cc1"), Type = TextBlockType.Text, Text = "Fleshwarps have little to gain from the broader society, and therefore rarely work to support society in turn, beyond perhaps helping other fleshwarps. They need to be able to adapt quickly to survive on their own. As a consequence, few fleshwarps are lawful. Although bigoted or short-sighted people view fleshwarps as monsters, fleshwarps are no more or less prone to evil than any other people, and most seek only to live their lives without trouble. Most are neutral in alignment, for while alienation doesn't force a fleshwarp to feel contempt for others, neither does it encourage a fleshwarp to avoid it. This is especially true for fleshwarps living in the societies that gave birth to their traumatic transformation. Fleshwarps aren't often casually religious; most either have little to do with faith at all (viewing themselves as scorned by the gods or simply seeing faith as impractical for survival) or are exceptionally devout. Religious fleshwarps often revereArazni,Calistria,Desna, orGozreh; evil fleshwarps typically turn toLamashtu, finding consolation in the Mother of Monsters." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("485520b7-8979-41a2-84d3-b5c471c562f1"), Type = TextBlockType.Text, Text = "Fleshwarps often live on the margins of society. Thehermit,hunter,nomad, orstreet urchinbackgrounds work well for many fleshwarps; others might becriminals,entertainers, orprisoners. The need to defend themselves leads many fleshwarps to becomebarbarians,fighters,rogues, orrangers.championsanddruidsare common callings among fleshwarps who seek to defend and better the lot of others of their kind." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("992a3804-0383-4d18-87a0-464b21adea59"), Type = TextBlockType.Text, Text = "Fleshwarps can come from—and thus have names from—any culture or ancestry, but some give themselves new names after being transformed, whether to celebrate the change, recognize a new phase of their lives, or conceal their past identity. Many fleshwarps also carry a descriptive nickname granted to them by others, such as “Triple Handed,” “Barkfoot,” or “Many-Mouth.” Fleshwarps don't keep nicknames they find personally offensive, but they tend to keep ones that describe their distinctive appearances or that are given by people they care about." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Fleshwarp Legends" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Legends of famous fleshwarps travel quickly amid fleshwarp communities." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Lady Kedley: A wealthy noble in a life she doesn't remember, Kedley emerged transformed from deep below Westcrown. She uses her family's vast fortune to aid other fleshwarps." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Spinhead Vanluk: This Mana Wastes warlord brings mutants and fleshwarps under his banner. He (literally) has eyes in the back of his head." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Fleshwarp Motives" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Fleshwarps have a variety of reasons for taking up the life of an adventurer. Some are turned out of their homes by an uncaring parent or a suspicious mob. Other fleshwarps travel to learn more about their own transformation or to seek out others of their kind. A few even actively seek the means—either technological or magical—to undo their transformations or adopt a new form that won't incite repulsion or fear in common people. Still others understand that a good way to earn respect is to solve a community's problems—then quickly leave the area—and therefore fall into the role of itinerant adventurers-for-hire." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Fleshwarp Settlements" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "No settlements consisting entirely of fleshwarps exist openly outside of the Mana Wastes; elsewhere, citizens keep the secret so well that their community's existence isn't known to the world at large. Fleshwarps are more likely to live on the fringes of other settlements, working in industries where their hardy constitution is an advantage and their uncanny appearance isn't a liability. Some are herbalists or trappers, working in the wilderness and interacting with others only rarely. Locals might come to consider a fleshwarp their equal or friend, and take umbrage at outsiders who make a big deal out of the “monster” in their midst. Sentiment might turn quickly upon supernatural events or strange attacks, however, and, tragically, more than a few fleshwarps have been turned out of homes they've occupied for decades when faced with a misguided mob." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Unusual Anatomy" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your unorthodox body resists physical afflictions meant for other creatures. You gain a +1 circumstance bonus to saves against diseases and poisons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Abberration.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("a2c0ad5d-b0e8-4a3c-81e9-7d6a6a4264c3"), ModifierType.Add, modifier: 10);
            builder.ModifySpecificSpeed(Guid.Parse("e69f83b4-3f78-4b98-b799-365b510c127c"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("2ebe447b-3f27-417b-99b7-55dbbc4ad3dd"), Stats.Instances.Constitution.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("99ac1955-5b38-413d-9ed9-937eafd1871b"));
            builder.GainSpecificLanguage(Guid.Parse("dba7a4fc-8c84-42f7-a5a0-92434469565f"), Languages.Instances.Common.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add circumstance bonus.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb07ce2d-686a-4270-849c-e32f40c82dc5"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 89
            };
        }
    }
}
