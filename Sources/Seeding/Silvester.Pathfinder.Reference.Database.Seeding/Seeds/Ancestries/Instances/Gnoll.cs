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
    public class Gnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("457d707a-8126-4841-b313-5da8ce9ed962");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Gnoll", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Baobab, Jackal, Onyx Elephant in Shadows, Red Thorn, Unbent Iron Reed, White Acacia, Wistful Tooth, Woodpecker"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("d6ae5b36-614b-45a7-8169-b4106c280246"), Type = TextBlockType.Text, Text = "Powerfully-built humanoids that resemble hyenas, gnolls are cunning warriors and hunters. Their frightening visage and efficient tactics have given them an ill-starred reputation." };
            yield return new TextBlock { Id = Guid.Parse("ef68f7df-3c2e-4d2d-881e-2bbb2b33441e"), Type = TextBlockType.Text, Text = "In lands to the east, such as Katapesh, gnolls have earned themselves well-deserved reputations as brutal slavers and demon-worshippers. Even in the Mwangi Expanse, many outsiders believe that gnolls are witches, cannibals, and worse. The truth is more complex." };
            yield return new TextBlock { Id = Guid.Parse("df6781ee-544a-4a8c-9308-7a008b1e818e"), Type = TextBlockType.Text, Text = "Mwangi gnolls, known to themselves as “kholo,” are eminently practical and pragmatic hunters and raiders. To gnolls, honor is just another word for pointless risk. Any loss of a gnoll affects not just the individual, but their packmates and kin as well. Wasting time on anything but victory, whether it's mercy or cruelty, is seen as little shy of immoral. Gnolls see effectiveness as a cardinal virtue and believe that the best fight is one that never gives the opponent a chance to strike back. Mwangi gnolls are masters of ambushes, tactical feints, and psychological warfare—none of which endears them to their neighbors." };
            yield return new TextBlock { Id = Guid.Parse("bd4b8ec0-7c6b-4d46-a8ba-97089a4c8076"), Type = TextBlockType.Text, Text = "Equally misunderstood is the gnoll practice of ancestor worship and endocannibalism. Gnolls consume their dead as a sign of reverence, holding a grand feast and transforming the bones of the fallen into art or weapons. Gnolls extend this honor to respected foes, hoping to bring their enemy's cunning or strength into the clan. While it's a sign of admiration, not everyone sees it that way." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("cd8c3c1d-dae1-4923-85e5-5da259e6110a"), Type = TextBlockType.Enumeration, Text = "Always try to work smarter, not harder." };
            yield return new TextBlock { Id = Guid.Parse("bcb575fc-5190-4f4d-90f6-f3c556e209eb"), Type = TextBlockType.Enumeration, Text = "Be very physically demonstrative—often hugging, punching, or licking your friends." };
            yield return new TextBlock { Id = Guid.Parse("5c637339-6acb-43bc-8dfd-f5c21e5a8d7b"), Type = TextBlockType.Enumeration, Text = "Keep a bone from a favorite relative to ask for advice." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("c4247a0f-59fc-4ed1-ba8a-3f4f41fb7b18"), Type = TextBlockType.Enumeration, Text = "Are intimidated by your size, teeth, and eerie laugh." };
            yield return new TextBlock { Id = Guid.Parse("10694779-d122-4d2b-88ac-f60e009a151c"), Type = TextBlockType.Enumeration, Text = "Assume that you are dishonorable or worse." };
            yield return new TextBlock { Id = Guid.Parse("035dd132-3cc1-408b-b5e3-b8c460d654f3"), Type = TextBlockType.Enumeration, Text = "Respect the brutal efficiency of your hunting style." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("30eb5da0-b7f2-46d3-9018-4b17873ac4ad"), Type = TextBlockType.Text, Text = "Gnolls are large, hyena-like humanoids with short muzzles, sharp teeth, and large and expressive round ears. Their bodies are covered in shaggy fur, rougher on the back and softer and lighter on the stomach and throat, usually in an off-white, tan, or brown shade—spots and stripes are both common. Gnolls typically stand between six and seven feet tall. Women are usually about a head taller than men, and correspondingly stronger. Gnolls are considered adults at fifteen, and live about 60 years on average, though some can reach a hundred or more in good health." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("94221ed2-538e-4549-84ab-163b448fcda4"), Type = TextBlockType.Text, Text = "Kholo generally live in clans of 10 to 20 interrelated family groups, containing between 100 to 200 gnolls. They are ruled by a council of female gnolls, typically selected from the oldest members of each family. This council of elders selects one of their number as a Chief Elder, who is essentially the first among equals and sets the agenda. The council is advised by the clan's bonekeeper and storyteller, as well as one or more younger gnolls who lead hunting and raiding packs." };
            yield return new TextBlock { Id = Guid.Parse("59ea8eb8-e529-4945-9c94-cb6a031e213b"), Type = TextBlockType.Text, Text = "Bonekeepers focus on tending to the wishes of gnoll ancestors and gods— they take their name from the ancestral bones that festoon their clothing and homes. Storytellers serve as teachers and sages, and are expected to have an encyclopedic knowledge of clan history, regional lore, and anything else relevant to the clan. They usually speak several languages." };
            yield return new TextBlock { Id = Guid.Parse("ba05c9e2-53a6-4550-b90e-f962f2f6fc80"), Type = TextBlockType.Text, Text = "Kholo women typically work as hunters, warriors, and leaders, while men become artisans, caretakers, and gatherers. However, adherence to gender roles varies from clan to clan. Members of either gender can become bonekeepers or storytellers, and these positions often routes to authority for male gnolls." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("b9cbf626-ac8c-47ee-b80b-1ea1c95e153c"), Type = TextBlockType.Text, Text = "Mwangi gnolls have an unsentimental, matter-of-fact approach to life, and prioritize results over methods. They are usually loyal and generous to their people and ruthless toward outsiders—gnolls are typically chaotic neutral but can skew good or evil depending on who they view as “their people.”" };
            yield return new TextBlock { Id = Guid.Parse("7829d0a1-4bc6-4a7c-b61d-5842f93773ff"), Type = TextBlockType.Text, Text = "Gnolls appeal to their ancestors on a day-to-day basis, invoking their kin to bless cubs, ward off disease, or grant luck on hunts. Gnolls call upon the gods on special occasions or in times of great crisis. Most kholo give homage toCalistriaandShelynas the Elder and Younger Sisters, twin goddesses of power and beauty.Nethys, the Brother, is the patron of bonekeepers, andLamashtu, while a popular deity in other gnoll societies, is propitiated as the Old Mother, a goddess called upon only as a very last resort, and otherwise begged to stay away." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("cb007a55-0c09-428b-a26f-38e6113e9a1f"), Type = TextBlockType.Text, Text = "Some gnolls leave their clans to work as mercenaries and adventurers, learning new skills, earning wealth, and gaining allies that will one day benefit their people. Other adventuring gnolls are without clans, left orphaned by some disaster or exiled, fairly or not, for some crime. All gnolls are strongly pack-minded and tend to adopt their friends as honorary gnolls and packmates." };
            yield return new TextBlock { Id = Guid.Parse("cb2b8adf-2217-40d2-a1cd-79b48ee2f780"), Type = TextBlockType.Text, Text = "Gnolls usually hail from theanimal whisperer,entertainer,herbalist,hunter,nomad,scout, andwarriorbackgrounds. Therangeris the archetypal gnoll class, a cunning warrior of the wilderness, but gnolls also make excellentbarbariansandfighters, and their love of clever tricks make them outstandingrogues. Bonekeepers are usuallywitches, treating ancestral spirits more like squabbling colleagues than objects of worship, while storytellers are typicallybards." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("c24b6655-184d-4c6f-9971-0837ea1ff07d"), Type = TextBlockType.Text, Text = "Newborn kholo are given a root name, typically that of a bone, plant, or animal (though never Hyena, as this is considered narcissistic and arrogant). As a gnoll reaches certain milestones in life, they add descriptors to their name. Root names are often passed down through families, while descriptors are chosen to fit the gnoll's personality, usually in raucous ceremonies." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("5da46691-5e17-43a5-9032-9beae2939ca3"), Type = TextBlockType.Heading, Text = "Bite" };
            yield return new TextBlock { Id = Guid.Parse("9c75e640-6944-404f-8673-13b30e7d9faa"), Type = TextBlockType.Text, Text = "Your sharp teeth and powerful jaws are fearsome weapons. You have a jaws unarmed attack that deals 1d6 piercing damage. Your jaws are in the brawling group." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Gnoll.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("164a0695-075b-40be-879e-3aa6b65bdec9"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("3e7f68fa-6a44-4192-b5cb-8faf9112238f"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("780dec0f-b44f-4410-b48e-bc7d6f9db7ac"), Stats.Instances.Strength.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("b1918d10-afa5-4d8e-bcad-96ae8d675eba"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("ac044b4e-13fd-41a2-bdbe-2a96b65a47a4"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("cc8c3827-5e17-4e62-babe-b6367783efbc"), Stats.Instances.Wisdom.ID);
            builder.GainSpecificLanguage(Guid.Parse("6cf07095-af38-4c0d-a72e-5b78364f2045"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("845581cf-a6e0-4279-a343-5736337c5e44"), Languages.Instances.Gnoll.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("a302495b-b850-41c8-924a-d7976e377a57"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.GainSpecificUnarmedAttack(Guid.Parse("1be60cf5-722d-4081-a753-99fa4fa058c9"), UnarmedWeapons.Instances.Jaws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0616a64f-8a17-496e-9615-a01d7d4f1589"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 111
            };
        }
    }
}
