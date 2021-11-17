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
    public class Shoony : Template
    {
        public static readonly Guid ID = Guid.Parse("c59549e5-7059-4bc5-8fe2-a6956e3abcbc");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Shoony", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Ahogo, Arnbin, Bighmor, Bondin, Domwurd, Ebmeur, Gopor, Gurna, Hiemgur, Mufurlo, Oriog, Pulumar, Raliamar, Ruggion, Uhulrig, Ungrin."
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("bfc91130-c916-4dc2-9b3e-91712e177b21"), Type = TextBlockType.Text, Text = "Diminutive humanoids who resemble squat, bipedal dogs, shoonies are sometimes mistaken for weak and insular pacifists. However, their sheer perseverance, incredible work ethic, and resourceful use of diplomacy make shoonies far from helpless." };
            yield return new TextBlock { Id = Guid.Parse("bf94f0bf-bfe0-47ee-b124-6dac80f98c00"), Type = TextBlockType.Text, Text = "According to shoonies, Aroden created their kind to provide him with pleasant company soon after he created the Isle of Kortos. Shoony culture is rooted in this myth and its implications, which help to explain the ancestry’s long reputation for hospitality, good will, and pacifism. War is antithetical to the shoony way of life; shoonies rely on cooperation and persistence to make their way through a world that can seem at times hellbent on destroying them. Shoonies are unflappable in their optimism and always see the best in others, even when faced with frequent subjugation and exploitation that might create bitterness or xenophobia among other societies. To shoonies, peace is a goal always worth striving for, and no villain is beyond redemption, so they aim to resolve problems with peaceful solutions." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("6b460974-1071-49ec-91b2-588668510477"), Type = TextBlockType.Enumeration, Text = "Fight to protect those you care about and strive to do the right thing. " };
            yield return new TextBlock { Id = Guid.Parse("6cff3632-da24-4951-840a-5c50c47bd9cc"), Type = TextBlockType.Enumeration, Text = "Work hard for long hours in a focused pursuit of distant goals. " };
            yield return new TextBlock { Id = Guid.Parse("7b91fd5c-3f85-4211-9a88-a3d60b450efb"), Type = TextBlockType.Enumeration, Text = "Provide comfort, necessities such as food, and a sense of kinship to those in distress." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("bc3c247c-6fdd-4160-aedb-b13a944a0467"), Type = TextBlockType.Enumeration, Text = "Involuntarily fawn over (or recoil from) your physical appearance. " };
            yield return new TextBlock { Id = Guid.Parse("e32b02a2-6a2d-48ad-a5a2-73d17ed32d45"), Type = TextBlockType.Enumeration, Text = "Protect you from scary situations or terrifying phenomena, out of either friendship or overprotectiveness. " };
            yield return new TextBlock { Id = Guid.Parse("5d054100-0d1c-4307-842e-8795a83a4f5c"), Type = TextBlockType.Enumeration, Text = "Appreciate your pragmatism and natural ability to care for others." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("6a6c46fb-4df3-4457-805d-ef007c6c69d9"), Type = TextBlockType.Text, Text = "Shoonies are squat, furry humanoids with flattened canid faces and wet, black eyes. Their fur can be a variety of hues and patterns, with the most common colors being fawn or black, and their loose skin gives even the fittest shoony a pudgy appearance. Shoonies have short, curly tails that sometimes wag involuntarily when the shoony is content or particularly excited or pleased. Like canines, shoonies cannot sweat; they pant to mitigate heat and exertion, and it is not uncommon to see a shoony with a perpetually lolling tongue." };
            yield return new TextBlock { Id = Guid.Parse("1cd22ffd-525e-4688-a326-1a505c5d2049"), Type = TextBlockType.Text, Text = "A shoony reaches maturity after just 8 to 10 years, and the elders of their villages rarely reach the age of 50. Little differentiates male and female shoonies except during the late stages of pregnancy, and as they age, both sexes develop graying facial fur, wrinkled skin, and frail joints. The average shoony is 3-1/2 feet tall and weighs 100 pounds." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("1568c828-b53d-43d3-a8f8-cf6a916a185f"), Type = TextBlockType.Text, Text = "Despite the shoony drive toward communal living, most shoony settlements are farming villages with populations of no more than a hundred. Shoonies work hard to make their lands bountiful and recognize that large, dense populations can negatively affect the ecosystem. Monster attacks, natural disasters, and exploitation from stronger cultures have all also limited the spread of shoonies across the Inner Sea region." };
            yield return new TextBlock { Id = Guid.Parse("7340f034-128f-46c2-896a-3e7a495fdf04"), Type = TextBlockType.Text, Text = "Despite their short lifespans, shoonies are happy-go-lucky people with an irrepressible love for the land and their fellow shoonies, and remain optimistic even under the worst circumstances. The simple pleasures of living on this beautiful world, engaging in hard work, and surrounding themselves with loved ones motivate shoonies to push through the hardships that all too often befall their people." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("28f0713f-857c-4ffc-9419-cf88c147b231"), Type = TextBlockType.Text, Text = "Most shoony societies encourage empathy and loyalty, so they’re rarely evil, but they’re also practical, traditional, and timid. Most shoony adventurers are neutral good or lawful good. Religion is a cornerstone of shoony village life; shoonies primarily worshipped Aroden until his apparent death. In his absence, many shoonies have adoptedErastilas their patron deity because his emphasis on family, community, and living off the land naturally meshes with typical shoony values. Noble shoonies— especially warriors—sometimes look toIomedaeas an exemplar of integrity, hard work, and sacrifice." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("f32f7bbf-22f7-4a0c-a4b4-dc46d4a91ec5"), Type = TextBlockType.Text, Text = "Few shoonies willingly choose to leave their homeland and friends in favor of facing the unknown, and the circumstances that lead a shoony to adventure are often dramatic and life-altering, if not tragic. That said, some shoonies do travel the world in search of riches to bring back to their village or to avenge their kinfolk, and shoony adventurers who show bravery or ingenuity are sure to earn a place in the legends of their people." };
            yield return new TextBlock { Id = Guid.Parse("3b64f5fe-cfb7-4d07-a01c-de362c76eb83"), Type = TextBlockType.Text, Text = "Typical shoonies have theacolyte,farmhand,hunter,laborer, orwarriorbackgrounds from theCore Rulebook, or theanimal wranglerorriggerbackgrounds from theExtinction Curse Player’s Guide. Many shoony adventurers arefighterswho hone their skills to become stalwart defenders of their friends. Some shoonies pursue religious study and becomeclericsorchampions, while others develop their foraging and hunting skills as talenteddruidsandrangers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("2afa1ad7-a601-4f06-9414-f5432347150d"), Type = TextBlockType.Text, Text = "With their strong family values and emphasis on found friends, it’s no wonder that shoonies take particular pride in naming their children after other loved ones. Shoony names are short, guttural, and often sound like loose strings of unassociated vowels and soft consonants to people of other ancestries. Shoonies value names and take great care to learn and speak the correct pronunciations of their friends’ names." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("adc0c9ad-f8f4-4d69-b470-acf17dd3d933"), Type = TextBlockType.Heading, Text = "Blunt Snout" };
            yield return new TextBlock { Id = Guid.Parse("28b42c5f-08f4-4c09-802e-aabf948c02a3"), Type = TextBlockType.Text, Text = "Your small, blunt snout and labyrinthine sinus system make you resistant to phenomena that assail the nose. When you roll a saving throw against inhaled threats (such as inhaled poisons) and olfactory effects (such as xulgath stench), you get the outcome one degree of success better than the result of your roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Shoony.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("fc6ee5e4-64e3-488f-8e29-d3b5b1f491a8"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("99ab76e0-1834-4a30-969f-392d4c7fb30e"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("9ac62c47-cdf3-46a7-900c-30252dbf0c2b"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("5e3c742d-55e6-4c73-825f-eaf5946640b7"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("b4d87040-835d-418a-864c-558acfb111b3"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("f6296e4f-7aa8-40ae-bf12-5c9885c9717c"), Stats.Instances.Constitution.ID);
            builder.GainSpecificLanguage(Guid.Parse("708d4c65-75b9-486a-af40-bd8b91fbb361"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("89e5e762-824c-4091-ad91-10cf2d9a51c3"), Languages.Instances.Shoony.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("1ec3436b-83a0-40d9-ae80-3a70aaaecd8f"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add Blunt Snout effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2d805ff-2398-4ddf-9e7a-d36f3b5c9ba8"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 72
            };
        }
    }
}
