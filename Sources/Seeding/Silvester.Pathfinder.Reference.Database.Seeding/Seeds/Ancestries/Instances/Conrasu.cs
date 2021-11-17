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
    public class Conrasu : Template
    {
        public static readonly Guid ID = Guid.Parse("8db24b28-91b8-4c33-8fa3-cbfb33970d7a");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Conrasu", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Automa, Azubu, Dumi, Emeka, Ganizadi, Locu, Incanes, Radi, Shell, Weave"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("6e2b5538-f28b-4e96-8261-8e7a96d6a77d"), Type = TextBlockType.Text, Text = "Conrasus are shards of cosmic force given consciousness who construct intricate exoskeletons to interface with the mortal world. Both an integral part of the underlying processes of the universe and strangely set apart, conrasus look to aeons to understand their existence." };
            yield return new TextBlock { Id = Guid.Parse("c0c5b7c0-70b7-4076-9818-55f67dc84e07"), Type = TextBlockType.Text, Text = "Conrasus aren't entirely clear on their own origins. Some historians think them a failed experiment of a wizardly cabal—possibly a splinter of artificers from the ancient Jitska Imperium—who desperately hoped to bind a pleroma to bolster their army but who accidentally conjured shattered scraps of the aeon instead. Others believe conrasus were built by their ancestors using an accelerated, iterative evolution process as natural as one designed by those who build portions of their own bodies could ever hope to achieve. Most likely, it is a mix of the two." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("98b4ec6a-38ff-4aa4-93be-1710885f81a4"), Type = TextBlockType.Enumeration, Text = "Do your best to determine and act upon the will of your guiding aeon." };
            yield return new TextBlock { Id = Guid.Parse("2013ca8c-e432-4548-a3de-54a912115e22"), Type = TextBlockType.Enumeration, Text = "Use rituals and repetitive actions as a means to meditate and reflect on your purpose." };
            yield return new TextBlock { Id = Guid.Parse("00bfa18d-5609-4f5c-8f84-e7aa8df1bde4"), Type = TextBlockType.Enumeration, Text = "Have difficulty applying your cosmic instincts and senses to a physical existence." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("f6cdb376-7407-40e6-8d07-2f39cf555563"), Type = TextBlockType.Enumeration, Text = "View you as part of a hivemind at best or lacking in free will at worst." };
            yield return new TextBlock { Id = Guid.Parse("38fcbc22-0151-4145-bfed-2b70ce48e373"), Type = TextBlockType.Enumeration, Text = "Have trouble understanding your perspective or attempts at communication." };
            yield return new TextBlock { Id = Guid.Parse("4ab744d6-5025-4add-ae8f-caca91d36859"), Type = TextBlockType.Enumeration, Text = "Look to you as the expert on any matters involving aeons or related beings." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("fc9057fe-ffcd-48c1-92b3-1a5294adc269"), Type = TextBlockType.Text, Text = "The true form of a conrasu is an abstract chunk of spiritual essence. While their being exists beyond the truth of humanoid senses, to the mortal eye, their body usually resembles a globe of light, darkness, or space. Floating, internal pinpricks of illumination sit inside the ball, slightly obscured as if peeking through a gelatinous substance. These “cores” surround themselves with bodies made out of still-living wood, creating the form that most people recognize as a conrasu. Conrasus themselves are called to a path and, once they find it, shape frames to create a suitable form, leading to a wide variety of appearances." };
            yield return new TextBlock { Id = Guid.Parse("4a31f74e-1ac4-401c-b7be-71d7ef19d6ee"), Type = TextBlockType.Text, Text = "As a conrasu ages, the supple green wood of their body hardens, causing their limbs to lose mobility. Conrasus must constantly grow new arms and roots for their living exoskeleton, leaving their frozen limbs as immobile effigies along their shell." };
            yield return new TextBlock { Id = Guid.Parse("4d4504eb-0292-4b97-a7e1-8d8c904ad2e3"), Type = TextBlockType.Text, Text = "Conrasus can't maintain their integrity without their wooden exoskeletons. A conrasu that loses its exoskeleton dissipates and dies, though they can be returned to life with magic like other beings." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("4014555a-1062-4ce7-87f6-37110a08ed85"), Type = TextBlockType.Text, Text = "There are three distinct types of conrasus. Maintainers tend and care for others, believing they must cultivate a proper balance between various forces. Shapers build and direct those around them, and feel that balance is maintained by those who strive to preserve the world's equilibrium. Lastly, correctors fix problems of all sorts, often acting as stalwart bastions of law who  perceive the world in absolutes, with few to no shades of gray. True balance can be achieved only in cases where pressure and force have been applied to make necessary changes." };
            yield return new TextBlock { Id = Guid.Parse("a75aca2b-579f-4375-99d5-2b02b8739a9e"), Type = TextBlockType.Text, Text = "On rare occasions, a conrasu may hear and heed the call of another form of extraplanar being. One might serve a psychopomp, another an archon, and yet another might become a witch and adopt an unknown figure as a patron." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ccb7ac98-363e-4618-9812-8351ec8f40ae"), Type = TextBlockType.Text, Text = "Many conrasus consider themselves bound to a specificaeon, following them like a deity and doing what they believe to be the aeon's bidding. As a result, almost all conrasus are lawful neutral in alignment." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("abe402ca-e385-4ff6-91c8-cbdb7ea8b290"), Type = TextBlockType.Text, Text = "Maintainers who become adventurers are oftenwizards,bards, orclericswho offer their magic and knowledge to the group and subtly nudge the party as needed. Correctors tend to becomechampions,clerics, andfighters, forming heavy and hard living wood armor around themselves to keep them safe from harm. The rare shaper might travel with a group as adruidor even abard, usually to accomplish a goal they believe lies outside of the enclaves." };
            yield return new TextBlock { Id = Guid.Parse("9df0ca5b-e357-41c9-bd51-346aeed192e0"), Type = TextBlockType.Text, Text = "No matter the path a conrasu finds themselves on, they tend to come from similar backgrounds.Field medicandherbalisttend to fit those who find themselves comfortable in their homes and with those of their nursery while conrasus ofnomadoremissarybackgrounds tend to enjoy roaming from place to place." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("c049a220-6f5a-4d8b-b3b4-fa41e962d58c"), Type = TextBlockType.Text, Text = "Conrasus have little in the way of consciousness as others understand it before they self-actualize and leave the nursery-towns where they sprouted. That includes a name, a concept of gender, and even the passage of time beyond their little bubbles—these are picked up in the wider world. As a result, a conrasu might have nearly any appellation." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("2cb08bd9-77b8-41a0-be94-6dc621eff415"), Type = TextBlockType.Heading, Text = "Sunlight Healing" };
            yield return new TextBlock { Id = Guid.Parse("fa298b36-52f0-448e-9ce4-92b387f8c478"), Type = TextBlockType.Text, Text = "A conrasu can enter a meditative, healing state as a 10-minute activity when exposed to direct sunlight, in which case they recover 1d8 Hit Points. At 3rd level, and every 2 levels thereafter, this healing increases by 1d8. Once a conrasu has recovered Hit Points in this way, they are temporarily immune to further uses of Sunlight Healing for 1 day" };

            yield return new TextBlock { Id = Guid.Parse("9fba8328-27a3-4551-bbee-ccab8165ec4d"), Type = TextBlockType.Heading, Text = "" };
            yield return new TextBlock { Id = Guid.Parse("b6fb4d30-d68a-44a1-baed-046214d12ff8"), Type = TextBlockType.Text, Text = "" };

            yield return new TextBlock { Id = Guid.Parse("b4a00065-4b85-4139-ae3a-69cf936cfafb"), Type = TextBlockType.Heading, Text = "" };
            yield return new TextBlock { Id = Guid.Parse("dd19e7d3-d72c-4269-96f9-ecb852daa0bb"), Type = TextBlockType.Text, Text = "" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Aeon.ID;
            yield return Traits.Instances.Conrasu.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("eedbd697-a751-4d6d-8bfd-cd14e1f09e3d"), ModifierType.Add, modifier: 10);
            builder.ModifySpecificSpeed(Guid.Parse("013fac16-399b-4477-a299-9f3e55b0ead1"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("0d7105da-2113-4ed3-aa06-66836f584663"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("8d8141cd-1f05-4681-9c66-cf32e45da2e9"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("889ff8ee-67a6-43c7-a30b-7614a61bae88"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("38dcf091-ce60-4bc6-a0ab-b4091429b745"), Stats.Instances.Charisma.ID);
            builder.GainSpecificLanguage(Guid.Parse("04dbfe5e-cc39-4b07-b798-26123119b9ba"), Languages.Instances.Mwangi.ID);
            builder.GainSpecificLanguage(Guid.Parse("f0cbc96c-1082-4d36-a5dd-ec0deda82620"), Languages.Instances.Rasu.ID);
            //TODO: Add intelligence modifier languages.
            //TODO: Add the sunligh healing
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd129c21-5616-4f96-94b8-33c74277054e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 107
            };
        }
    }
}
