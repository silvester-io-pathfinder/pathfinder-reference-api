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
    public class Leshy : Template
    {
        public static readonly Guid ID = Guid.Parse("f3c3b266-4f62-48cc-854d-925ceb6c57c2");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Leshy", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Scarlet in Summer, Verdant Taleweaver, Lurking Hunter, Masterful Sun Drinker, Noon Sky Evening Song, Snowy Pine Branch, Cascading Rapids"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("75c3648c-6cca-45da-ba6f-50be931a2772"), Type = TextBlockType.Text, Text = "Guardians and emissaries of the environment, leshies are immortal spirits of nature temporarily granted a physical form." };
            yield return new TextBlock { Id = Guid.Parse("dec3b0ee-7109-42dc-b7bd-0b69ea0550f7"), Type = TextBlockType.Text, Text = "Leshies are “born” when a skilled druid or other master of primal magic conducts a ritual to create a suitable vessel, and then a spirit chooses that vessel to be their temporary home. Leshies are self-sufficient from the moment the ritual ends, and so they do not depend upon these druids for care, though it is not uncommon for leshies to maintain lifelong bonds with their creators." };
            yield return new TextBlock { Id = Guid.Parse("86716e57-b0eb-426f-a698-498d911fa2f9"), Type = TextBlockType.Text, Text = "Not all leshies have a strong enough spirit to strike off completely on their own, however. Weaker nature spirits can form only tenuous bonds that are just strong enough to animate Tiny bodies. These spirits become leshy familiars, acting as companions to their druid creators. Independent leshies are often protective of such leshy familiars, advocating for them to be treated with dignity and respect." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("49487c58-4cf5-4829-b518-a4050432ed1a"), Type = TextBlockType.Enumeration, Text = "Act as a traveling agent for natural guardians who are unable to leave their territories." };
            yield return new TextBlock { Id = Guid.Parse("9d202abc-6ef5-4dcd-a28d-33a6385a9eb9"), Type = TextBlockType.Enumeration, Text = "Encourage civilizations you encounter to cooperate with nature and build their cities in ecologically friendly ways." };
            yield return new TextBlock { Id = Guid.Parse("5f7f9315-3c40-430c-8ed6-12b2bc35d5aa"), Type = TextBlockType.Enumeration, Text = "Become attached to new friends you make on your journeys." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("297bbc58-2b0f-401f-8eaa-a2d033582a3c"), Type = TextBlockType.Enumeration, Text = "Think of you as a curiosity due to your spiritual origins." };
            yield return new TextBlock { Id = Guid.Parse("c2bed4d3-b062-4795-b394-7195c457693e"), Type = TextBlockType.Enumeration, Text = "Judge you by your looks, treating you sweetly if you are cute or reacting with horror if you are frightening." };
            yield return new TextBlock { Id = Guid.Parse("985859d5-4427-4c8d-a2d9-959131acfb2f"), Type = TextBlockType.Enumeration, Text = "Assume you know only about nature and are unfamiliar with civilization and society." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("acbb076f-3309-4668-bc67-f9d5c2ecca16"), Type = TextBlockType.Text, Text = "Leshies are as varied as the material used to create their vessels, usually appearing as a bizarre mishmash of various plants or fungi. Their bodies are vaguely humanoid in shape, with numerous characteristics of the plant or fungus from which they were made. A typical leshy is about 3 feet tall. Due to the nature of the ritual used to create a leshy, leshies begin their lives as adults. As spirits, they do not age, and a leshy could potentially remain in the same vessel forever—though leshies rarely consider this outcome to be desirable." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("55b6c3d3-5a0f-4956-8434-3b3a19022ba1"), Type = TextBlockType.Text, Text = "Though guardian leshies often congregate, traveling leshies are not naturally drawn to others of their own kind. To most leshies, the concept of family is not a matter of birth, but rather determined by bonds of loyalty and friendship. Leshies are dedicated allies, but they have little tolerance for those who would despoil nature. As much as they are happy to accept someone who earns their trust into their family, they expect family members to look out for them and their natural wards in return. A betrayed leshy might not directly attack those who slight them, but they might withdraw support at a critical moment or leave their betrayers to get lost in the wilderness." };
            yield return new TextBlock { Id = Guid.Parse("fb567ff8-4b36-4762-a2c2-e5fe67e1f11a"), Type = TextBlockType.Text, Text = "Leshies are grouped into categories akin to ethnicities, but these are not connected to physical features; rather, they represent broad categories of characteristics of their spirits. Certain spirits are more likely to gravitate toward particular physical bodies, though those familiar with leshies know that this predisposition is far from absolute. Leshies often take pride in their own appearances and appreciate beauty of all kinds in others, but they rarely form judgments based on physical appearance. Leshies’ genders are determined by the spirits that inhabit their bodies. Leshies tend to gravitate toward plant bodies that match their genders. Some leshies are exclusively male or female, while many consider themselves both. Others, particularly fungus leshies, tend toward far more complex expressions of gender, or eschew the concept entirely." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ed3db7a1-8040-48ab-b70b-d0d909414c55"), Type = TextBlockType.Text, Text = "A leshy can be of any alignment, depending on what spirit inhabits their body, but their outlook often includes a neutral element. Religion is not particularly significant to most leshies. Those with a philosophical bent lean toward the Green Faith, and Gozreh is the most popular deity among faithful leshies. Some leshies also venerate green men, powerful spirits of nature that act as regional guardians." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("10328a15-3910-4578-a16a-1dabc2c3d033"), Type = TextBlockType.Text, Text = "Some backgrounds are particularly suitable for adventuring leshies, especially those backgrounds with a tie to the natural world, such ashunter,nomad, orscout. Nature-themed classes such asdruidandrangerare popular choices for leshies. As druids, leshies gravitate toward theleaf order.Bardis also a good fit for leshies with a love of storytelling; such leshies often inhabit vine leshy bodies." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("dd193aee-2706-4823-b98a-5dd405908c39"), Type = TextBlockType.Text, Text = "Leshies choose and change their names multiple times throughout their lives. These names often represent a facet of their personalities or values, though another common naming convention is to use descriptions of a natural feature they admire. Some leshies even use a cycle of names that changes to align with natural phenomena, such as names based upon the season or the time of day." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("3cb1f4cd-847e-470e-8bef-95f3eb3f487a"), Type = TextBlockType.Heading, Text = "Green Men" };
            yield return new TextBlock { Id = Guid.Parse("04e9facc-dd11-49fd-930d-69cd51d7b86b"), Type = TextBlockType.Text, Text = "The first beings to create leshys were green men, sometimes referred to as leshy kings. These legendary guardians emerge when countless spirits of nature merge and rise to divinity. Many green men discovered how to draw upon the connection they held with other spirits of nature, coaxing them into physical forms. These early leshys worked alongside green men to defend their verdant homes. Though modern leshys have far more varied motivations, many still respect and revere the gods that first gave them a chance at mortal life." };
            yield return new TextBlock { Id = Guid.Parse("d5ce330d-585f-4b01-8e5f-57d3e41d68e2"), Type = TextBlockType.Text, Text = "While green men were indifferent to most non-plant creatures, they didn't scorn the assistance of druids. In time, some green men taught trusted allies a version of the ritual to create leshys." };

            yield return new TextBlock { Id = Guid.Parse("c271a516-eed7-4102-bdd3-35aa0cc5edd6"), Type = TextBlockType.Heading, Text = "Leshy Resurrection" };
            yield return new TextBlock { Id = Guid.Parse("adc05e21-1fa2-4291-8121-fe3d048530da"), Type = TextBlockType.Text, Text = "Leshys who lose their physical form incorporate the changes they experienced in life into their spirit. Even though a leshy's spirit isn't the same as the soul of many ancestries, resurrection magic can still restore it to their most recent body. Should the ritual fail, it's usually because a leshy has shed too many of their memories and attachments, rather than due to Pharasma's judgment." };

            yield return new TextBlock { Id = Guid.Parse("be0f2907-d607-449c-abc5-874ddc24c345"), Type = TextBlockType.Heading, Text = "Life without Form" };
            yield return new TextBlock { Id = Guid.Parse("fb7301a6-d4e6-4825-93f0-25c9f3edf548"), Type = TextBlockType.Text, Text = "Leshy spirits are beings of pure vital essence without any of the otherworldly quintessence known as spiritual essence. Existing without physical form allows them closer contact with memories from their distant past, but this broader perspective gradually erodes memories of their experiences in their most recent body." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("a16daf01-cd0b-46c1-af61-f4cbf363a4f0"), Type = TextBlockType.Heading, Text = "Plant Nourishment" };
            yield return new TextBlock { Id = Guid.Parse("d578ad7f-8558-45c9-929f-1e52a9756a57"), Type = TextBlockType.Text, Text = "You gain nourishment in the same way that the plants or fungi that match your body type normally do, through some combination of photosynthesis, absorbing minerals with your roots, or scavenging decaying matter. You typically do not need to pay for food. If you normally rely on photosynthesis and go without sunlight for 1 week, you begin to starve. You can derive nourishment from specially formulated bottles of sunlight instead of natural sunlight, but these bottles cost 10 times as much as standard rations (or 40 sp)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Leshy.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("a5a8123f-89c7-48d7-a05b-c35da147f369"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("9b2610f2-791c-4201-aa86-c8a164255f80"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("43b23227-cd50-4fc1-baef-c6198e260658"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("1d52c1a6-ff45-4694-a48f-02757b872fb3"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("a3e6f52e-9443-461f-b17d-277f2b3ece49"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("3d8b1bda-23da-40f2-9dc2-400279e9ed67"), Stats.Instances.Intelligence.ID);
            builder.GainSpecificLanguage(Guid.Parse("f436c6af-81b4-4317-b98e-0d5778b2455e"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("382f184d-9d98-4a0c-bd99-910c6e55878b"), Languages.Instances.Sylvan.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("fe32d184-a5c2-4ee9-baf8-7edc8f75db2c"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add nourishment effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41c0c39e-9071-429f-bbb1-c988691f2bce"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }
    }
}
