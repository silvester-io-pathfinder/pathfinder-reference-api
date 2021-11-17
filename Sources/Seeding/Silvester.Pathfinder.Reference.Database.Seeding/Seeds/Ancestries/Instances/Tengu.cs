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
    public class Tengu : Template
    {
        public static readonly Guid ID = Guid.Parse("f883a377-0038-4a18-9d8c-456584bd2740");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Tengu", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Arkkak, Chuko, Dolgra, Dorodara, Kakkariel, Kora, Marrak, Mossarah, Pularrka, Rarorel, Ruk, Tak-Tak, Tsukotarra"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("89c7d415-766f-4119-8e68-7f838170ca6e"), Type = TextBlockType.Text, Text = "Tengus are a gregarious and resourceful people that have spread far and wide from their ancestral home in Tian Xia, collecting and combining whatever innovations and traditions they happen across with those from their own long history." };
            yield return new TextBlock { Id = Guid.Parse("144eb94e-9844-43f0-a27b-dc8a7d7d7e53"), Type = TextBlockType.Text, Text = "Tengus are survivalists and conversationalists, equally at home living off the wilderness and finding a niche in dense cities. They accumulate knowledge, tools, and companions, adding them to their collection as they travel." };
            yield return new TextBlock { Id = Guid.Parse("729e7fcc-a38e-4352-baa4-068721a54229"), Type = TextBlockType.Text, Text = "The tengu diaspora has spread across Golarion in search of a better life, bringing their skill with blade crafting to lands far from their home. In maritime regions, tengus notably work as fishers, blacksmiths, and “jinx eaters”— members of ships’ crews who are believed, accurately or otherwise, to absorb misfortune. Having lived in a variety of conditions and locations, tengus tend to be nonjudgmental, especially with regard to social station, though their willingness to associate with lawbreakers has often led some to look at them with suspicion." };
            yield return new TextBlock { Id = Guid.Parse("ad04acc1-e537-4439-bd1c-bc798cf7c287"), Type = TextBlockType.Text, Text = "If you want to play a character hailing from a rich history of artisanship and tradition, but who happily picks up new practices, companions, words, and items as needed, you should play a tengu." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("2a5819c2-68a3-4611-9fee-54557eb642a2"), Type = TextBlockType.Enumeration, Text = "Be gregarious and eager to find a flock of your own. " };
            yield return new TextBlock { Id = Guid.Parse("b2a6a9a5-80fd-4fe8-b6fd-35f1400aa2ad"), Type = TextBlockType.Enumeration, Text = "Voraciously absorb the practices of those around you, sometimes even forgetting where they came from. " };
            yield return new TextBlock { Id = Guid.Parse("4c7f6ad5-9187-4e49-89f7-fe74a8063fdc"), Type = TextBlockType.Enumeration, Text = "Be willing to take on any task or job, no matter what others think." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("8cf6d7d0-81d5-4d64-9f7d-4c4acedfff1b"), Type = TextBlockType.Enumeration, Text = "Look to you as a source of eclectic skills and knowledge, especially relating to languages. " };
            yield return new TextBlock { Id = Guid.Parse("7e5a8539-9db3-4059-a909-195196870051"), Type = TextBlockType.Enumeration, Text = "Get confused by your simultaneous respect for and disregard of tradition. " };
            yield return new TextBlock { Id = Guid.Parse("38a71719-7f18-4f9f-a4ed-9a2189b50418"), Type = TextBlockType.Enumeration, Text = "Have trouble reading your expressions or regard you with suspicion and superstition." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("06237811-3cee-4819-8886-d1532d4577fe"), Type = TextBlockType.Text, Text = "Tengus have many avian characteristics. Their faces are tipped with sharp beaks and their scaled forearms and lower legs end in talons. As closed footwear tends to fit poorly unless custom made, many tengus wear open sandals or simply go barefoot. Tengus are rarely more than 5 feet tall, and they are even lighter than their smaller frames would suggest, as they have hollow bones. A small number of tengus have vestigial wings incapable of true flight." };
            yield return new TextBlock { Id = Guid.Parse("66cea3dc-3326-4128-bcef-62ede6338ed5"), Type = TextBlockType.Text, Text = "Tengus hatch from eggs and are featherless for their first year of life, during which they rarely leave home. They soon grow a downy gray coat, which is replaced by a dark covering of adult feathers by the time they come of age at around 15 years. Tengus use their shed feathers in a variety of tools, from simple writing quills to magical fans to focus their ancestral magic. Many tengus modify their appearance by dyeing patterns into their feathers or talons, which amplifies their body language and has the added benefit of aiding other humanoids in understanding their expressions." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("30d6dc9a-d250-44c7-8878-6537656846bc"), Type = TextBlockType.Text, Text = "Tengus are extremely social, banding together in extended communities with many families living in adjacent houses and sharing the work of the household. In cities, a community may also contain members of other ancestries. Tengu children raised in the same unit consider each other siblings, usually forgetting which of them share a biological connection." };
            yield return new TextBlock { Id = Guid.Parse("98cd2872-2831-49d3-ba31-b4a9fb6dfd8a"), Type = TextBlockType.Text, Text = "The greatest divide in tengu society is between tengus remaining in their ancestral home and those who have dispersed across the world. Tengus refer to these two groups as those “in the roost” and those “migrating,” respectively. Roosted tengus tend to be more traditionalist and conservative and are especially concerned with preserving their culture in the face of years of erosion from oppression. Migrating tengus, on the other hand, voraciously absorb the culture of the various nations and settlements that they now call home." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ba7eb130-0822-4fd1-a596-07db202997fc"), Type = TextBlockType.Text, Text = "Tengus often follow the faith of the region in which they were raised, though the tengu ancestral deity is the storm godHei Feng. This god’s notorious drunken carousing and emotional swings causes many tengus to instead focus their attention on gods of freedom and travel, such asDesnaorCayden Cailean, or deities of nature, such asGozreh.Besmarais also a common subject of tengu worship, especially among tengus who live on the sea." };
            yield return new TextBlock { Id = Guid.Parse("d933edd0-3e6e-4fab-8159-2277d6c9a6b1"), Type = TextBlockType.Text, Text = "Before their diaspora, tengus practiced a syncretic faith that blended a polytheistic worship of the deities responsible for creating the natural world. As tengu folklore posits that tengus long ago descended from the night sky on shooting stars to rest upon Golarion’s highest peaks, animist rites were practiced on mountains and other great natural features. Even today, tengus rarely differentiate between divine and primal worship." };
            yield return new TextBlock { Id = Guid.Parse("5ba74fd3-f3ff-43f0-8f5b-fa1abfd1b43e"), Type = TextBlockType.Text, Text = "Tengus are far more concerned with the balance between traditionalism and adaptability than they are with good and evil, with lawful tengus more common among the roosted and chaotic tengus more common among the migratory." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("5caca133-ddf5-4569-95f4-9b638c8be6e1"), Type = TextBlockType.Text, Text = "A tengu that leaves the ancestral homeland feels an intense pull toward adventure, to cross vast distances, collect beautiful treasures, and brave the challenges of combat or the rolling sea." };
            yield return new TextBlock { Id = Guid.Parse("1877975d-84e0-47f9-91e3-16a9d999a411"), Type = TextBlockType.Text, Text = "Tengu backgrounds might reflect their place in the homeland or the tengu diaspora. These could includeacrobat,barkeep,charlatan,emissary,entertainer,fortune teller,gambler,merchant,nomad, orsailorfrom theCore Rulebook, plusbandit,courier,insurgent,refugee, andscavengerfrom this book." };
            yield return new TextBlock { Id = Guid.Parse("6531e6c5-8647-4518-a345-3718bf81b9eb"), Type = TextBlockType.Text, Text = "Tengus often becomerogue,bard,oracles,rangers, orswashbucklers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("094e28f6-f096-4180-b763-97504741dcbd"), Type = TextBlockType.Text, Text = "Though roosted tengus tend toward more traditional names with the hard consonants often seen in the Tengu language, migrating tengus’ tendency to readily absorb and repurpose the culture of those around them has led to names that combine elements of whatever languages suited the namer’s fancy." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("2453e76e-334a-462d-864f-b14ec0f9109a"), Type = TextBlockType.Heading, Text = "Tengu Bottles" };
            yield return new TextBlock { Id = Guid.Parse("809874c6-ae22-49e7-865f-08f09a7e7c6e"), Type = TextBlockType.Text, Text = "Tengu tend to have a healthy respect for gods that rule over storms and air—or at least, a healthy fear. One ancestral custom that has caught on among other sailors is the tengu bottle: a decorated gourd or other container filled with an offering for the gods, kept on ships and thrown overboard in the event of dire weather. Tengu bottles most often contain fine alcohol to appease the fury of Hei Feng or Besmara; crew puncture the bottles to release these offerings before throwing them into the waters." };

            yield return new TextBlock { Id = Guid.Parse("6c2c2b99-0e44-4004-9fee-3b6a1114ef92"), Type = TextBlockType.Heading, Text = "Tengu Settlements" };
            yield return new TextBlock { Id = Guid.Parse("6a4f5855-7ca1-42f3-8127-98f8053760c8"), Type = TextBlockType.Text, Text = "The majority of tengu enclaves are found either in the Tian Xia nation of Kwanlai or on the continent of Garund; Kwanlai is part of the ancestral tengu homelands, while tengu communities on the Garund coast resulted from a troubling combination of lucrative job opportunities and kidnapping. Tengu also have a sizable presence in the nation of Minkai and the Forest of Spirits, and scattered communities dot much of northeast Tian Xia." };

            yield return new TextBlock { Id = Guid.Parse("a63b5db5-5b97-4d14-a715-768e16273cd9"), Type = TextBlockType.Heading, Text = "The Storm God's People" };
            yield return new TextBlock { Id = Guid.Parse("fd3cda0c-9a37-4304-ae36-c2e19d157d33"), Type = TextBlockType.Text, Text = "While Hei Feng's tempestuous blessings mean that some tengu prefer to pay the god lip service rather than follow his guidance, most tengu share the Duke of Thunder's love of loud and colorful celebrations—holidays dedicated to Hei Feng are nearly universal, in even the most far-flung communities. Likewise, many tengu enclaves put little faith in the stability of society. In situations where the future seems uncertain, Hei Feng's presence provides an outlet for feelings of helplessness." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("8c2f6a3c-e38c-4ca2-a09e-7e6d32760c95"), Type = TextBlockType.Heading, Text = "Sharp Beak" };
            yield return new TextBlock { Id = Guid.Parse("373a2537-408f-4fbb-963b-5e1192990b58"), Type = TextBlockType.Text, Text = "With your sharp beak, you are never without a weapon. You have a beak unarmed attack that deals 1d6 piercing damage. Your beak is in the brawling weapon group and has the finesse and unarmed traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Tengu.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("313d85df-8e4f-4c7b-b70e-040a8e34eb25"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("b34523f0-84b6-43db-807a-b6323d318545"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("161bcf07-8deb-4936-836a-d8f76142cdb4"), Stats.Instances.Dexterity.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("b48e130b-1996-430d-9862-e1ba124e64e5"));
            builder.GainSpecificLanguage(Guid.Parse("1001d1ef-d764-4a0f-b63f-ba31578df07c"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("a37a8cde-a670-451b-b1e3-a9cf5bf8ac77"), Languages.Instances.Tengu.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse("1cf53b4a-f59a-402e-89e1-5fc8d27d7c46"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.GainSpecificUnarmedAttack(Guid.Parse("62392ba8-f972-4344-a2b2-c017864ce73c"), UnarmedWeapons.Instances.Beak.ID, WeaponGroups.Instances.Brawling.ID, DamageTypes.Instances.Piercing.ID, damage: "1d6");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ee0124c-1cbe-4e44-959f-13858fd1f2bd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 25
            };
        }
    }
}
