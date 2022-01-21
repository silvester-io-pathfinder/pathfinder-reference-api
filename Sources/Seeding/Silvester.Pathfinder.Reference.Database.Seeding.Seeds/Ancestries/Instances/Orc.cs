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
    public class Orc : Template
    {
        public static readonly Guid ID = Guid.Parse("132b7405-e295-4188-8bc4-f666bff89b55");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Orc", 
                BaseHealth = 10, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Arkus, Ausk, Durra, Grask, Grillgiss, Krugga, Mahja, Murdut, Ollak, Onyat, Thurk, Uirch, Unach"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("427c00e8-81b4-4252-902e-949d031dfd57"), Type = TextBlockType.Text, Text = "Orcs are forged in the fires of violence and conflict, often from the moment they are born. As they live lives that are frequently cut brutally short, orcs revel in testing their strength against worthy foes, whether by challenging a higher-ranking member of their community for dominance or raiding a neighboring settlement. Many orcs seek glory as soon as they can walk and carry a blade or club, taming wild beasts or hunting deadly monsters." };
            yield return new TextBlock { Id = Guid.Parse("0c19b62c-7add-4607-ad6e-91b3ca137b1b"), Type = TextBlockType.Text, Text = "Orcs often struggle to gain acceptance among other communities, who frequently see them as brutes. Those who earn the loyalty of an orc friend, however, soon learn that an orc's fidelity and honesty are unparalleled. Orc barbarians, fighters, and rangers are prized as gladiators and mercenaries. While some human settlements might be hesitant to accept an entire orc community into their midst, a small handful of orc mercenaries can do the job of an entire squad of human conscripts, so long as the orcs are well fed and well paid. Though the belief that orcs are only suited for battle is pervasive among other humanoids, the harsh orc mentality comes from a long history of conflict rather than a lack of ability in other areas." };
            yield return new TextBlock { Id = Guid.Parse("9438f42d-a718-4d18-a39c-f83f7aa6eb1f"), Type = TextBlockType.Text, Text = "Orc culture teaches that they are shaped by the challenges they survive, and the most worthy survive the most hardships. Orcs who attain both a long life and great triumphs command immense respect." };
            yield return new TextBlock { Id = Guid.Parse("e7366932-3145-4d75-ad27-823b6798119f"), Type = TextBlockType.Text, Text = "If you want a character who is hardy, fearsome, and excels at feats of physical prowess, you should play an orc." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("bd545d63-4839-4512-97a6-c521c45f91e7"), Type = TextBlockType.Enumeration, Text = "Eagerly meet any chance to prove your strength in a physical contest. " };
            yield return new TextBlock { Id = Guid.Parse("8508e14d-31ea-403c-a2ad-49a0db16b5e5"), Type = TextBlockType.Enumeration, Text = "Believe that lies and treachery are for those who lack the strength to seize what they want. " };
            yield return new TextBlock { Id = Guid.Parse("17b5f388-72aa-4573-969b-e349268f8930"), Type = TextBlockType.Enumeration, Text = "View dying in glorious combat as preferable to a mundane death from old age or illness." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("85d1c894-f356-424d-a174-03b52675bb24"), Type = TextBlockType.Enumeration, Text = "See you as violent or lacking in discipline. " };
            yield return new TextBlock { Id = Guid.Parse("e6b8ce4f-7f0d-4d4c-83fa-a4e09524bab8"), Type = TextBlockType.Enumeration, Text = "Underestimate your intellect, cunning, and knowledge. " };
            yield return new TextBlock { Id = Guid.Parse("9a233dc1-4a40-491a-b06d-e2f61ef00e18"), Type = TextBlockType.Enumeration, Text = "Admire your forthrightness and blunt honesty." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("5360fb0c-0d98-4c32-bd53-71d3e3fb02c2"), Type = TextBlockType.Text, Text = "Orcs are tall and powerfully built, with long arms and stocky legs. Many orcs top 7 feet in height, though they tend to adopt broad, almost bow-legged stances and slouch forward at the shoulders. The combination makes for a seeming contradiction, sharing an eye level with most humanoids while simultaneously towering over them. Orcs have rough skin, thick bones, and rock-hard muscles, making them suited to war and other physically demanding tasks. Despite the roughness of their skin, orcs scar easily, and most orcs take great pride in the scars they have accumulated. Orc skin color is typically green and occasionally gray, though some orcs have other skin colors that reflect adaptations to their environments." };
            yield return new TextBlock { Id = Guid.Parse("e38a2fc0-fd27-4975-a1b3-fdac579385d7"), Type = TextBlockType.Text, Text = "Orcs consider powerful builds and heavily scarred skin attractive, regardless of gender. A powerful orc makes the hold stronger, and scars are signs of victories won or hardships survived. Similarly, many orcs consider large, jutting tusks to be more attractive than smaller tusks, since the former make more effective weapons. Many orcs also find tattoos to be attractive, particularly large or painful ones that cover a significant amount of skin." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("15f3fef0-9652-4b53-ae55-c438368b55b8"), Type = TextBlockType.Text, Text = "Most orc communities define themselves through two things: pain and glory. Each earns respect in near equal measure, so long as the pain is borne with stoicism. An orc with many scars who walks uncomplaining with a broken leg draws as much admiration as one who wins a great victory on the battlefield." };
            yield return new TextBlock { Id = Guid.Parse("19f3d89f-ab6f-4ca5-bc82-5bedc117586a"), Type = TextBlockType.Text, Text = "Power in an orc hold comes from strength or family lineage. The structure tends to be feudal, with weaker orcs working at the behest of the strong. The Hold of Belkzen is the largest such society, and power changes hands there quickly. One mighty orc dying in battle can shake up an entire power structure, leading to squabbling and duels to decide control. Many orcs who tire of being subservient split off to form their own warbands, traveling to new territory." };
            yield return new TextBlock { Id = Guid.Parse("9f0bc7db-dbed-4a04-8ad4-4991b856c713"), Type = TextBlockType.Text, Text = "Young orcs are typically raised by the entire community. Indeed, it would be almost impossible for orcs to raise their young any other way, since twins, triplets, and even quadruplets are quite common in orc families, as are deaths among orcs in their child-rearing years. Many orc holds conduct ceremonies when a young orc comes of age, typically around their tenth or eleventh birthday, during which the new adults are told what their role in the hold will be. For communities that practice ritual scarification or tattooing, this is often when the young orcs receive their first hold-scar or tattoo as well." };
            yield return new TextBlock { Id = Guid.Parse("bd70b937-a3cc-4775-a3fa-c01c60804500"), Type = TextBlockType.Text, Text = "Orcs fear very little, but most distrust magic. Magic is seen as a tool that bypasses the physical and allows the weak to contend with the strong, a belief that runs at odds with orc values. While they respect the physical might of Gorumite warpriests, and even druids who take on the forms of great beasts, they find arcane and occult magic questionable at best and unethical on the whole. All but the most depraved orc communities see necromancy as a foul art that steals glory from the dead, and their growing struggles against the undead have given them newfound common ground with their humanoid neighbors." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ebcaf079-e8c9-4c03-b1a6-663b4862fe11"), Type = TextBlockType.Text, Text = "A common orc saying is, “You are the scars that shape you.” Violent, chaotic lives in violent, chaotic lands mean that most orcs tend heavily toward chaotic alignments.Gorum,Lamashtu, andRovagugare all commonly worshiped among orc communities, though less violent holds worship nature deities likeGozrehor gods likeSarenrae, whose tenets of fire, redemption, and glory all hold some appeal to orc sensibilities." };
            yield return new TextBlock { Id = Guid.Parse("034a7951-53a6-4de0-94f9-81e802b098c9"), Type = TextBlockType.Text, Text = "While there are orc deities, their worship is surprisingly uncommon among orcs. Orcs believe that if a creature has a face and a name, it can be killed, and so their own deities are targets, rather than objects of reverence. Some orc holds teach that the greatest members of the hold can earn a chance to challenge the orc deities for a place amid the pantheon. Most orcs don't waste their dying moments praising the divine or praying for a place in the afterlife, but spitting a blood-flecked warning at their deities, promising a new challenger through broken teeth." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("03c9e345-b1f0-4221-8e6d-602041710a69"), Type = TextBlockType.Text, Text = "An orc's drive to overcome challenges and prove themself spurs many orcs to become adventurers, though orcs are more likely to set out on their own or with other orcs than alongside adventurers of other ancestries." };
            yield return new TextBlock { Id = Guid.Parse("96ea9233-bde3-4c98-94c9-a8d4a77a3fab"), Type = TextBlockType.Text, Text = "Common orc backgrounds includegladiator,hunter,martial disciple,nomad, andwarriorfrom theCore Rulebook, plusbandit,outrider, andrefugeefrom this book. Orcs thrive in martial classes likebarbarianandfighter." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("3a36ed98-5ff2-49be-a732-28cded176505"), Type = TextBlockType.Text, Text = "Orcs have a harsh, guttural language, and their naming conventions are no exception. Many orc names are simply the Orcish word for a particularly desirable trait, such as great strength, height, or ferocity. Orcs commonly use either their hold name or a name referencing a particularly memorable accomplishment as their surname." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("7ce16f67-e55f-4d15-b206-36529c35b3c4"), Type = TextBlockType.Heading, Text = "Orc History" };
            yield return new TextBlock { Id = Guid.Parse("d6b98fc1-188c-4080-a13c-25eda49c6a2d"), Type = TextBlockType.Text, Text = "Originating deep underground, orcs were driven upward when the dwarves began their Quest for Sky. Endless dwarf forces advanced from below, crossing into orc territory and inciting a war that lasted for countless orc lifetimes, with each new generation losing more ground. When finally driven to the surface, orcs discovered a world shrouded by ash. The nearby human civilizations were unprepared for their anger and desperation as they battled their way to empire with dauntless ferocity." };

            yield return new TextBlock { Id = Guid.Parse("a0026bd3-d8ed-483e-9598-8c25d0d9ef53"), Type = TextBlockType.Heading, Text = "Orc Holds" };
            yield return new TextBlock { Id = Guid.Parse("e666ac71-e980-4006-b27e-5ff1b2d843da"), Type = TextBlockType.Text, Text = "Orc holds are large groups of orcs bound together by family, values, and loyalty." };
            yield return new TextBlock { Id = Guid.Parse("e6329201-ef83-455f-8683-ae5bf2aadf98"), Type = TextBlockType.Text, Text = "Burning Sun: Armed with their faith in Sarenrae, the Burning Sun hold is dedicated to directing orc culture toward a more righteous path." };
            yield return new TextBlock { Id = Guid.Parse("1ada0390-2693-495b-97b5-6e4fff2acdc7"), Type = TextBlockType.Text, Text = "Empty Hand: The Empty Hand hold collects taxes from trade in Urgir to acquire top-quality weapons and armor. The hold's renown reached new heights after they led a recent victory over the Whispering Tyrant's undead forces." };

            yield return new TextBlock { Id = Guid.Parse("f23e61a8-ae41-438a-82bd-6f3bf3fa8e82"), Type = TextBlockType.Heading, Text = "Orc Settlements" };
            yield return new TextBlock { Id = Guid.Parse("f85befd8-0c10-4875-81d4-5406f80eafdc"), Type = TextBlockType.Text, Text = "Orc settlements rapidly rise and fall, but a few have stood the test of time." };
            yield return new TextBlock { Id = Guid.Parse("00421e9d-7248-4759-8c87-71b56432491b"), Type = TextBlockType.Text, Text = "Garaguum: In the Darklands, orcs inhabit a ruin built by their ancestors: the final battleground of their people's last stand against the dwarf invaders." };
            yield return new TextBlock { Id = Guid.Parse("55a1dad2-33af-4bb0-8b81-d0be423003e1"), Type = TextBlockType.Text, Text = "Scarwall: When the curse lifted from this haunted castle within the Hold of Belkzen, the local orc holds rushed to make their claim. The castle's lingering magic warped the minds and bodies of the orcs, who now call themselves the Spirit Skull Hold." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Orc.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("3a888906-dc1e-447f-97c1-37fbd250e585"), ModifierType.Add, modifier: 10);
            builder.ModifySpecificSpeed(Guid.Parse("9a49b9ab-780c-4c2f-b7d0-0ae696e198bd"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("b30219f6-d547-44af-9b17-5cb93ee80ad3"), Stats.Instances.Strength.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("bc979bae-554b-404b-97f2-3b52f0fafda5"));
            builder.GainSpecificLanguage(Guid.Parse("86a7a2a1-d411-44d8-a9ff-1141c4cdf181"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("8e61b795-65f5-4888-8826-824f5f754ddf"), Languages.Instances.Orcish.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("63e872c4-b499-4146-83ed-6e7aad2d2626"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6649f397-e90f-4204-8303-5c268bc50c65"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 17
            };
        }
    }
}
