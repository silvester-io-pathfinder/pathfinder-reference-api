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
    public class Fetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("89519751-8efd-4a0a-aa16-57966b91d4b5");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Fetchling", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Amelisce, Ashka, Drosil, Eitsanara, Eomva, Ikyamek, Inva, Jegan, Lirtae, Meotrai, Sorsul, Zokaratz"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("7110cf18-d00b-4b94-b7dd-0059c8e01faa"), Type = TextBlockType.Text, Text = "Once human and now something apart, fetchlings display the Shadow Plane's ancient influence through monochrome complexions, glowing eyes, and the casting of supernatural shadows." };
            yield return new TextBlock { Id = Guid.Parse("eab5593c-05a7-4e8f-a76e-94b24e4edba7"), Type = TextBlockType.Text, Text = "Fetchlings are a striking people whose skin appears entirely drained of color. These lithe and shadowy beings seem to sink and vanish into the gloom. They see in darkness, exercise control over shadows, and have strange occult powers. Some fetchlings develop their powers enough to pass between theShadowandMaterial Planes, leaving other ancestries to whisper about figures that emerge from shaded corners and then vanish without a trace. Through magic and other means, they've spread across Golarion and the planes beyond, as adaptable as the humans they once were." };
            yield return new TextBlock { Id = Guid.Parse("87ee8f65-b08c-4a8c-b907-96f066c51450"), Type = TextBlockType.Text, Text = "The first fetchlings were refugees. Ages ago, when Earthfall destroyed ancient Azlant and cast the world into darkness, one small group of Azlanti pleaded for rescue. A mysterious hooded figure known as the Widow answered their call, slicing open a passage into the Shadow Plane. The Azlanti stepped through, trading the darkness of Earthfall for a deep shadow. As they navigated the plane's strange environs and dangerous inhabitants, its nature slowly worked monumental changes on the survivors." };
            yield return new TextBlock { Id = Guid.Parse("9b56dcb8-570c-46fd-9a00-5bf85cb58b4e"), Type = TextBlockType.Text, Text = "If you want a character more at home in a mirror world of shadow, infused with umbral gloom, and who embodies the dualities of light and darkness, you should play a fetchling." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("b87a66ae-075f-480b-9e55-98e1eb3b8bb1"), Type = TextBlockType.Enumeration, Text = "Live and work in gloomy areas of dim light with plenty of shadows, only providing bright light when expecting visitors." };
            yield return new TextBlock { Id = Guid.Parse("0aad9220-6cf7-44cd-a767-e8abb6264dc3"), Type = TextBlockType.Enumeration, Text = "Look to people's shadows as a way of identifying them, alongside features like stature or facial structure." };
            yield return new TextBlock { Id = Guid.Parse("13265e74-81cc-40a2-bb71-aba1aba992bf"), Type = TextBlockType.Enumeration, Text = "Maintain composure when faced with strange creatures and circumstances." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("731ee263-5b1b-4388-9d58-e25effd99746"), Type = TextBlockType.Enumeration, Text = "Believe you have shadowy powers, such as the ability to consume light as food, melt into darkness, or travel between planes." };
            yield return new TextBlock { Id = Guid.Parse("3b6d8f6c-2a02-4df6-80bf-14a91ba7b65f"), Type = TextBlockType.Enumeration, Text = "Expect you to be cautious, reserved, and a loner." };
            yield return new TextBlock { Id = Guid.Parse("eb5e83f2-532e-48a7-9c95-90eb792f6746"), Type = TextBlockType.Enumeration, Text = "Express interest in your ancestral physiological connection to the Shadow Plane." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("ae3a8cbe-56e7-4b98-947c-0eeb2a1f975e"), Type = TextBlockType.Text, Text = "Most of theShadow Planeappears as an altered version of theMaterial Planebut leeched of color. These same forces in the Shadow Plane have touched fetchlings, whose skin tones fall on a monochromatic scale from stark white to deep black, and all the shades of gray between. Their bodies are just as diverse in shape and size as humans, though most display a certain fluidity of motion reminiscent of shifting shadows. Fetchlings' reflective, pupilless eyes can pierce darkness. A fetchling's most notable feature is their shadow, which almost never faithfully reflects their body. Instead, fetchling shadows might have incongruous shapes or sizes, while others flicker, move of their own accord, or imitate the shadow of another nearby creature." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("e61bcbb3-8c1a-4884-b1c3-f46fbfe7a710"), Type = TextBlockType.Text, Text = "Most fetchlings remain close to Golarion on either theMaterialorShadow Planes, either forming majority-fetchling communities or forging solitary paths. Both planar groups tend to be insular; many fetchling cultures preserve memories of their early, perilous days confronting the Shadow Plane's hostile or beguiling denizens. Their predilection for forming tight communal bonds and adapting to local customs has spread to become part of broader fetchling culture, reinforced by two major fetchling groups—the Estlaris and Sharedars—who live in the shadow of more powerful entities." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("a1bd64ee-24db-4cbc-b613-0cfc9eff2917"), Type = TextBlockType.Text, Text = "A culture of survival passed down through generations means many fetchlings prefer to maintain a cautious worldview and adapt to prevailing circumstances. As a result, many trend toward a neutral outlook on life. Some choose to join with local powers for personal or communal advancement, or to tear systems down from the inside. Others attempt to shatter what they see as fetters that bind them and their communities." };
            yield return new TextBlock { Id = Guid.Parse("9f8cd618-4723-41da-a874-6fb59ec29962"), Type = TextBlockType.Text, Text = "No small number of fetchlings are nonreligious, recognizing all gods' powers but revering none. Faithful fetchlings prefer gods that offer protection and stability, be it the pastoral embrace ofErastilor the binding chains ofZon-Kuthon. Those who travel alone or pass between planes seek the comfort ofAlseta,Desna, andGozreh.Calistriaappeals to ambitious fetchlings, whileGrandmother SpiderandSivanahhelp those who wish to move through the world unnoticed or unfettered. Some worship these three as a pantheon called the Laughing Veil; a few even includeNorgorberas a fourth member." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("3199cef2-18a2-448d-a6a5-a92922bee5ea"), Type = TextBlockType.Text, Text = "Fetchlings have a well-earned reputation as travelers. Theirmerchantsandemissariesply many roads, whilenomadsandsailorsseek what lies over the next horizon.Charlatans,criminals, andstreet urchinscarve livelihoods from inhospitable environs. Many fetchlings leverage their natural litheness asswashbucklersorrogues. TheShadow Plane'scaress awakens hidden power in many fetchlingbardsorsorcerers(especially those of the shadow bloodline) or drives them to study deeper mysteries aswitchesorwizards" };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("b88dd275-aae7-4b92-a72e-f06d31019adb"), Type = TextBlockType.Text, Text = "Fetchlings adapted to a new world, and their names do the same. These names commonly include phonetic qualities from multiple languages or are simply local cultural names that fetchling families find compelling. Other dominant naming conventions include flowing sounds, harsh or hissing consonants, and surnames that refer to important relatives or community traits." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("265b5a5d-e45e-4853-bad7-0b78eb3c266d"), Type = TextBlockType.Heading, Text = "Fetchling Settlements" };
            yield return new TextBlock { Id = Guid.Parse("7b752f0a-02ac-4868-b959-0af058fae61f"), Type = TextBlockType.Text, Text = "Many fetchlings congregate in these two cities." };
            yield return new TextBlock { Id = Guid.Parse("8420a1df-cadd-41de-bbfd-a16631d18121"), Type = TextBlockType.Text, Text = "Beacon (Shadow Absalom): Estlaris ignore their city's official name on Golarion and instead call their home Beacon. Velstracs and intelligent undead prowl the city's sparsely traveled streets, but business thrives behind closed doors and in towering d'ziriak hives. Ships cross the parched Bay of Dusk to bring diverse wares that fuel warring factions, while the Glare at Beacon's heart can send visitors back to the exact spot from which they entered the Shadow Plane." };
            yield return new TextBlock { Id = Guid.Parse("038ce8c1-ec60-4fc9-b835-6aad9e6d6ee8"), Type = TextBlockType.Text, Text = "Candlease: This island of terrace farms, natural spires, and colorful woven bridges floats in the sky beneath Shadow Golarion's moon. In the Tallow amphitheater, the timely gleaming of obsidian standing stones helps predict the Lacrimosas that both take and replace Somal's Tears. Candlease also hosts storytelling contests and Brightsorrow moots." };

            yield return new TextBlock { Id = Guid.Parse("41c9c9a8-cc24-4058-9183-024347cfde44"), Type = TextBlockType.Heading, Text = "Kayal" };
            yield return new TextBlock { Id = Guid.Parse("223faa94-93b8-410a-90aa-5cd8817f65f8"), Type = TextBlockType.Text, Text = "Many fetchlings refer to themselves as kayals, an Aklo-derived word with a meaning akin to “shadow people.” Most kayals reject the term fetchling, which they see as imposed on them by individuals bound too closely to the Material Plane. The word has uncertain origins, but its use is widespread in Nidal. To kayals in Nidal, their name grounds and uplifts them as a worthy people forging their own paths, not as servitors of darkness. Skeptics consider kayal to be a superficial affectation." };

            yield return new TextBlock { Id = Guid.Parse("36e4078e-9c0d-48fd-a0b0-029d9ab43732"), Type = TextBlockType.Heading, Text = "The Widow" };
            yield return new TextBlock { Id = Guid.Parse("e8e561ff-6bad-471f-bd95-848692b7b35e"), Type = TextBlockType.Text, Text = "The Widow was one of the Forsaken— sinister demigods who once watched over the Shadow Plane. It heard an Azlanti call for rescue, lifted its shivering sickle, and tore a passage into darkness; those it ushered into the Shadow Plane became the first fetchlings. Few remember anything beyond the Widow's name, and fewer still offer it prayers. It grants power to no fetchling priests." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Fetchling.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("39120b55-0bf8-488f-802e-59f37a5a6424"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("081f8522-e965-469b-805c-b0a405f35d1a"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("b948e1e3-f06d-4c1e-8842-13fbf978fcf8"), Stats.Instances.Dexterity.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("22e8cfc9-cc47-4ee0-81db-b77ad109f82b"));
            builder.GainSpecificLanguage(Guid.Parse("d1b7b467-811b-428a-9f70-b434247dd663"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("3c085286-f47a-4215-8238-f57807e5d548"), Languages.Instances.Shadowtongue.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("45a2a36d-f385-434e-8bce-98df6e78467d"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3df66b9e-0421-4a07-88ae-1a90e54d917c"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 83
            };
        }
    }
}
