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
    public class Anadi : Template
    {
        public static readonly Guid ID = Guid.Parse("fc328cd1-789b-4df2-8f96-08650e365680");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Anadi", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Altava, Anavachti, Strings-On-The-River Inkeelah, Kerialnamu, Maracha, Leaves-Shelter-Her-Feet Naiala, Orvasa, Reloana, Rivuken, Velachamon"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("8cc69818-a51a-448f-aa60-50bcc9ba29bf"), Type = TextBlockType.Text, Text = "Anadi people are reclusive, sapient spiders who hail from the jungles of southern Garund. Though they act in many ways like natural-born shapeshifters, their twin forms actually stem from carefully developed magic." };
            yield return new TextBlock { Id = Guid.Parse("d69fcd88-fb3e-4fb1-b3dc-455a72c573cb"), Type = TextBlockType.Text, Text = "As a communal and peaceful people, anadi ancestors endeavored to establish trade with the neighbors of their homeland. However, these anadi soon learned that most others found their appearance to be extremely objectionable. Wishing to avoid conflict, ancient anadi retreated into isolation until they could find a solution. The answer came when their greatest scholars innovated a fusion oftransmutationandillusionmagic that allowed them to assume ahumanoidform. The technique was developed, perfected, and eventually taught to the overwhelming majority of anadi." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Early efforts with their new approach to diplomacy have yielded much better results, though sporadic contact means that some outsiders whisper false legends about anadi, such as claims that they are humans who transform into monstrous spiders at moonrise. Even contemporary explorers have reported anadi as human-spider hybrids. The anadi people of the current day strive to slowly but surely create a world where they no longer need to hide their true nature." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("1b48fd31-c8af-49a0-a199-0e7dde2d88cb"), Type = TextBlockType.Enumeration, Text = "Only reveal your true form to people who have earned your trust." };
            yield return new TextBlock { Id = Guid.Parse("93ac8d4d-049e-4c9b-a291-ef9a185303df"), Type = TextBlockType.Enumeration, Text = "Openly express sympathy for misrepresented and unfairly stigmatized cultures." };
            yield return new TextBlock { Id = Guid.Parse("187c4dda-e63f-4954-a463-59dbdeba9d9c"), Type = TextBlockType.Enumeration, Text = "Provide for those you hold dear and defend them from danger without hesitation." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("e2091758-ca62-47d8-91f9-ffccab11a638"), Type = TextBlockType.Enumeration, Text = "Appreciate your willingness to seek nonviolent solutions to complicated problems." };
            yield return new TextBlock { Id = Guid.Parse("c8f122bd-aaa3-4f7c-8867-a261c1680f92"), Type = TextBlockType.Enumeration, Text = "Have a strong reaction to seeing your natural form." };
            yield return new TextBlock { Id = Guid.Parse("a2ff4ef7-7966-4b17-a149-52884ed5828c"), Type = TextBlockType.Enumeration, Text = "Assume you have an affinity for druidic magic, given your ability to transform." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("be9f75c3-8459-4212-8fd9-ed5c3d57afb7"), Type = TextBlockType.Text, Text = "Anadi in their true form resemble human-sized spiders with a variety of colorations. Some tones look simple or muted while other remain striking and vibrant, with most patterns inherited from an anadi's parentage. A typical anadi measures five feet in length from their front legs to their rear legs when standing comfortably." };
            yield return new TextBlock { Id = Guid.Parse("cbdfc518-3df0-4635-9d26-c015a5936957"), Type = TextBlockType.Text, Text = "All anadi possesses the ability to transform into a human guise. This form can resemble any human ethnicity, but it's usually one that blends in with the region of an anadi's hatching. Anadi reach physical maturity after 13 years, going through multiple phases of molting along the way. A typical anadi lives to be about 80 years old." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("cec2ff11-866b-4ae2-9f71-221e74995cbf"), Type = TextBlockType.Text, Text = "Anadi live in a communal society, sharing peaceful lives farming mushrooms or weaving warm blankets. Their culture places great value on cooperation and mutual respect. Due to this cultural upbringing, anadi often have issues facing severe conflict and often come off to other ancestries as very shy. Their history of dealing with arachnophobia in other peoples—which anadi understand is often instinctual and very difficult to control—likewise means that anadi do their best to be accommodating and comforting, even in situations that aren't necessarily fair to them." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("268455ad-a94f-4df6-a3f0-f880191c901b"), Type = TextBlockType.Text, Text = "The cooperative nature of anadi society and their dislike of violence means many anadi lean toward good alignments. They're more often neutral than chaotic or lawful, though the latter aren't unheard of.  Legends sayGrandmother Spiderrescued anadi people from servitude and brought them to Golarion, becoming their patron deity in the process. Her values of mutual care and playful trickery interweave into anadi culture, and even those who don't worship her tell tales of her adventures." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("7d8563f0-1cd0-446e-86ae-7ff24bed8352"), Type = TextBlockType.Text, Text = "Anadi who answer the call to adventure often do so to learn more about the world at large. Common anadi backgrounds includeartisan,emissary,herbalist,hunter, andscholar. Anadi adventurers who want to support their communities often becomeclericsordruids.Rogueremains a popular choice among those who seek to hide their true form. Anadi who wish to continue their magical traditions tend to becomewizardsorsorcerers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("1cdeac2c-0682-4a5c-b518-6f8477385281"), Type = TextBlockType.Text, Text = "Anadi names are given by the members of the web marriage that raised them. Each parent contributes a single syllable, usually the first, from their own name. Older anadi who feel their identity has settled often take on or are given a phrase-title to honor them as well. Anadi who live among human populations rarely take a cover name, but some might adopt one if their given name strongly contrasts the norm in the local culture." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Fangs" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were born with a natural means for hunting and self-defense. You gain a fangs unarmed attack that deals 1d6 piercing damage. Your fangs are in the brawling group and have the finesse and unarmed traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Anadi.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("aaa9ff3e-35ba-47c1-9ab7-dbda41e60b2a"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("402920d4-f325-4121-bd75-5c0d623b88c9"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("0673f679-f11f-4aa3-948d-fbe21f0456d6"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("370c58e5-960b-4f92-99bd-1ba0b09200bd"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("d0e2cd9a-b65c-45a4-a261-934c7eb3fce4"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("c6486893-091d-47c2-9214-262eaab8dbd4"), Stats.Instances.Constitution.ID);
            builder.GainSpecificLanguage(Guid.Parse("dd569604-e645-460c-adf5-7ceb483ea2fd"), Languages.Instances.Anadi.ID);
            builder.GainSpecificLanguage(Guid.Parse("1e152ae0-0250-42a5-9c83-e4d3c8164907"), Languages.Instances.Mwangi.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ChangeShapeAnadi.ID);
            builder.GainSpecificUnarmedAttack(Guid.Parse(""), UnarmedAttack.Fangs, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
            //TODO: Add intelligence modifier languages.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe77d8d7-67ca-4c9e-a6b7-aec25eeb461a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 103
            };
        }
    }
}
