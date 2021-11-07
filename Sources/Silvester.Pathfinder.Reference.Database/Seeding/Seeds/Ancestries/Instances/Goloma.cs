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
    public class Goloma : Template
    {
        public static readonly Guid ID = Guid.Parse("8f8de634-1925-4472-9388-79bb19c36cfd");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 30, 
                Name = "Goloma", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Biqkuul, Ehbouja, Haamaah, Kouzo, Quaerjii, Tebaazu, Uruueda, Zekuukeu"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("5fb7daae-342d-4a99-a927-a855cdd01a72"), Type = TextBlockType.Text, Text = "Golomas fear most other people and deliberately use their unusual biology to frighten off those they consider to be dangerous predators. Rarely seen and poorly understood, golomas' many-eyed and wooden faced visages instill terror in most they meet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though just as capable of being dangerous as any intelligent creature on Golarion, golomas have a deep-rooted psychological understanding that they are prey, and that all two-eyed people are predators. As a result, golomas rarely reveal themselves to others, and when they do, they often adopt threatening personas as a means to protect themselves. Even those few golomas who venture out into greater Mwangi society often have trouble relating to other ancestries, due to their strong differences in perception and mindset." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("edaf63d4-cb6e-4b2e-bb92-f9dd388527bf"), Type = TextBlockType.Enumeration, Text = "Instinctively process large amounts of disparate information quickly and efficiently." };
            yield return new TextBlock { Id = Guid.Parse("94773308-40f6-490c-ab94-4825e74d3beb"), Type = TextBlockType.Enumeration, Text = "Project an air of intimidation to conceal your nervous disposition." };
            yield return new TextBlock { Id = Guid.Parse("6087b28a-97f5-4705-8509-644b1efb9e28"), Type = TextBlockType.Enumeration, Text = "Have difficulty distinguishing individual objects or people from others that are similar." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("981954b6-ec0d-4740-aed7-3f8ede9fe678"), Type = TextBlockType.Enumeration, Text = "Are frightened by your strange physiology." };
            yield return new TextBlock { Id = Guid.Parse("6922bcff-9fd8-4867-8ae5-28531a17b451"), Type = TextBlockType.Enumeration, Text = "Mistake your difficulties with identifying distinct people from one another as indifference." };
            yield return new TextBlock { Id = Guid.Parse("0c6792be-fb5e-41d7-b8db-cd90c16761e7"), Type = TextBlockType.Enumeration, Text = "Are awed by your skill at noticing minute details at a glance and drawing rapid conclusions." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("97d10cf6-9f00-4677-a2c6-e621201f2da3"), Type = TextBlockType.Text, Text = "Golomas are humanoids with rough skin that ranges in color from warm brown to ebony, although sickly gray or white individuals with albinism are not uncommon. Their fingers and feet are coated with a thin layer of chitin. A goloma's face is an oblong wedge made of smooth chitin, almost resembling a wooden mask. Protruding from this face are eight gelatinous, shining eyes. A goloma's mouth and jaw are located beneath their face-plate, and a bony crest juts from the top of their chitinous visage. The back of a goloma's head and neck is coated in black hair that is filled with thousands of tiny, peering eyes. These eyes tend to glow and squirm as they look around—an unsettling sight for most." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("a9af91a4-d81b-4e1c-91c0-7713d99a2973"), Type = TextBlockType.Text, Text = "An ancient goloma story states that during a calamity unleashed long ago, gods and demons burst forth from the earth to steal the eyes from other creatures. Only the golomas and others who were in hiding were spared—yet golomas soon began to be hunted by the now two-eyed people, who were hungry to take goloma eyes to replace what they had lost. This accurately sums up most golomas' mentalities: to be exposed is to be vulnerable, and to trust a stranger is deadly. Golomas usually travel and live with groups of other golomas, as this is where they feel most comfortable." };
            yield return new TextBlock { Id = Guid.Parse("291dd5b1-b565-4aef-a828-2429a1093369"), Type = TextBlockType.Text, Text = "Golomas learn at a young age to be vigilant at all times, observing the environment for any irregularities and then reacting with quick, calculated instinct rather than deliberative action. Other ancestries often perceive golomas to be paranoid and hypervigilant. Golomas are also better at wide-scale observation than observation of specific things—they can easily notice commonalities across large fields but have difficulty remembering what a specific object or creature looked like. This only increases their paranoia, as they have trouble visually distinguishing known friends from potentially hostile foes." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("33aeee1b-9569-49a0-84fc-7dd1b7df0bd0"), Type = TextBlockType.Text, Text = "Golomas tend to focus on their own survival and thus are typically neutral, though those who find more comfort in conformity than others trend toward lawful alignments. Golomas often pay homage toKalekot, a deity of protective fear, as the guardian of their people, though not one to be trusted. Kalekot is called upon to curse those who victimize golomas, as most feel that justice can only be attained using supernatural means. Other popular gods includeMazludehandGrandmother Spider, who encourage the strength of community, though a typical goloma's idea of community is often very insular." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("e97d2a14-2fd0-4fb9-8a9e-f917ba37d13e"), Type = TextBlockType.Text, Text = "Golomas keep to themselves in self-sufficient societies, and commonly possess backgrounds such ashunter,laborer,artist, orfarmhand. Golomas who keep a lookout for their communities might bescoutsoracolytes. They make excellentclericsof more unusual gods—those who are less attuned to a typical humanoid mindset and seek worshippers who can truly understand them.Druidsare not uncommon among golomas, and they also make excellentinvestigators." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("86cc123a-4dba-4195-ab40-d5c6ea8faf87"), Type = TextBlockType.Text, Text = "A goloma's true name is kept among golomas, as there are hundreds of cautionary tales of what could happen if another creature learns a goloma's true name. Names tend to lack soft syllables, which golomas often struggle to pronounce, and typically consist of hard consonants and individually enunciated vowels instead. Among other people, golomas tend to use names that are intended to be intimidating, taking elements and sounds fromAklo,Necril, or words from local languages that seem to cause strong reactions." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Eyes in Back" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have eyes that point in several different directions and instinctively notice movement in the peripheries of your vision. When you use the Seek basic action, you can look for creatures in two areas instead of one. If precision is necessary, you can select two 30- foot cones or 15-foot bursts within line of sight instead of one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Goloma.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("6b6207bc-9ef1-40a2-94db-d65c7e8389f7"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("08db278d-fe3f-42d4-a338-b0525a77fe5b"), MovementMethod.Walking, ModifierType.Add, modifier: 30);
            builder.GainSpecificAbilityBoost(Guid.Parse("f8378a19-752e-4b1d-af50-1420f05bcfbe"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("abc090d6-506c-4274-b793-7503546d8d26"));
            builder.GainSpecificLanguage(Guid.Parse("4c4b3e07-d05f-45cd-8d16-5a2e56411f1c"), Languages.Instances.Goloma.ID);
            builder.GainSpecificLanguage(Guid.Parse("6359db0b-c886-4277-abd2-d875221bcfe2"), Languages.Instances.Mwangi.ID);
            //TODO: Add intelligence modifier languages.
            //TODO: Add eyes in back effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4148489-87bf-4347-b491-e4fbedb49231"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 115
            };
        }
    }
}
