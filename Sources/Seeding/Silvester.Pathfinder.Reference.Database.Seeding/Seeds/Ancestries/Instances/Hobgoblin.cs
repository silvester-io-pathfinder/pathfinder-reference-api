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
    public class Hobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("6f6b8c41-efa7-4f35-ae94-ea590f8f6134");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Hobgoblin", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Aze, Druknar, Ghargam, Hathkren, Imakra, Kralaeng, Mazkol, Olzu, Rezal, Sivkrag, Volmak, Zornum"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("0e0585ef-0649-4db9-b636-5b461233c47d"), Type = TextBlockType.Text, Text = "Taller and stronger than their goblin kin, hobgoblins are equals in strength and size to humans, with broad shoulders and long, powerful arms." };
            yield return new TextBlock { Id = Guid.Parse("2f194a17-bf9c-45b5-98f3-bbc44f8d6da9"), Type = TextBlockType.Text, Text = "The reputation of hobgoblins in the Inner Sea region has been upended by Oprak, the hobgoblin nation established recently in the mountains between Nidal and Nirmathas. The Ironfang Legion that stormed through Molthune and Nirmathas only a few years ago made a calculated decision to cease fighting, claim Oprak as a new homeland, and seek peace with its neighbors. Now under strict orders to not start conflicts with other nations, the hobgoblins of Oprak have begun to cautiously investigate Avistan in the spirit of cooperation rather than conquest. Many people, especially those that suffered terrible cruelties under the Ironfang Legion, fear that this is simply a pause in aggression while Oprak gains enough strength to crush its rivals. Others hope these bold soldiers might prove to be allies against the endless hordes of the Whispering Tyrant." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("538655a6-e698-43fa-a616-a91fec9698e1"), Type = TextBlockType.Enumeration, Text = "Seek out the most effective and practical solutions to any problem." };
            yield return new TextBlock { Id = Guid.Parse("a6ec6d27-b62c-4f69-b929-bde7b9e0d228"), Type = TextBlockType.Enumeration, Text = "Encourage a clear chain of command among any group you travel with, following orders even if you disagree with them." };
            yield return new TextBlock { Id = Guid.Parse("f0d286c3-11ae-44fc-aadf-2befaa0085f5"), Type = TextBlockType.Enumeration, Text = "Look for opportune alliances with other creatures, even if you don't fully understand or trust them." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("cfdd5879-2b51-42dc-bb3b-355b9410b095"), Type = TextBlockType.Enumeration, Text = "Consider you dangerous, due to your reputation and intimidating appearance." };
            yield return new TextBlock { Id = Guid.Parse("3418535d-8d9a-4505-8763-98ebf2fc2fc8"), Type = TextBlockType.Enumeration, Text = "Assume you hate magic and other mystical arts." };
            yield return new TextBlock { Id = Guid.Parse("0ae60220-a7fb-4d1d-b440-8eb94e181a7c"), Type = TextBlockType.Enumeration, Text = "Recognize your incredible endurance, dedication, and discipline." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("0a9ac3f2-b92b-4fbb-8003-6a82824a057d"), Type = TextBlockType.Text, Text = "Hobgoblins stand nearly as tall as humans, though they tend to have shorter legs and longer arms and torsos. They have the bald, wide heads and beady eyes, and gray skin that becomes steely blue when tanned. Hobgoblins are remarkably hardy; they recover from illnesses quickly and are able to exert themselves for long periods of time with little difficulty." };
            yield return new TextBlock { Id = Guid.Parse("478afb5e-05ef-4b31-8d33-96b9c19777a4"), Type = TextBlockType.Text, Text = "Hobgoblins mature quickly, and most can walk, talk, and hold a weapon by the time they are 1 year old, reaching adolescence by the age of 8 to 12 and adulthood around 14. Hobgoblins typically live up to 70 years of age." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("5306b5e0-388f-4be1-bda2-e54217c6e8f7"), Type = TextBlockType.Text, Text = "Hobgoblins structure their society after military hierarchies. Even civilian groups such as farming collectives or trading houses organize into regiments, companies, and divisions. Most hobgoblins fixate on social status, and many constantly strive to advance their social position. Hobgoblin punishments are primarily social demotions, although execution or slavery are common for serious crimes, such as arson or desertion." };
            yield return new TextBlock { Id = Guid.Parse("d2824998-ff4a-42da-b983-918687acfe67"), Type = TextBlockType.Text, Text = "Hobgoblin veterans hold a high place in their society, usually becoming leaders or advisors. Magic is rarely practiced and often derided, as most hobgoblins don't trust it over the strength of their own sword arms. Their arts tend to have a military bent; many hobgoblins consider stirring marches and weaponsmithing the only artistic endeavors worth pursuing, though Oprak's enforced era of peace is beginning to change this." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("05c132e3-35ce-4255-b484-15e3ddb2f0f7"), Type = TextBlockType.Text, Text = "Though familiar with the chaos of war, most hobgoblins have orderly minds and prefer to live within established hierarchies. While many hobgoblins consider sentimentality weak, those with mild temperaments have recently found success in diplomacy and international outreach. As a result, hobgoblin adventurers are usually lawful neutral, with only those rejecting or raised outside of their militaristic society chaotic. Faith has little place in hobgoblin society, as many feel it is impractical, though religious hobgoblins can gain a begrudging modicum of acceptance due to their useful healing magic." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("bf52ce1f-3363-4fa7-af37-7835e6834cd9"), Type = TextBlockType.Text, Text = "Hobgoblin society's rigid militaristic hierarchy produces excellent adventurers, as hobgoblins reach adulthood trained for combat. Due to their upbringing, many hobgoblins have thewarriorbackground. Thelaborer,martial disciple,miner, andscoutbackgrounds are also common. Hobgoblins raised away from their people often have thecriminal,hermit, ornomadbackgrounds instead. Hobgoblins are most oftenfighters,rangers, orrogues, although hobgoblin rogues approach their class with a disciplined mindset. Hobgoblins hold an ancestral grudge againstelvesand a distrust of arcane magic, which they call “elf magic.” Hobgoblin practitioners of arcane magic are exceedingly rare and usually shunned by other hobgoblins. Particularly clever hobgoblins usually becomealchemists." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("95945532-9d97-4b09-b73b-57623131e398"), Type = TextBlockType.Text, Text = "Like goblins, hobgoblin names tend to be simple, though hobgoblin names usually sound more guttural and forceful. On rare occasions, hobgoblins will alter their names, keeping the core but adding aspects, usually in response to an extreme trauma or a life-altering event. Hobgoblins have no surnames, considering them both pointless and presumptuous; an individual's merits and demerits are to be earned by their actions, not by an association with a particular lineage." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("4ecde948-451c-40e5-b027-e5aace8ca61b"), Type = TextBlockType.Heading, Text = "Cantorian Spring" };
            yield return new TextBlock { Id = Guid.Parse("196c59ea-4e75-4d6f-9110-34a99144884b"), Type = TextBlockType.Text, Text = "In days long past, Cantorys, goddess of life, transformations, and forests, created a staff called the Cantorian Spring and placed it on Golarion for fledgling mortals to find. A powerful devil named Canzoriant learned of the staff and slew Cantorys, claiming it for himself. Using the Cantorian Spring's power, Canzoriant transformed early goblins into the more powerful and calculating hobgoblins, instilling in them a deep hatred for elves. After a failed attempt by elves to claim the staff, the Cantorian Spring disappeared and hasn't been seen since." };

            yield return new TextBlock { Id = Guid.Parse("a1bc48c8-1850-41aa-9e1b-8c9376bc9191"), Type = TextBlockType.Heading, Text = "International Relationships" };
            yield return new TextBlock { Id = Guid.Parse("5bc56683-ec15-4847-bd91-d7efeabfab06"), Type = TextBlockType.Text, Text = "Oprak holds a powerful magical tool that has contributed to its economic boom: the Onyx Key. Through this powerful artifact, the nation creates planar tunnels that facilitate easy, seamless travel across Golarion. Using the artifact, General Azaersi contacted her fellow hobgoblin nations of Kaoling and, later, Rakh Lo, establishing trade agreements between the three powers. These pacts have faced their share of difficulties, however. Oprak and Rakh Lo quickly grew into close allies, but Kaoling's harsh traditionalism, even among hobgoblins, has complicated diplomatic progress." };

            yield return new TextBlock { Id = Guid.Parse("5f9b37f6-a890-4aad-9d36-86750487fb29"), Type = TextBlockType.Heading, Text = "Looming Concerns" };
            yield return new TextBlock { Id = Guid.Parse("29e38915-c5c5-4a94-8ffc-6786354d3839"), Type = TextBlockType.Text, Text = "To many, the specter of Oprak looms large over the Eye of Dread region. While the Whispering Tyrant is a more fearsome figure, nearby nations worry that once he is defeated, Oprak will be the next monstrous powerhouse on their doorstep. Some nations, like Druma, realize the potential of Oprak as an economic ally. Others, like Molthune and Nirmathas, still feel the sting of the Ironfang Invasion and hold unchecked grudges. Nidal has reached out to extend their non-aggression agreement, and Nirmathas appears grudgingly set to follow suit. Molthune remains undecided, or at least unspoken about its leanings, though rumors suggest that hostility between Oprak and Molthune is rising behind the scenes." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Goblin.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("f0e7677e-9959-4ba0-9b47-2d9fc7988b0a"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("43584e6f-7bfb-45fb-ab25-6193cf391999"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("45556f0f-da58-499a-9a5c-0e7bbb09e1e4"), Stats.Instances.Constitution.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("08f7b091-1b32-4868-a509-994c3b724f14"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("78c3d29a-1589-49b3-8b2c-e3b7135e48bf"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("66541788-fac1-4a46-a542-a8ab1c917922"), Stats.Instances.Wisdom.ID);
            builder.GainSpecificLanguage(Guid.Parse("6fe9ddd2-cb15-4ee2-86c5-36bc1685372c"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("453ca07e-80a7-40a0-a2cf-2eaeaf3cce51"), Languages.Instances.Goblin.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("9a67b2f4-4bd7-4a6b-9edf-8e84733881db"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15c5aa55-066f-4d10-a246-bd0f90d7df0b"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 49
            };
        }
    }
}
