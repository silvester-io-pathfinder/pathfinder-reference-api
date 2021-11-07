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
    public class Elf : Template
    {
        public static readonly Guid ID = Guid.Parse("46407c24-53cd-4167-85a4-e64173f23f67");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 30, 
                Name = "Elf", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Aerel, Amrunelara, Caladrel, Dardlara, Faunra, Heldalel, Jathal, Lanliss, Oparal, Seldlon, Soumral, Talathel, Tessara, Variel, Yalandlara, Zordlon"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("d75f4930-1101-42a6-946e-69187098e882"), Type = TextBlockType.Text, Text = "As an ancient people, elves have seen great change and have the perspective that can come only from watching the arc of history. After leaving the world in ancient times, they returned to a changed land, and they still struggle to reclaim their ancestral homes, most notably from terrible demons that have invaded parts of their lands. To some, the elves are objects of awe—graceful and beautiful, with immense talent and knowledge. Among themselves, however, the elves place far more importance on personal freedom than on living up to these ideals." };
            yield return new TextBlock { Id = Guid.Parse("d6df67c9-9e04-4cc6-8948-2d5bcb97c56b"), Type = TextBlockType.Text, Text = "Elves combine otherworldly grace, sharp intellect, and mysterious charm in a way that is practically magnetic to members of other ancestries. They are often voraciously intellectual, though their studies delve into a level of detail that most shorter-lived peoples find excessive or inefficient. Valuing kindness and beauty, elves ever strive to improve their manners, appearance, and culture." };
            yield return new TextBlock { Id = Guid.Parse("ca5e44b1-a4c4-4225-95f4-0ac95b3b0512"), Type = TextBlockType.Text, Text = "Elves are often rather private people, steeped in the secrets of their groves and kinship groups. They’re slow to build friendships outside their kinsfolk, but for a specific reason: they subtly and deeply attune to their environment and their companions. There’s a physical element to this attunement, but it isn’t only superficial. Elves who spend their lives among shorter‑lived peoples often develop a skewed perception of their own mortality and tend to become morose after watching generation after generation of companions age and die. These elves are called the Forlorn." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is magical, mystical, and mysterious, you should play an elf." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("ceb73e75-b796-4e58-aed7-8b3627fe8a89"), Type = TextBlockType.Enumeration, Text = "Carefully curate your relationships with people with shorter lifespans, either keeping a careful emotional distance or resigning yourself to outliving them. " };
            yield return new TextBlock { Id = Guid.Parse("5bce5beb-6398-4552-aa32-ea8852992439"), Type = TextBlockType.Enumeration, Text = "Adopt specialized or obscure interests simply for the sake of mastering them. " };
            yield return new TextBlock { Id = Guid.Parse("e364a58d-b1fc-4a2f-9cc2-bf15e087734a"), Type = TextBlockType.Enumeration, Text = "Have features such as eye color, skin tone, hair, or mannerisms that reflect the environment in which you live." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("979691ff-8006-4902-a9e6-5f65257fc970"), Type = TextBlockType.Enumeration, Text = "Focus on your appearance, either admiring your grace or treating you as if you're physically fragile. " };
            yield return new TextBlock { Id = Guid.Parse("a389fbd8-99a8-4097-9d0b-95704c180cfb"), Type = TextBlockType.Enumeration, Text = "Assume you practice archery, cast spells, fight demons, and have perfected one or more fine arts. " };
            yield return new TextBlock { Id = Guid.Parse("f31fda93-28d3-4e15-8af6-71a0795bf2e3"), Type = TextBlockType.Enumeration, Text = "Worry that you privately look down on them, or feel like you're condescending and aloof." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("2dab46e1-cfcc-4512-ae2e-d9d28b0ec4bd"), Type = TextBlockType.Text, Text = "While generally taller than humans, elves possess a fragile grace, accentuated by long features and sharply pointed ears. Their eyes are wide and almond-shaped, featuring large and vibrant-colored pupils that make up the entire visible portion of the eye. These pupils give them an alien look and allow them to see sharply even in very little light." };
            yield return new TextBlock { Id = Guid.Parse("eb3c700c-038d-4ee9-b792-86abe9032723"), Type = TextBlockType.Text, Text = "Elves gradually adapt to their environment and their companions, and they often take on physical traits reflecting their surroundings. An elf who has dwelled in primeval forests for centuries, for example, might exhibit verdant hair and gnarled fingers, while one who’s lived in a desert might have golden pupils and skin. Elven fashion, like the elves themselves, tends to reflect their surroundings. Elves living in the forests and other wilderness locales wear clothing that plays off the terrain and flora of their homes, while those who live in cities tend to wear the latest fashions." };
            yield return new TextBlock { Id = Guid.Parse("e2f1410e-f40a-47bd-a92d-36a870271bee"), Type = TextBlockType.Text, Text = "Elves reach physical adulthood around the age of 20, though they aren’t considered to be fully emotionally mature by other elves until closer to the passing of their first century, once they’ve experienced more, held several occupations, and outlived a generation of shorter-lived people. A typical elf can live to around 600 years old." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("d8710433-04e3-4dc0-88d3-6f485eac6592"), Type = TextBlockType.Text, Text = "Elven culture is deep, rich, and on the decline. Their society peaked millennia ago, long before they fled the world to escape a great calamity. They've since returned, but rebuilding is no easy task. Their inborn patience and intellectual curiosity make elves excellent sages, philosophers, andwizards, and their societies are built upon their inherent sense of wonder and knowledge. Elven architecture displays their deep appreciation of beauty, and elven cities are wondrous works of art." };
            yield return new TextBlock { Id = Guid.Parse("e7798d63-de5e-479d-8a84-469645f5febb"), Type = TextBlockType.Text, Text = "Elves hold deeply seated ideals of individualism, allowing each elf to explore multiple occupations before alighting on a particular pursuit or passion that suits her best. Elves bear notorious grudges against rivals, which the elves callilduliel, but these antagonistic relationships can sometimes blossom into friendships over time." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ff864100-fd08-49e2-8dd6-cd8830abbade"), Type = TextBlockType.Text, Text = "Elves are often emotional and capricious, yet they hold high ideals close to their hearts. As such, many are chaotic good. They prefer deities who share their love of all things mystic and artistic.DesnaandShelynare particular favorites, the former for her sense of wonder and the latter for her appreciation of artistry.Calistriais the most notorious of elven deities, as she represents many of the elven ideals taken to the extreme." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("616907fe-3f5f-456c-aaee-332ccdec51c9"), Type = TextBlockType.Text, Text = "Many elves adventure to find beauty and discover new things. Typical backgrounds for an elf includeemissary,hunter,noble,scholar, orscout. Elves often becomerangersorrogues, taking advantage of their dexterity, oralchemistsorwizards, exploring their intellectual curiosity." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("09d5c3c3-685f-4bcb-8210-8f9ce7391d5d"), Type = TextBlockType.Text, Text = "An elf keeps their personal name secret among their family, while giving a nickname when meeting other people. This nickname can change over time, due to events in the elf’s life or even on a whim. A single elf might be known by many names by associates of different ages and regions. Elven names consist of multiple syllables and are meant to flow lyrically—at least in the Elven tongue. They so commonly end in “-el” or “-ara” that other cultures sometimes avoid names ending in these syllables to avoid sounding too elven." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Elf.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("7de0656d-36f4-4c0f-9917-431e571b84df"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("e4bb12da-dd98-4b8c-9732-eb216e8e0ffe"), MovementMethod.Walking, ModifierType.Add, modifier: 30);
            builder.GainSpecificAbilityBoost(Guid.Parse("62861c5b-2c96-4c53-8cab-820f88d46ca3"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("49786354-cf62-462f-988c-3d50e6e3ea53"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("e55a5e4b-5fcb-45e0-8af1-5d18fc2c6c6c"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("04c35107-d06e-4224-89bd-d8fc0900ea3d"), Stats.Instances.Constitution.ID);
            builder.GainSpecificLanguage(Guid.Parse("c806b600-26b3-4176-9050-fe756974fe68"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("71d49f61-2878-40cd-8be0-0913cd5667d5"), Languages.Instances.Elven.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2060dc54-120d-4b5e-8f10-5b8765709039"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 39
            };
        }
    }
}
