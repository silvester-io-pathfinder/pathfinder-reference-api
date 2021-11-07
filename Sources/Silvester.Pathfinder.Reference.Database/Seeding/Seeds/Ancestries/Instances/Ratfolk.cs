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
    public class Ratfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("27dd5bf5-6059-490b-96a0-22b6326372c7");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Ratfolk", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Barnan, Chikis, Chonan, Deto, Jass, Jix, Knagi, Kubi, Lolo, Ninnec, Nos, Rak, Renzi, Skigim, Tali, Zess"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("793c9ab4-b92d-4df4-9d95-5b95b1f17342"), Type = TextBlockType.Text, Text = "Ysoki—as ratfolk call themselves—are a clever, adaptable, and fastidious ancestry who happily crowd their large families into the smallest of living spaces" };
            yield return new TextBlock { Id = Guid.Parse("04163349-571d-47d7-9478-efdf18cea1f4"), Type = TextBlockType.Text, Text = "Most surface-dwelling humanoids call ysoki “ratfolk” and know them as a communal people who prefer cramped conditions, with up to 100 individuals living in a given house. If they can’t find homes in town, ysoki may instead live in caves and cavern complexes, as these provide great storage for the many and varied goods they bring back from trading expeditions." };
            yield return new TextBlock { Id = Guid.Parse("64b769b4-f3e6-4d20-bf14-180d443cfb5e"), Type = TextBlockType.Text, Text = "Ratfolk love to travel, and they can often be found on the road in merchant caravans. They’re good with their hands and have a keen eye for spotting anything out of the ordinary, from threats to treasures. They’re also inveterate hoarders; ysoki warrens are crammed full of unusual odds and ends gathered by previous generations and stowed away in preparation for some future emergency." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is smart, fast, well-traveled, and adaptable, try playing a ysoki!" };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("2ba74c3b-4d45-47ce-9bfd-1ed3fc814969"), Type = TextBlockType.Enumeration, Text = "Have pride in your large extended family, and stay in contact with everyone in it. " };
            yield return new TextBlock { Id = Guid.Parse("efb9de80-dc02-4b88-9d00-81ae9ac95c88"), Type = TextBlockType.Enumeration, Text = "Like to travel near and far in search of new experiences, likely collecting trinkets along the way. " };
            yield return new TextBlock { Id = Guid.Parse("9c45781e-863a-498a-bc2c-c39ee2f4dda1"), Type = TextBlockType.Enumeration, Text = "Work well with others." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("01725c72-0edb-457b-8817-aa8659c5fe10"), Type = TextBlockType.Enumeration, Text = "Mistake you for a wererat or another monster. " };
            yield return new TextBlock { Id = Guid.Parse("d0013001-5c0e-4c1d-93f7-3de9a8b72da8"), Type = TextBlockType.Enumeration, Text = "Are surprised by your careful grooming and other fastidious habits. " };
            yield return new TextBlock { Id = Guid.Parse("458b131f-e499-4e42-affa-66e1bce815fe"), Type = TextBlockType.Enumeration, Text = "Think you’re crowding them and invading their personal space." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("68d1fc60-f6ff-4cd1-ab80-abc59e0cea15"), Type = TextBlockType.Text, Text = "Ratfolk have whiskered snouts, large ears, and hairless tails, and typically have red eyes and short brown or black fur. A common ysoki is 4 feet tall and weighs around 80 pounds. Ratfolk vary considerably, however; even a single family group can exhibit substantial variation in hair color, eye color, or size." };
            yield return new TextBlock { Id = Guid.Parse("15177f32-6c5a-4fef-967c-fb576546c631"), Type = TextBlockType.Text, Text = "Instinct drives ysoki to maintain cleanliness, though this is also reinforced through their strong social structures. Other condescending humanoids often presume ratfolk are dirty or diseased, but in actuality, they are meticulous about personal hygiene. Because their appearance is often considered unnatural—and other people mistake them for wererats—ysoki often conceal their physical features with hoods, gloves, shoes, long-sleeved tunics, robes, and other layers of clothing when moving through spaces dominated by other ancestries." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("af31ee4f-d079-4ff4-9e9c-caa1e0784f09"), Type = TextBlockType.Text, Text = "Ysoki culture values cooperation and community. Every ysoki learns—through communal games, social occasions, and sports—to forge fast friendships and connections with ysoki outside their family. You may never know whose help you’re going to need, but when you do, you’re going to need itnow." };
            yield return new TextBlock { Id = Guid.Parse("86dd609d-87b1-437b-8856-291be5e34b2e"), Type = TextBlockType.Text, Text = "With a long tradition of working as traders and tinkers, ysoki travel frequently from one town to another. Their wagons are usually grouped into caravans of up to half a dozen vehicles. Ysoki wagons are pulled by exceptionally large giant rats; many ysoki can speak to such animals." };
            yield return new TextBlock { Id = Guid.Parse("576e9e25-e637-4b02-a605-07646e0e499f"), Type = TextBlockType.Text, Text = "Discrimination against ysoki has shaped their culture, prompting them to rely on each other and strengthening their family and communal bonds. Ysoki are very good at differentiating between bad actors and those who are simply acting out of ignorance, modeling good behavior and slowly working to reverse generations of discrimination for those willing to learn. They are always on the lookout for members of other ancestries who don’t judge them for their appearance, embracing these individuals as true friends and welcoming them into their communities. But they also can quickly spot determined bigots prone to violence and steer clear of such individuals, minimizing any opportunity for tragedy." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("bb9cf2b7-d504-426c-badc-caf0d2ce5370"), Type = TextBlockType.Text, Text = "Ysoki care more about their family than abstract concepts of good and evil. Their warrens might be chaotic dens filled with hoarded knickknacks, but they also obey strict social codes. Most ysoki are neutral." };
            yield return new TextBlock { Id = Guid.Parse("c3abe228-11df-44a5-9106-21ac6070eded"), Type = TextBlockType.Text, Text = "Though ysoki revere their ancestors and tend to acknowledge whatever deity is prevalent in their local area,Lao Shu Pohas a special role in ysoki culture. Grandmother Rat, as she is sometimes known, embodies many things that are otherwise antithetical to ratfolk—she urges followers to put their own interests above others, and she encourages deceit and trickery. To most ysoki, Grandmother Rat accomplishes all those things ratfolk need done, but which no reasonable ratfolk would wish to do." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("bd015e2d-e33f-412d-ab11-b0896e9d3c84"), Type = TextBlockType.Text, Text = "Ratfolk might take up the adventuring life to explore and travel, to defend their family or community, or for any number of other reasons." };
            yield return new TextBlock { Id = Guid.Parse("5026925c-4a8e-4924-bb5e-5871252d1c72"), Type = TextBlockType.Text, Text = "Their natural wit and nimble fingers make ratfolk excellentalchemistsandrogues, while some specialize in ranged weapons asfightersorrangers." };
            yield return new TextBlock { Id = Guid.Parse("a102403f-36b0-4967-b915-9b2c2c079e07"), Type = TextBlockType.Text, Text = "Typical ratfolk backgrounds includeanimal whisperer,artisan,merchant,medic,nomad,scout, andtinkerfrom theCore Rulebook, plusbandit,barber,scavenger, andteacherfrom this book." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("fa2d9159-0cf3-4fc2-8f2b-9388f7164ec2"), Type = TextBlockType.Text, Text = "Every ysoki family has perhaps two dozen names that have been passed down from generation to generation, sometimes with minor alterations or alternative nicknames. A grandfather might be Grivver, for example, while his daughter goes by Griva and her son is simply Griv. Ratfolk are often assigned nicknames and sobriquets by humanoids they interact with, but most ysoki find these names distasteful and endure them only when outside ysoki communities." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Ratfolk Settlements" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ysoki congregate at trading cities and crossroads of all kinds. In Avistan, ratfolk are somewhat more prevalent in Druma, the Five Kings Mountains, and Taldor, as well as port cities like Absalom and Riddleport. Others carve out warrens far from human settlements, such as Numeria's Chitterhome. Garundi ysoki congregate in Katapesh and the Mana Wastes (where they're in demand as alchemists and tinkerers), though many sail as far as Thuvia, the Shackles, and Vidrian. Ysoki dwell throughout Casmaron. They are respected in Kelesh and well established in the caravan city of Ular Kel. Diguo-Dashu, the famous “Empire of Rats,” sprawls below central Tian Xia; however, ysoki also appear throughout that continent's Darklands, especially in the recently reestablished Second Ticker (see below) and the Deepmarket below Goka." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Second Ticker" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Five centuries ago, the sorceress Hao Jin (Lost Omens Legends 46) thwarted a ratfolk surface invasion by transporting the ratfolk's Darklands province to her private demiplane. The demiplane recently collapsed, returning the sphere (now called Round Mountain) to its former site—thankfully just after Pathfinder agents had evacuated the area (then known as Broken Ticker). At first, the ysoki's delight at their reunification smoothed over the upheaval caused by Round Mountain's return. However, the event diverted nearby rivers and trade routes and caused many Broken Ticker ratfolk to lose their homes; the Round Mountain ysoki must now readjust to a world that forgot them; and Hao Jin is reluctant to arbitrate. The united realm of Second Ticker has thus become a powder keg, with only the threat of a nearby army of clockwork soldiers keeping it from exploding." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Ysoki of the Red Planet" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "To Golarion natives, Akiton appears as a pink star winking in the evening sky. The handful of explorers who've gone there and returned tell of a desert planet peopled by red-skinned humanoids, four-armed giants, and— most surprisingly of all—ysoki almost identical to Golarion's ratfolk, even down to a shared common language. These ysoki are expert traders as well as superlative gadgeteers; while they invent little themselves, they can repair or reverse-engineer nearly any sort of widget." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "" };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "" };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Ratfolk.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("ba101fcb-fca8-45c0-a709-5a6885cbb1b8"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("2240507e-35a6-4268-af49-e33a41a2d049"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("150db2f1-63ac-4c72-9cda-3ae01b56d467"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("12d1a368-dd0b-42ee-9a3b-7fb6ec41c98d"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("989962ec-cf5e-4b24-b014-63ff21b31d7b"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("bb648e00-b8ec-4a89-a20d-d30273826581"), Stats.Instances.Strength.ID);
            builder.GainSpecificLanguage(Guid.Parse("22edfe1d-38ba-4da3-91f4-84ebe820ef63"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("2066b50b-24f6-436d-8b36-876d0c524e40"), Languages.Instances.Ysoki.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94898905-9f58-41de-b098-17c83c32c7ad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 21
            };
        }
    }
}
