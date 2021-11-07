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
    public class Lizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("016df51e-4cc4-4e37-9386-ad66b6adeb4f");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Lizardfolk", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Arasheg, Barashk, Essaru, Enshuk, Gishkim, Hazi, Inishish, Kutak, Nasha, Shulkuru, Tizkar, Utakish, Zelkekek"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("c1c73576-49e2-4cb7-9ebf-95d454c429fa"), Type = TextBlockType.Text, Text = "Lizardfolk are consummate survivors, heirs to empires considered ancient even by the elves." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Lizardfolk move through the societies of other humanoids with the steely reserve of born predators. They have a well-deserved reputation as outstanding rangers and unsentimental fighters. Though lizardfolk have adapted to many different environments, many of them still prefer to remain near bodies of water, using their ability to hold their breath to their advantage. As a result, lizardfolk usually prefer equipment that is not easily damaged by moisture, eschewing leather and metal for gear made of stone, ivory, glass, and bone." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("1d86dd3f-8740-4de6-aaf4-a0e3495ef3db"), Type = TextBlockType.Enumeration, Text = "Demonstrate extreme patience, even when pressured to act." };
            yield return new TextBlock { Id = Guid.Parse("8c7a1e96-ba3a-41a2-a926-7ddaf9d2f8f2"), Type = TextBlockType.Enumeration, Text = "Hold your people’s history in high regard and look to the past for solutions to present problems." };
            yield return new TextBlock { Id = Guid.Parse("d4226684-7d09-4e28-8c54-916fbffbdf03"), Type = TextBlockType.Enumeration, Text = "Strive to adapt perfectly to your environment while also keeping your culture and traditions intact." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("c14f0b90-7f31-4fff-ab13-b6619abc3f8d"), Type = TextBlockType.Enumeration, Text = "Assume you are beholden to tradition and have ancient knowledge." };
            yield return new TextBlock { Id = Guid.Parse("f7aac409-0c5d-434e-9865-1d1435d4a4e7"), Type = TextBlockType.Enumeration, Text = "See you as cold-blooded and callous due to your subdued physical reactions." };
            yield return new TextBlock { Id = Guid.Parse("017ff039-b096-4e70-9a9e-f7e344209c7a"), Type = TextBlockType.Enumeration, Text = "Respect your impressive strength and your knowledge of natural areas." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("652c9366-1338-4810-b522-d46ba0f40bcc"), Type = TextBlockType.Text, Text = "Lizardfolk vary depending on their environment, but share toothy snouts and long and powerful tails. Those from temperate or desert regions tend toward gray, green, or brown scales that aid in camouflage, while those from tropical climes are brightly colored. Many sport dorsal spikes or garish neck frills that hint at their clan lineage. Lizardfolk reach physical adulthood at age 15 and live up to 120 years. The average lizardfolk stands 6 to 7 feet tall, but grows throughout their lifetime, gaining strength and size with age." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("4268ff0f-360c-4e72-b7fd-edf24888071f"), Type = TextBlockType.Text, Text = "Known among themselves as iruxi, lizardfolk are raised communally from the moment they break from their shells. They have an oral tradition stretching back thousands of years, brought to life through epic poems, evocative carvings, and ancestral rites performed among fields of fossilized bone. Lizardfolk are passionate astrologers with one eye on the future. If they seem slow to act, it is because their long history has taught them the value of patience." };
            yield return new TextBlock { Id = Guid.Parse("65205033-bc86-438f-91d3-131bfca2ed15"), Type = TextBlockType.Text, Text = "The simple villages most outsiders associate with iruxi are the homes of migrants in outlying regions. True iruxi settlements are often overlooked, as they are partially or mostly submerged in water. These glass and stone complexes bear the mark of every generation of lizardfolk that lived within them, and lizardfolk bones often adorn the walls, as many lizardfolk believe these remains can be animated by ancestral spirits when the residents are in danger." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("321aca77-fecb-4d8a-86bb-ddfb7da23852"), Type = TextBlockType.Text, Text = "Most iruxi are unconcerned with heavy questions of morality and are therefore usually neutral in alignment. Adventuring iruxi who leave their people to travel might have any number of reasons for doing so and can be of any alignment. Iruxi religion plays a large role in their culture, but it is heavily practical, blending animism and ancestor worship with druidic rites. Of the gods, only Gozreh is commonly revered, but lizardfolk may call upon other powers devoted to ancient wyrms, astrology, nature, rivers, and might of arms, from kindly Desna to cruel Hanspur and certain demon lords." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("f120d0d8-d784-48b6-80cf-40e581db7aeb"), Type = TextBlockType.Text, Text = "Some background options are particularly suitable for lizardfolk. Wilderness or martial backgrounds like theanimal whisperer,hunter,scout, orwarriorare ideal. Living at the margins of human civilization means an iruxi might have grown up as a hardystreet urchin, traveled as anomadorsailor, or found work as alaborerorgladiator. Lizardfolk's ties to the wilderness make them excellentrangersordruids. Their outstanding strength serves them well if they select thebarbarian,fighter, ormonkclasses, though they can also strike from stealth as arogue. Iruxi also have a strong oral tradition kept alive by lizardfolkbardsandsorcerers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("9e42ef94-8077-4072-9bc6-c6104c574d66"), Type = TextBlockType.Text, Text = "Lizardfolk names come from their ancient language and tend to be traditional. Names are typically chosen by the clan’s astrologer in accordance to omens and which star signs are ascendant when an iruxi egg hatches, though occasionally an iruxi’s parents may name a hatchling for an ancestor or a beloved historical hero." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Droon" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Long before the birth of Azlant, iruxi realms girdled Golarion. Today, only one nation recalls the splendor of that bygone era: Droon, a vast empire on the coast of southern Garund. Here, lizardfolk rule astride dinosaurs. Iruxi nobles settle feuds via ceratosaur duels. Sauropod caravan trains haul goods across seemingly impossible distances. Wizards breed spell-laced rhamphorhynchus familiars, and no thief worth their salt pulls a job without a whistling velociraptor lookout." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Iruxi" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While most lizardfolk permit humans and others to refer to them by that moniker, they call themselves iruxi. This ancient word arose from the Draconic tongue, though its exact etymology is unclear. In Droon, iruxi astronomers point to the jagged constellation of the Maw and the starry figure who stands against it. Today, while this constellation is called the Lone Mother and features in fables about environmental conservation, she once had another name in dragon lore: Erux, meaning “defiance.”" };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Iruxi Ancestors" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ancestor worship is central to iruxi spiritual life. Lizardfolk keep their elders' physical remains close, incorporating them into the architecture of their settlements. The bones of deceased iruxi shore up protective walls and fill great vaulting ossuaries. Preserved and suffused with ritual veneration, these bones become magical reservoirs of power. It's rumored that in times of great need, iruxi ancestors will reanimate their bones and fight for their descendants." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Aquatic Adaptation" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your reptilian biology allows you to hold your breath for a long time. You gain the Breath Control general feat as a bonus feat." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Claws" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your sharp claws offer an alternative to the fists other humanoids bring to a fight. You have a claw unarmed attack that deals 1d4 slashing damage and has the agile and finesse traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Lizardfolk.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("2194b250-dc31-49b1-954b-22c49c87ea48"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("3016dd14-cf85-40d5-b6b7-3908398381b3"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("4dcb5611-801b-4539-affe-679468643cd8"), Stats.Instances.Strength.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("2cb4ace1-84d8-4283-b3d9-429aa223b0bf"), Stats.Instances.Wisdom.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("d2cefd78-2c3b-44f3-b34a-483e81e55fc1"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("db67c47d-4563-4df4-b496-fa192f22c501"), Stats.Instances.Intelligence.ID);
            builder.GainSpecificLanguage(Guid.Parse("15eaf907-23f0-4a4a-8c9b-b9be660ae424"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("d230cc63-b466-4970-8afc-9a69650b6322"), Languages.Instances.Iruxi.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.AquaticAdaptation.ID);
            builder.GainSpecificUnarmedAttack(Guid.Parse(""), UnarmedWeapons.Instances.Claws.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Slashing.ID, damage: "1d4");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("216d188d-6ec8-447d-9527-33f37f4e64c7"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 57
            };
        }
    }
}
