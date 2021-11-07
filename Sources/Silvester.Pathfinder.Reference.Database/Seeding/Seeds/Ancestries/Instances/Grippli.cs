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
    public class Grippli : Template
    {
        public static readonly Guid ID = Guid.Parse("eb660b37-7040-4930-8037-58e6d1d2efaf");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Grippli", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Aalpo'ol, Bogwynne, Ctaprak, Eegru, Gpoun, Gruoksh, Hrrauti, Iopo, Iykiki, Kyrsiik, Mhruugu, Oplugo, Quaasol, Yolkuu, Ztaal"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("be2dd641-b75b-41ab-800a-7a0624f7a27c"), Type = TextBlockType.Text, Text = "Gripplis are a shy and cautious people who generally seek to avoid being drawn into the complicated and dangerous affairs of others. Despite their outlook and small stature, gripplis often take bold and noble action when the situation demands it." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Reclusive and canny, gripplis are treetop survivalists who harvest their homes' bounty and defend themselves against terrible threats. Their reliance on cunning and simple tools has led to gripplis being mischaracterized as primitive, yet this overlooks their shaping of the land with hidden orchards and camouflaged causeways that allow gripplis to live in prosperous peace. Gripplis are most likely to emerge from their forest homes to trade, explore, and combat threats that would despoil the world." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("c04cd981-c658-438d-877d-d078b5e57c2f"), Type = TextBlockType.Enumeration, Text = "Seek out clever ways to exploit your environment when overcoming challenges." };
            yield return new TextBlock { Id = Guid.Parse("7adc4131-c5a2-4a90-be5b-e574fd5f92c8"), Type = TextBlockType.Enumeration, Text = "Make friends slowly, concerned by cautionary tales of exploitative strangers." };
            yield return new TextBlock { Id = Guid.Parse("ae2aada5-76b0-41d1-98f3-9ce64de3c119"), Type = TextBlockType.Enumeration, Text = "Be fiercely protective of your home or community." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("200ee706-fced-4b71-a5df-0a9ffe0275fc"), Type = TextBlockType.Enumeration, Text = "Assume you dislike cities and people who live in them." };
            yield return new TextBlock { Id = Guid.Parse("d5693be9-13d3-4d75-a09d-9e3f5e952b44"), Type = TextBlockType.Enumeration, Text = "Trust in your impartial, measured approach to understanding situations and solving problems." };
            yield return new TextBlock { Id = Guid.Parse("d63fc0f9-516c-4349-9d68-03e87dd37c0d"), Type = TextBlockType.Enumeration, Text = "Give you space, fearing that touching you would prove toxic." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("6c78d374-dcb7-4412-af93-a2e6d88954e9"), Type = TextBlockType.Text, Text = "Gripplis resemble humanoid tree frogs, with oversized eyes, wide mouths, and gangly physiques. Their slight frames and large toes afford excellent grip while climbing, while their colorful skin provides reliable camouflage that varies by their home environment— green and brown for jungle-dwelling groups, blue and orange for riparian communities, and many other colors between. A grippli grows quickly, reaching adult size of about 2 feet in height about 3 years after hatching, though they're only considered adults around age 12. Gripplis rarely live beyond 60 years, though exceptional individuals occasionally live as long as a century." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("0ffad5da-c0cc-4ad3-9bad-70bb6a5a7552"), Type = TextBlockType.Text, Text = "Gripplis lead a sophisticated hunter-gatherer lifestyle with which they reshape the landscape to suit their needs: building spillways to trap fish, seeding fruit-bearing trees, sowing cover-granting foliage for future hunts, and more techniques that often escape an agriculturist's eye. These strategies rely on community cooperation as well as dispersed populations, so gripplis commonly live in small villages, each part of a complex web of alliances and relationships. Reclusiveness has preserved grippli lives and lifestyles for millennia, yet they increasingly find themselves threatened by ancient evils and new explorers alike." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("316d0353-7f2d-45f5-944a-ef6a779dd905"), Type = TextBlockType.Text, Text = "Taught to wait, observe, and respect natural processes of life and death, many gripplis adopt neutral alignments. Those who take a more active role suppressing evils that take refuge in the jungles are often neutral good, most notably those rare fiend-keepers who absorb an evil being into their soul to contain and eventually transform its villainy through virtuous acts. Nature deities such asGozrehorErastiloften earn gripplis' respect, yet communities often prefer less prominent, more intimate divinities such asempyreal lords,psychopomp ushers, or the feyEldest." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("4378b9df-a80d-4146-90e2-f648ad744068"), Type = TextBlockType.Text, Text = "For the many gripplis who hail from remote regions, wilderness backgrounds likehunter,nomad, orscoutare excellent fits. Those more accustomed to urban areas might beanimal whisperers,bounty hunters, andherbalists.Hermitsare common, andemissariesare critical to maintaining relationships with other peoples. Thanks to their deep cultural connections to nature, gripplis make excellentdruidsandrangers. Their musical traditions are a great fit forbards. Gripplis' natural agility and perceptiveness also make them capableclerics,monks, androgues." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("1a339bd9-ccb3-42e7-a921-1cb3d0b60196"), Type = TextBlockType.Text, Text = "Grippli names often include resonant vowels and chirped consonants that remain difficult for non-gripplis to vocalize properly. Gripplis that travel widely often adopt one or more names more easily replicated by their associates." };
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Grippli.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("48490ec7-b39d-48ab-9027-c00f24e1e05f"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("c7558aaa-3539-40cf-a9c7-e5e8c737d87f"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("fca3f9d5-53d5-4f85-98b9-bf58c0f772b6"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("55513e24-4d9c-47e4-8c27-1524319e7caf"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("cf03ce51-e5ac-4aeb-9ea4-444d35f831a7"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("004a530f-8e93-4319-ad9f-ea667bc57f03"), Stats.Instances.Strength.ID);
            builder.GainSpecificLanguage(Guid.Parse("68a11703-1872-45e9-bf8c-2c30dadfe30e"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("3770e3da-6f55-49ee-b4cd-cd31fe246bfa"), Languages.Instances.Grippli.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50dcec2d-b84c-414e-be8a-84695515deee"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 119
            };
        }
    }
}
