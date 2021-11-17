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
    public class Strix : Template
    {
        public static readonly Guid ID = Guid.Parse("256b0ae7-8e26-4dd6-bf03-27fec03193e6");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Strix", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Chiit-iir, Cicreeti, Ikatarii, Irkoata, Kaata, Kiilo, Kirii, Rahka, Roatatwiil, Turiilo, Turuk, Twilii"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("f5f1dc93-f104-45b0-ae8f-205df8fd0c42"), Type = TextBlockType.Text, Text = "Known as itarii in their own language, strix are reclusive avian humanoids devoted to their homelands and their tribes. They defend their precious communities with broad wingspans and razor talons." };
            yield return new TextBlock { Id = Guid.Parse("d1224cac-8a01-4d71-b830-ef79563a0b96"), Type = TextBlockType.Text, Text = "Strix value ferocity, vengeance, and devotion above all else. Their dark, formidable wingspans and long history of taking revenge for their fallen family members have painted them as winged devils in the eyes of neighboring human populations. In contradiction to their misunderstood nature, strix boast a spiritual, artistic, and compassionate culture that is rarely seen outside of their roosts." };
            yield return new TextBlock { Id = Guid.Parse("027734cc-3468-4bac-a98f-2597cf0001f5"), Type = TextBlockType.Text, Text = "As strix populations begin to resurge and spread beyond the mountainous region known as the Devil's Perch, their tribes now speckle the landscape of Cheliax and surrounding nations. Soaring over mountains, forests, and beaches, strix are always brought home by the deep connections they share with their kinfolk. If you want a character who is loyal yet enigmatic, fierce yet artistic, and who yearns to soar above the world, you should play a strix." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("6ea28cc7-cf00-444a-b588-b953bc06d23a"), Type = TextBlockType.Enumeration, Text = "Dedicate and endear yourself to your family, friends, or community." };
            yield return new TextBlock { Id = Guid.Parse("d2ad6213-0cb3-41f8-a27a-992f43a1d20c"), Type = TextBlockType.Enumeration, Text = "Harbor an inherited distrust of humans." };
            yield return new TextBlock { Id = Guid.Parse("08298070-b110-4605-8231-607ed3558676"), Type = TextBlockType.Enumeration, Text = "Keep strangers at arm's length and perhaps exhibit naivete about the world beyond your homeland." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("41673413-fc77-4b3c-86ca-760444ae783f"), Type = TextBlockType.Enumeration, Text = "Appreciate your dedicated friendship, even if they don't grasp the cultural history behind it." };
            yield return new TextBlock { Id = Guid.Parse("34e553c4-1e4c-44fc-bba7-4bc070ede9fe"), Type = TextBlockType.Enumeration, Text = "Treat you on occasion like a carrier pigeon, asking you to deliver letters or other similar favors." };
            yield return new TextBlock { Id = Guid.Parse("c2f71fc2-824b-43d9-8e46-e1eb2d68ec29"), Type = TextBlockType.Enumeration, Text = "Find your appearance frightening due to complete inexperience with strix." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("41e6f7d7-4f5f-4ee6-b515-c05f51b14606"), Type = TextBlockType.Text, Text = "Strix are avian-influenced humanoids with intimidating talons and feathered wings sprouting from their backs. With an average height of 6 feet, strix are taller than most humans but are very light for their size. Strix are considered mature at 14 years of age and have an average lifespan of 40 years. They have pointed ears and large eyes that are typically black from sclera to pupil, but occasionally appear as a piercing golden color. Strix lack the ability to move their eyes independently of their head, resulting in distinctive jerky movements as their gaze snaps between targets. Their bodies are usually taut with defined musculature—a result of the strength necessary to flex their wings." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("bb14033f-8a4d-4f44-9988-773d77c19120"), Type = TextBlockType.Text, Text = "Strix are rare and reclusive people who cling to their ancestral territories. They live in modest-sized tribes, but some reside in smaller bands of tight-knit individuals. The largest settlements of strix reside on Devil's Perch, but a small number of their ilk have traveled far across Golarion. Strix feel an intense empathy and attachment to their family and other community members. They prioritize the needs of their community over their individual desires, and their bands and tribes benefit from an easy yet expertly organized division of labor. Strix tribes are led by a rokoa, a female tribal leader." };
            yield return new TextBlock { Id = Guid.Parse("8f777906-f783-4f8c-bec5-63464d9b8403"), Type = TextBlockType.Text, Text = "A long history of conflict with the nearby nation of Cheliax has bred into most strix a deep fear and suspicion of humans—who they call kotaara. Strix have struggled to keep hold of their territories and maintain their numbers in the face of constant conflict with these enemies who, in addition to trying to destroy what they believe to be winged devils, vastly outnumber them. Due to their strongly bonded groups, the loss of a single tribe member is devastating." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("5c0b7f51-b74a-468b-9504-9b35251ae450"), Type = TextBlockType.Text, Text = "Due to their deep respect for the rules of a functioning society, strix are rarely chaotic, but some may be flexible on adopting the rules of outside societies. Strix are typically nonreligious and instead use stories from an epic known as the Korrsat Akra, or “The Scattered Nest,” to tell them of their origins and give them direction on their current place in the world. They have a deep investment in the lives of their fellows and experience intense grief at their passing." };
            yield return new TextBlock { Id = Guid.Parse("0520d898-645d-470a-98f0-64a2352ddbf0"), Type = TextBlockType.Text, Text = "Pharasmais a common influence among religious strix due to the popularity of religious and spiritual practices honoring the lives and deaths in their beloved community.Gozrehis also an everyday influence for many strix, who beseech the Wind and the Waves to give them satisfying tailwinds for flight and protect their kin when the sky turns dark with fury.Erastiland evenToragrepresent two versions of social order and may be unifying deities across entire tribes." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("3325700c-ea97-4d95-9983-ae55bd021133"), Type = TextBlockType.Text, Text = "Adventuring strix most commonly take theemissary,hermit,nomad,scout, orstreet urchinbackgrounds. Strix are agile combatants and prudent adventurers who excel asdruids,fighters,monks,rangers, orrogues." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("27d7366e-7465-4fd1-84e1-ca04b9be0251"), Type = TextBlockType.Text, Text = "Strix names consist of sounds that are reminiscent of chirping, screeches, or trilling by various birds, and their naming conventions are influenced primarily by tradition and spirituality. Strix in small communities might share a common syllable among all their names to express their unity. Due to their deep affection for their family members, naming children after other loved ones is very common, occasionally with an additional syllable or slight change to the pronunciation." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("0d9aa68d-12e4-4d43-a527-28987fdf087d"), Type = TextBlockType.Heading, Text = "Rokoas" };
            yield return new TextBlock { Id = Guid.Parse("ddea102d-33bf-4e1d-8d3c-40523d2333e7"), Type = TextBlockType.Text, Text = "Strix tribes are led by a spiritual, social, and military leader called a rokoa. Rokoas are elder female leaders who consult a council of other warriors and spiritualists to make decisions for the entirety of the community. Young female strix are selected early as potential successors to the tribe's current rokoa. Often the rokoa herself chooses her favorite protégé to pass along her storytelling recitations, battle stratagems, and spiritual understanding." };

            yield return new TextBlock { Id = Guid.Parse("5867d1f4-69d7-4dc9-a5cd-2443cc694aab"), Type = TextBlockType.Heading, Text = "Strix Settlements" };
            yield return new TextBlock { Id = Guid.Parse("86b61d0f-7c92-4ede-8a73-6ca36c3b748e"), Type = TextBlockType.Text, Text = "Strix settlements, called roosts, are lofty dwellings at the highest point of the local landscape. Mountains are a particular favorite, especially if they provide tall spires that make foot traffic impossible. Strix living in forests build their communities around the largest trees available, and seaside dwellers prefer to nestle their dwellings along perilous cliffs." };
            yield return new TextBlock { Id = Guid.Parse("544d375d-c953-40d4-b7f6-5277f00a52c6"), Type = TextBlockType.Text, Text = "By far, the largest strix community resides at Ciricskree, which translates from the Strix language to “the Shrieking Spire.” This tribe of over 500 individuals is the cultural epicenter for the Devil's Perch and the entire Avistani strix population. Additional settlements include the Ikaraka in the Barrowood forest at the base of the Menador Mountains, and the small Blackcove tribe along the shore, who have established a tolerant trading relationship with a nearby fishing village." };

            yield return new TextBlock { Id = Guid.Parse("f84ede71-da8d-404c-a050-d847e5e44b75"), Type = TextBlockType.Heading, Text = "Stric Storytelling" };
            yield return new TextBlock { Id = Guid.Parse("d71d2253-df6a-40e7-b923-dc4c601be6d5"), Type = TextBlockType.Text, Text = "Strix utilize storytelling to convey a verbal history of their people and perform poetic tales that sound like songs when sung in their native tongue. Nestling strix grow up hearing their histories sung to them as lullabies and serenades of daily life. Powerful moments are punctuated with screeches, and mournful recounts float in the air like soft cooing. One common story tells of a vengeful strix whose wings turned gloriously red, but who hid his face with a mask, ashamed of the actions that led to his glory. Another crooned to nestlings warns of a mysterious parasite that hides in filthy feathers." };
        }
        
        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("89982eec-47c2-43e0-8b56-400b047b7bca"), Type = TextBlockType.Heading, Text = "Wings" };
            yield return new TextBlock { Id = Guid.Parse("30066105-396d-4ffe-ae28-cd2174f65fa8"), Type = TextBlockType.Text, Text = "All strix possess powerful wings. While not all strix focus on honing their flying skills, a strong flap of their wings allows strix to travel longer distances when jumping. When Leaping horizontally, you move an additional 5 feet. You don't automatically fail your checks to High Jump or Long Jump if you don't Stride at least 10 feet first. In addition, when you make a Long Jump, you can jump a distance up to 10 feet further than your Athletics check result, though still with the normal maximum of your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Strix.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("4f5b8c57-677e-4748-92f9-b0466d82b971"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("17bb5b58-bda3-45c4-a87f-2e70be19fffd"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("180bee46-43f7-4d66-9db0-c5828ef3e2e1"), Stats.Instances.Dexterity.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("1292c225-c31b-40e2-b18a-836ecdc4ac63"));
            builder.GainSpecificLanguage(Guid.Parse("0e83db8e-8911-4d3f-a5bf-1050fb0a427c"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("6ac12d99-c3ab-4b5e-9640-520f77ac803d"), Languages.Instances.Strix.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("9c767245-b846-4c19-907d-3a79c16f21c0"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add Wings effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c23a98a1-e39f-4bc6-9a6d-ed6fe1ab7430"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 133
            };
        }
    }
}
