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
    public class Halfling : Template
    {
        public static readonly Guid ID = Guid.Parse("c6101324-9994-4ebe-9587-3c810e935170");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Halfling", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Anafa, Antal, Bellis, Boram, Etune, Filiu, Jamir, Kaleb, Linna, Marra, Miro, Rillka, Sistra, Sumak, Yamyra"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("a9407fb2-8644-4887-a29a-6decd8bb225a"), Type = TextBlockType.Text, Text = "Claiming no place as their own, halflings control few settlements larger than villages. Instead, they frequently live among humans within the walls of larger cities, carving out small communities alongside taller folk. Many halflings lead perfectly fulfilling lives in the shadows of their larger neighbors, while others prefer a nomadic existence, traveling the world and taking advantage of opportunities and adventures as they come." };
            yield return new TextBlock { Id = Guid.Parse("3dce2116-e9db-4e58-8496-c01d6eee5879"), Type = TextBlockType.Text, Text = "Optimistic and cheerful, blessed with uncanny luck, and driven by powerful wanderlust, halflings make up for their short stature with an abundance of bravado and curiosity. At once excitable and easygoing, they are the best kind of opportunists, and their passions favor joy over violence. Even in the jaws of danger, halflings rarely lose their sense of humor." };
            yield return new TextBlock { Id = Guid.Parse("7ba1a018-7c83-4387-9f62-2ebd9d7143d3"), Type = TextBlockType.Text, Text = "Many taller people dismiss halflings due to their size or, worse, treat them like children. Halflings use these prejudices and misconceptions to their advantage, gaining access to opportunities and performing deeds of daring mischief or heroism. A halfling’s curiosity is tempered by wisdom and caution, leading to calculated risks and narrow escapes." };
            yield return new TextBlock { Id = Guid.Parse("b3c00c44-ebe7-47d5-af22-7af2bd277365"), Type = TextBlockType.Text, Text = "While their wanderlust and curiosity sometimes drive them toward adventure, halflings also carry strong ties to house and home, often spending above their means to achieve comfort in their homelife." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want to play a character who must contend with these opposing drives toward adventure and comfort, you should play a halfling." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("63759a9b-3dc7-47fb-a4d3-db7a27af3a2e"), Type = TextBlockType.Enumeration, Text = "Get along well with a wide variety of people and enjoy meeting new friends. " };
            yield return new TextBlock { Id = Guid.Parse("7f771a3d-d60b-4bdb-abc2-b258c8197bcb"), Type = TextBlockType.Enumeration, Text = "Find it difficult to resist indulging your curiosity, even when you know it’s going to lead to trouble. " };
            yield return new TextBlock { Id = Guid.Parse("ce05817c-6ac4-453f-bab0-4d5e991d9fb9"), Type = TextBlockType.Enumeration, Text = "Hold a deep and personal hatred of the practice of slavery and devote yourself to freeing those who still labor against their will." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("8bb966a0-8036-4268-8e51-f76d388d5e7c"), Type = TextBlockType.Enumeration, Text = "Appreciate your ability to always find a silver lining or something to laugh about, no matter how dire the situation. " };
            yield return new TextBlock { Id = Guid.Parse("07c3ee67-8e40-49c8-bbf6-8d4ac6baa2cc"), Type = TextBlockType.Enumeration, Text = "Think you bring good luck with you. " };
            yield return new TextBlock { Id = Guid.Parse("12e38492-df1d-4eee-9147-35b17e56a121"), Type = TextBlockType.Enumeration, Text = "Underestimate your strength, endurance, and fighting prowess." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("e51c0fa4-1952-422a-b364-340f0a9939f2"), Type = TextBlockType.Text, Text = "Halflings are short humanoids who look vaguely like smaller humans. They rarely grow to be more than 3 feet in height. Halfling proportions vary, with some looking like shorter adult humans with slightly larger heads and others having proportions closer to those of a human child." };
            yield return new TextBlock { Id = Guid.Parse("8374f12c-a6a0-451c-971f-af4d5a8823df"), Type = TextBlockType.Text, Text = "Most halflings prefer to walk barefoot rather than wearing shoes, and those who do so develop roughly calloused soles on their feet over time. Tufts of thick, often-curly hair warm the tops of their broad, tanned feet. Halfling skin tones tend toward rich, tawny shades like amber or oak, and their hair color ranges from a light golden blond to raven black." };
            yield return new TextBlock { Id = Guid.Parse("128a713a-dcb4-4ad6-a8c6-c04cef0de2ef"), Type = TextBlockType.Text, Text = "Halflings reach physical adulthood around the age of 20. A typical halfling can live to be around 150 years old." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("0d884a3c-3b3e-4b7c-89ce-d1a1e403129a"), Type = TextBlockType.Text, Text = "Despite their jovial and friendly nature, halflings don’t usually tend to congregate. They have no cultural homeland in the Inner Sea region, and they instead weave themselves throughout the societies of the world. Halflings eke out whatever living they can manage, many performing menial labor or holding simple service jobs. Some halflings reject city life, instead turning to the open road and traveling from place to place in search of fortune and fame. These nomadic halflings often travel in small groups, sharing hardships and simple pleasures among close friends and family." };
            yield return new TextBlock { Id = Guid.Parse("6122b901-f630-4218-8ebd-b4f896f1ebc0"), Type = TextBlockType.Text, Text = "Wherever halflings go, they seamlessly blend into the society they find themselves in, adapting to the culture of the predominant ancestry around them and adding their uniquely halfling twists, creating a blend of cultural diffusion that enriches both cultures." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("c644d831-11a0-4d8f-8159-eae72a177cb4"), Type = TextBlockType.Text, Text = "Halflings are loyal to their friends and their family, but they aren’t afraid to do what needs to be done in order to survive. Halfling alignments vary, typically closely in keeping with the alignment of the other ancestries that live around them. Halflings favor gods that either grant luck, likeDesna, or encourage guile, likeNorgorber, and many appreciateCayden Cailean’srole as a liberator, as well as any religions common among other ancestries around them." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("b0e204eb-21d2-4c3d-8f55-bf26d42e8a04"), Type = TextBlockType.Text, Text = "Halflings' natural wanderlust and opportunistic nature make them ideal adventurers. Many people put up with their vivacious attitudes in return for the natural talents they provide and the popular superstition that traveling with a halfling is good luck." };
            yield return new TextBlock { Id = Guid.Parse("fc0840b1-e514-45c3-a93b-270fcdb3d039"), Type = TextBlockType.Text, Text = "Typical backgrounds for halflings includeacrobat,criminal,emissary,entertainer,laborer, andstreet urchin. Halflings make greatclericsandrogues, but many also becomemonksorrangers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("2d406371-7db1-459b-987c-5f912c864d66"), Type = TextBlockType.Text, Text = "Halfling names are usually two to three syllables, with a gentle sound that avoids hard consonants. Preferring their names to sound humble, halflings see overly long or complex names as a sign of arrogance. This goes only for their own people, however—halflings have names that suit them, and they understand that elves and humans might have longer names to suit their own aesthetics. Humans in particular have a tendency to refer to halflings by nicknames, with “Lucky” being common to the point of absurdity." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Keen Eyes" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eyes are sharp, allowing you to make out small details about concealed or even invisible creatures that others might miss. You gain a +2 circumstance bonus when using the Seek action to find hidden or undetected creatures within 30 feet of you. When you target an opponent that is concealed from you or hidden from you, reduce the DC of the flat check to 3 for a concealed target or 9 for a hidden one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Halfling.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("902429b2-0d0c-476d-bdfb-bcba770326a3"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("50c2cb62-a708-466b-8747-6f4319eeeb11"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("64a58e65-dacb-402d-8359-fd89ae17af07"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("322a714f-9d66-4d05-9ffb-3972cf7c6875"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("00f43599-3f88-4b96-9295-dd4762c5761d"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("5303353b-90a4-4f6c-8dee-6a3a9ca02c99"), Stats.Instances.Strength.ID);
            builder.GainSpecificLanguage(Guid.Parse("a78ec5c0-d2d4-42aa-9b20-25ec0394722c"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("ab4213dc-ece5-43df-b6ab-a659b758aa6f"), Languages.Instances.Halfling.ID);
            //TODO: Add intelligence modifier languages.
            //TODO: Add the Keen Eyes effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("416232f7-6c3b-4e7d-94a1-dcdf5befa4d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 51
            };
        }
    }
}
