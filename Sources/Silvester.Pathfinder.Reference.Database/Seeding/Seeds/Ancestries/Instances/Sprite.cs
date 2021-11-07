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
    public class Sprite : Template
    {
        public static readonly Guid ID = Guid.Parse("f65e9785-4cce-448c-9e6f-a47a0588b9e5");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 20, 
                Name = "Sprite", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Bree, Plumgrass, Cowrie, Flit, Moth, Zephyr, Naatalu, Pinebrush, Zandivar"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Tiny.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("e87fc85b-9b09-4b41-8c44-5340da9a05aa"), Type = TextBlockType.Text, Text = "Sprites are diminutive, whimsical, and exuberant creatures from the fey realm known as the First World. They love playing pranks, exploring new things, and embracing everything to do with magic." };
            yield return new TextBlock { Id = Guid.Parse("436b390f-5669-4149-a24e-5b53d978057a"), Type = TextBlockType.Text, Text = "When most people picture afey, chances are they're thinking of a sprite. The majority of sprites remain in the First World, where they are essentially immortal, reincarnating to a new form of fey when their life eventually comes to an end. Some even meld together with others to form a more substantial body or split apart into multiple smaller fey. However, sprites are incredibly curious about all forms of magic, leading a significant number to risk the mortal world to explore the new possibilities offered by the unusually static nature of mortal existence. These creatures mix in with other, smaller groups ofMaterial Planecomrades, including exiles from the First World, those whose family swore pacts to mortals, and even contemplative individuals curious to enter the mortal cycle of souls." };
            yield return new TextBlock { Id = Guid.Parse("107bab2c-9945-4734-91de-4065f80f8001"), Type = TextBlockType.Text, Text = "The first generation of Material Plane sprites were content to guard magical locations or objects, learn music, and play pranks on the unsuspecting. Panic struck when children born in the mortal world didn't form wings upon adulthood—some sprites transitioning to the mortal world likewise lost their wings after a time. Believing this to be a sign that the mortal world was too alien for them to live there, many of the initial sprite explorers returned to the safety of the First World." };
            yield return new TextBlock { Id = Guid.Parse("2aee65f6-c3d5-4e4f-bcc8-cd6eff26c3b7"), Type = TextBlockType.Text, Text = "However, their wingless children exhibited a potential unmatched by any of their ancestors, as well as a particular magical affinity for the mortal world. They became the mightiest of sprite heroes, but also, on occasion, the most dangerous villains. As they came close to reaching their full strength, many of them did grow their wings at long last: larger, unique, and more vibrant than any from the First World had seen before, a sign of their limitless potential." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is tiny, mercurial, and curious, you should play a sprite." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("089d16e5-eeef-4698-be84-78739ce88d55"), Type = TextBlockType.Enumeration, Text = "Play good-natured pranks on those around you, intended to teach a lesson, aid in locating a lost item, or even help find love." };
            yield return new TextBlock { Id = Guid.Parse("30486cc1-0969-4d8c-bfd6-922832d14fec"), Type = TextBlockType.Enumeration, Text = "Become sidetracked by something new and eye-catching before you have fully followed through on your previous plan." };
            yield return new TextBlock { Id = Guid.Parse("31d0358c-5acb-4ccd-a548-8dd3f13bbf55"), Type = TextBlockType.Enumeration, Text = "Find something magical that's so important to you, you can't help but protect it with every ounce of your strength." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("1852c32e-645e-4d1d-aa8c-585c52eae522"), Type = TextBlockType.Enumeration, Text = "Expect you to know strange fey mysteries and perform fantastical primal magic well beyond your actual abilities." };
            yield return new TextBlock { Id = Guid.Parse("6013ac4a-15e5-41e3-89ac-d8d6b61a6e8b"), Type = TextBlockType.Enumeration, Text = "Consider you the prime suspect whenever unexplained hijinks or serendipity comes their way." };
            yield return new TextBlock { Id = Guid.Parse("205d4d8b-811a-4a01-973a-49f7db00fc82"), Type = TextBlockType.Enumeration, Text = "Misconstrue the way your mind works, seeing your flitting attention as a sign of being scatterbrained." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("f2fd3d0d-f925-4023-8738-063e4c8f4796"), Type = TextBlockType.Text, Text = "Sprites are tiny faeries whose features vary wildly based on their heritage. The Wingless—those with the potential to become powerful heroes and villains, including all PC sprites—slowly grow their wings over time as their magical potential manifests, though some never grow wings at all. Those sprites with humbler destinies typically grow wings when reaching full adulthood and mastering their innate magic. Sprites reach adulthood at around the same rate as humans do, but a typical fey who can manage to stay out of mischief and danger can live 1,000 years or more.Material Planesprites who sense their time is coming to an end usually return to theFirst Worldto be reborn and start their adventure all over again." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("988a67e5-cc0a-4c75-ab85-d744170add21"), Type = TextBlockType.Text, Text = "Sprites habitually live in tiny, reclusive villages in areas with abundant magic, natural beauty, or other curiosities of interest. Other sprites live as loners or with small family or peer groups, traveling across the land in search of excitement." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("76498478-f2fb-4690-9ec5-834b950e2455"), Type = TextBlockType.Text, Text = "Sprites run the gamut of alignments but are rarely lawful or evil. They are far more likely to worship theEldest— the peculiar deities of the fey—than those of the mortal world. They have a particular affinity forShyka, the many-formed Eldest of time, andthe Lantern King, the trickster among their ranks. Among mortal deities, sprites appreciateDesnathe most, and due to her iconic depiction as a butterfly-winged woman, some Desnan sprites claim her as one of their own. Sprites also readily comprehend the doctrines ofCayden CaileanandShelyn, and the goddess of beauty and art is a particular favorite amonggrigs." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("ff7d0903-0372-49b2-8e5d-b50f23572036"), Type = TextBlockType.Text, Text = "While PCs sprites are marked from adulthood as destined for great things, their childhoods before that point vary as widely as any other ancestry. That said, the tendency of most sprites to live either apart from civilization or in small villages means they rarely have backgrounds related to cities or large organizations and more likely wereacrobats,animal whisperers,artists,entertainers,gamblers,herbalists,hermits,nomads, orscouts. Sprites are most oftenbards,rogues, orsorcerers, though spriterangersanddruidsdo exist and tap into their love of the natural world. Likewise, spritewitchesandwizardsare even more enthusiastic about learning the secrets of magic, and spriteoraclesapproach the contradictions of their mystery from the experience of living the contradictions between the fey and mortal worlds." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("efd2210a-599f-42b9-b89d-44fbfa2df6cb"), Type = TextBlockType.Text, Text = "Sprite names are based entirely on their parents' whimsy. Sprites often adopt additional monikers later in life or change those assigned to them at birth; this is neither frowned upon nor considered abnormal." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Riding PCs" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As a Tiny creature, a sprite PC weighs so little and takes up so little Bulk that it doesn't cause issues to hitch a ride in a sack, shoulder, or other position on another PC. However, the amount of coordination required to ensure you don't get in each other's way or jostle each other into losing actions makes this tactic unfavorable for most fellow adventurers during combat. If you're riding along with another PC or similar non-minion intelligent creature, roll both your initiatives and use the lower of the two results. You act in either order on the same initiative count. While traveling in this way, you each gain two actions at the start of your turn, instead of three, since they spend one action keeping you balanced on their back, and you spend one action maintaining your grip." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Sprites in Society" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Sprites who mingle openly among mortals find that mortal superstitions about fey regularly color their interactions with sprites, for both good and ill. Mortals often believe half-remembered tales, frequently about a different sort of fey altogether; most sprites find this hilarious and play along. Mortals uninterested in sprites' pranks tend to view them as nuisances and treat them accordingly. Additionally, sprites' small stature and excitable natures sometimes cause mortals to treat them like children. Sprites vary in their reactions to this sort of treatment from annoyance to good humor, and sometimes even a realization that they can get away with more this way." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Tiny PCs" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "PCs are typically Small or Medium size, but most sprite PCs are Tiny instead! Being Tiny comes with its own set of rules about space and reach. Your Tiny sprite can enter another creature's space, which is important because your melee Strikes typically have no reach, meaning you must enter their space to attack them. Like other Tiny creatures, you don't automatically receive lesser cover from being in a larger creature's space, but circumstances might allow you to Take Cover. You can purchase weapons, armor, and other items for your size with the same statistics as normal gear, except that melee weapons have a reach of 0 for you (or a reach 5 feet shorter than normal if they have the reach trait). Remember to adjust the Bulk of items and your Bulk limit for Tiny size (see Items and Sizes)." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Magical Strikes" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your inherent magic pervades your entire being. All your Strikes are magical, whether with unarmed attacks or weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Fey.ID;
            yield return Traits.Instances.Sprite.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("ab99f3df-6742-4eab-99a6-5b10790c5d4b"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("35d1d8ea-67c1-4677-9c5f-f5ec89d62cb6"), MovementMethod.Walking, ModifierType.Add, modifier: 20);
            builder.GainSpecificAbilityBoost(Guid.Parse("0abcc6ce-981e-4504-b93e-064cdc248087"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("33efa71b-49b0-4db9-a9cf-fce957f71979"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("510ea0b1-0b07-4a81-9ec1-5df0c27dbb84"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("2042cd11-c7a4-41a9-85ae-0e5c1d46885c"), Stats.Instances.Strength.ID);
            builder.GainSpecificLanguage(Guid.Parse("0ce75061-1339-4c44-bf4b-9e6f458644d4"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("18cc3b7c-2975-454f-8e69-94ca38426ebc"), Languages.Instances.Sylvan.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add magical Strikes.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("244c8f8d-634c-48ab-a3d6-b2c336b95b57"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 127
            };
        }
    }
}
