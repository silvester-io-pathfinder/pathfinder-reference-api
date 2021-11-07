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
    public class Dwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("249892fe-9878-4a96-8d1b-41174db604fa");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 20, 
                Name = "Dwarf", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Agna, Bodill, Dolgrin, Edrukk, Grunyar, Ingra, Kazmuk, Kotri, Lupp, Morgrym, Rogar, Rusilka, Torra, Yangrit"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("802be817-604a-4d20-88e0-51f4bb05a9ad"), Type = TextBlockType.Text, Text = "Dwarves have a well-earned reputation as a stoic and stern people, ensconced within citadels and cities carved from solid rock. While some see them as dour and humorless crafters of stone and metal, dwarves and those who have spent time among them understand their unbridled zeal for their work, caring far more about quality than quantity. To a stranger, they can seem untrusting and clannish, but to their friends and family, they are warm and caring, their halls filled with the sounds of laughter and hammers hitting anvils." };
            yield return new TextBlock { Id = Guid.Parse("9240f0be-b9c4-413c-93f0-42cb7e35a050"), Type = TextBlockType.Text, Text = "Dwarves are slow to trust those outside their kin, but this wariness is not without reason. Dwarves have a long history of forced exile from ancestral holds and struggles against the depredations of savage foes, especiallygiants, goblinoids,orcs, and the horrors that dwell deep below the surface. While trust from a dwarf is hard-won, once gained it is as strong as iron." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want to play a character who is as hard as nails, a stubborn and unrelenting adventurer, with a mix of rugged toughness and deep wisdom—or at least dogged conviction—you should play a dwarf." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("cd8c671f-d8e0-45b0-8d86-1299b02bf212"), Type = TextBlockType.Enumeration, Text = "Strive to uphold your personal honor, no matter the situation. " };
            yield return new TextBlock { Id = Guid.Parse("6f733777-6b28-40e0-baa2-069f5f79cdd4"), Type = TextBlockType.Enumeration, Text = "Appreciate quality craftsmanship in all forms and insist upon it for all your gear. " };
            yield return new TextBlock { Id = Guid.Parse("89039469-5434-4fcf-b564-a91463ae8d0a"), Type = TextBlockType.Enumeration, Text = "Don’t waver or back down once you’ve set your mind to something." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("973d5764-d927-4f26-a0d7-59bbdca09281"), Type = TextBlockType.Enumeration, Text = "See you as stubborn, though whether they see this as an asset or a detriment changes from one person to the next. " };
            yield return new TextBlock { Id = Guid.Parse("58933fee-88b8-46bc-8335-d2c26f3f130c"), Type = TextBlockType.Enumeration, Text = "Assume you are an expert in matters related to stonework, mining, precious metals, and gems. " };
            yield return new TextBlock { Id = Guid.Parse("d5cf08ed-fd75-40c9-941b-ff142fdad4af"), Type = TextBlockType.Enumeration, Text = "Recognize the deep connection you have with your family, heritage, and friends." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("2e987bab-635f-4121-9a9b-d61733b8a25d"), Type = TextBlockType.Text, Text = "Dwarves are short and stocky, standing about a foot shorter than most humans. They have wide, compact bodies and burly frames. Dwarves of all genders pride themselves on the length of their hair, which they often braid into intricate patterns, some of which represent specific clans. A long beard is a sign of masculinity and honor among the dwarves, and thus a clean-shaven male dwarf is considered weak, untrustworthy, or worse." };
            yield return new TextBlock { Id = Guid.Parse("068b9435-aad3-49d3-a178-8cf7f18cb0be"), Type = TextBlockType.Text, Text = "Dwarves typically reach physical adulthood around the age of 25, though their traditionalist culture places more value on completing coming of age ceremonies unique to each clan than reaching a certain age. A typical dwarf can live to around 350 years old." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("86ad9c13-2f46-499d-b626-2f1d72f9f016"), Type = TextBlockType.Text, Text = "The ancient surface empire the dwarves once ruled fell long ago, overwhelmed by orc and goblinoid enemies. Today's dwarves today retain many of the qualities that propelled their people to greatness in ancient times: fierceness, gumption, and stubbornness in endeavors ranging from battle and craftsmanship to forging ties with family and friends." };
            yield return new TextBlock { Id = Guid.Parse("2c092b08-78d8-449d-a0ca-637b0ce703e1"), Type = TextBlockType.Text, Text = "While the distance between their mountain Sky Citadels can create vast cultural divides between various dwarf clans, most dwarven societies share a number of similarities. Nearly all dwarven peoples share a passion for stonework, metalwork, and gem-cutting. Most are highly skilled at architecture and mining, and many share a hatred of giants, orcs, and goblinoids." };
            yield return new TextBlock { Id = Guid.Parse("8d32ccce-10c7-49f6-be85-7d92112d98c0"), Type = TextBlockType.Text, Text = "Few dwarves are seen without theirclan daggerstrapped to their belt. This dagger is forged just before a dwarf's birth and bears the gemstone of their clan. A parent uses this dagger to cut the infant's umbilical cord, making it the first weapon to taste their blood." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("766a77fc-722f-4c20-8db4-965903c94115"), Type = TextBlockType.Text, Text = "Dwarves tend to value honor and closely follow the traditions of their clans and kingdoms. They have a strong sense of friendship and justice, though they are often very particular about who they consider a friend. They work hard and play harder— especially when strong ale is involved." };
            yield return new TextBlock { Id = Guid.Parse("2122d72d-47e1-404d-b6da-88ae06aee96b"), Type = TextBlockType.Text, Text = "The typical dwarf is lawful good or lawful neutral and prefers to worship deities of those alignments.Torag, god of dwarvenkind, is the dwarves' primary deity, though worship ofTorag's family membersis also common." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("3d6c2859-e87a-4700-be3b-e0aab1b44bc6"), Type = TextBlockType.Text, Text = "Dwarven adventurers tend to work as treasure hunters or sellswords. They often leave their citadels and subterranean cities in search of wealth to enrich their homeland or to reclaim long-lost dwarven treasures or lands taken by the enemies of their kin." };
            yield return new TextBlock { Id = Guid.Parse("ec4feb81-cc88-476b-8b75-2fdc59ca60a8"), Type = TextBlockType.Text, Text = "Typical dwarven backgrounds includeacolyte,artisan,merchant,miner, andwarrior. Dwarves excel at many of the martial classes, such asbarbarian,fighter,monk, andranger, but they also make excellentclericsanddruids." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("e3a9414b-57b3-4598-af9a-fbba4e39e094"), Type = TextBlockType.Text, Text = "Dwarves honor their children with names taken from ancestors or dwarven heroes, and it’s quite rare to invent a new name or to borrow a name from another culture for a child. When introducing themselves, dwarves tend to list their family and clan, plus any number of other familial connections and honorifics. Dwarven names usually contain hard consonants and are rarely more or fewer than two syllables." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Clan Dagger" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You get one clan dagger of your clan for free, as it was given to you at birth. Selling this dagger is a terrible taboo and earns you the disdain of other dwarves." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Dwarf.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("bc29518d-0d77-48cb-8577-a43f525c19c0"), ModifierType.Add, modifier: 10);
            builder.ModifySpecificSpeed(Guid.Parse("735798ba-696d-42d3-9fd8-14bcd50d949d"), MovementMethod.Walking, ModifierType.Add, modifier: 20);
            builder.GainSpecificAbilityBoost(Guid.Parse("e908605f-c473-4085-9fb2-5e2990af7e40"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("f1714909-af83-43eb-a4ae-fcd31de665a7"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("3e3ba53b-e8cb-4b97-8b32-4d6fdc091879"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("82046ba2-b88f-491c-9052-27e0cb2a3aa4"), Stats.Instances.Charisma.ID);
            builder.GainSpecificLanguage(Guid.Parse("d35bfb5a-ae0c-4e0f-8b18-59e1baf64537"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("8253a23e-27c4-45a6-a404-e43e71512468"), Languages.Instances.Dwarven.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.GainSpecificMeleeWeapon(Guid.Parse(""), MeleeWeapons.Instances.ClanDagger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2e06bec-fb12-43aa-9746-45999491f342"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 35
            };
        }
    }
}
