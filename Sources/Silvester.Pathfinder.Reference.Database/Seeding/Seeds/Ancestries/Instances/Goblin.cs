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
    public class Goblin : Template
    {
        public static readonly Guid ID = Guid.Parse("c27f6e52-cc62-450a-a247-b541d15fdc93");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Goblin", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Ak, Bokker, Frum, Guzmuk, Krobby, Loohi, Mazmord, Neeka, Omgot, Ranzak, Rickle, Tup, Wakla, Yonk, Zibini"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("5bd1aa20-aa6a-4f4e-9ac3-5e0f88052cfb"), Type = TextBlockType.Text, Text = "The convoluted histories other people cling to don’t interest goblins. These small folk live in the moment, and they prefer tall tales over factual records. The wars of a few decades ago might as well be from the ancient past. Misunderstood by other people, goblins are happy how they are. Goblin virtues are about being present, creative, and honest. They strive to lead fulfilled lives, rather than worrying about how their journeys will end. To tell stories, not nitpick the facts. To be small, but dream big." };
            yield return new TextBlock { Id = Guid.Parse("739b0436-7702-4c3a-a11e-11fed9ed69e6"), Type = TextBlockType.Text, Text = "Goblins have a reputation as simple creatures who love songs, fire, and eating disgusting things and who hate reading, dogs, and horses—and there are a great many for whom this description fits perfectly. However, great changes have come to goblinkind, and more and more goblins resist conformity to these stereotypes. Even among goblins that are more worldly, many still exemplify their old ways in some small manner, just to a more sensible degree. Some goblins remain deeply fascinated with fire or fearlessly devour a meal that might turn others’ stomachs. Others are endless tinkerers and view their companions’ trash as the components of gadgets yet to be made." };
            yield return new TextBlock { Id = Guid.Parse("e0c38818-c4ea-453a-8588-0e1ccde4ab03"), Type = TextBlockType.Text, Text = "Though goblins’ culture has splintered radically, their reputation has changed little. As such, goblins who travel to larger cities are frequently subjected to derision, and many work twice as hard at proving their worth." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is eccentric, enthusiastic, and fun-loving, you should play a goblin." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("1c4056b9-20a6-4451-bf13-61bd5e963a0e"), Type = TextBlockType.Enumeration, Text = "Strive to prove that you have a place among other civilized peoples, perhaps even to yourself. " };
            yield return new TextBlock { Id = Guid.Parse("3d9478b2-62d1-46f7-b65a-30ae35345c6a"), Type = TextBlockType.Enumeration, Text = "Fight tooth and nail—sometimes literally—to protect yourself and your friends from danger. " };
            yield return new TextBlock { Id = Guid.Parse("72e27e78-baba-453b-9c09-c643920f41c2"), Type = TextBlockType.Enumeration, Text = "Lighten the heavy emotional burdens others carry (and amuse yourself) with antics and pranks." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("6cb9d40d-027a-4b1e-ac25-1608b2ba3e80"), Type = TextBlockType.Enumeration, Text = "Work to ensure you don’t accidentally (or intentionally) set too many things on fire. " };
            yield return new TextBlock { Id = Guid.Parse("1bed6eda-a0b6-40da-aa38-db9d8c7fbfc8"), Type = TextBlockType.Enumeration, Text = "Assume you can’t—or won’t—read. " };
            yield return new TextBlock { Id = Guid.Parse("a5992539-b995-42d3-bb25-78cb81629ffe"), Type = TextBlockType.Enumeration, Text = "Wonder how you survive given your ancestry’s typical gastronomic choices, reckless behavior, and love of fire." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("37c8d1b1-4de3-458f-b9dd-6528b2185018"), Type = TextBlockType.Text, Text = "Goblins are stumpy humanoids with large bodies, scrawny limbs, and massively oversized heads with large ears and beady red eyes. Their skin ranges from green to gray to blue, and they often bear scars, boils, and rashes. Goblins average 3 feet tall. Most are bald, with little or no body hair. Their jagged teeth fall out and regrow constantly, and their fast metabolism means they eat constantly and nap frequently. Mutations are also more common among goblins than other peoples, and goblins usually view particularly salient mutations as a sign of power or fortune." };
            yield return new TextBlock { Id = Guid.Parse("290852b2-349b-44c7-adbf-9911c4c68eca"), Type = TextBlockType.Text, Text = "Goblins reach adolescence by the age of 3 and adulthood 4 or 5 years later. Goblins can live 50 years or more, but without anyone to protect them from each other or themselves, few live past 20 years of age." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("4e3b8b60-9d65-483b-afd7-5f33fc1c0ec6"), Type = TextBlockType.Text, Text = "Goblins tend to flock to strong leaders, forming small tribes. These tribes rarely number more than a hundred, though the larger a tribe is, the more diligent the leader must be to keep order—a notoriously difficult task. As new threats rise across the Inner Sea region, many tribal elders have put aside their reckless ways in the hope of forging alliances that offer their people a greater chance at survival. Play and creativity matter more to goblins than productivity or study, and their encampments erupt with songs and laughter." };
            yield return new TextBlock { Id = Guid.Parse("243b949d-b274-4354-a0c3-b9ba71367989"), Type = TextBlockType.Text, Text = "Goblins bond closely with their allies, fiercely protecting those companions who have protected them or offered a sympathetic ear. Goblins tend to assume for their own protection that members of taller ancestries, which goblins often refer to colloquially as “longshanks,” won’t treat them kindly. Learning to trust longshanks is difficult for a goblin, and it’s been only in recent years that such a partnership has even been an option. However, their attitude as a people is changing rapidly, and their short lifespans and poor memories help them adapt quickly." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("e9c16781-77a6-453d-99bc-c1041498efaa"), Type = TextBlockType.Text, Text = "Even well-intentioned goblins have trouble following the rules, meaning they’re rarely lawful. Most goblin adventurers are chaotic neutral or chaotic good. Organized worship confounds goblins, and most of them would rather pick their own deities, choosing powerful monsters, natural wonders, or anything else they find fascinating. Longshanks might have books upon books about the structures of divinity, but to a goblin, anything can be a god if you want it to. Goblins who spend time around people of other ancestries might adopt some of their beliefs, though, and many goblin adventurers adopt the worship ofCayden Cailean." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("0d1fa67f-c1f8-4580-9335-8b15c9ce4cf0"), Type = TextBlockType.Text, Text = "To some degree, almost every goblin is an adventurer, surviving life on the edge using skill and wits. Goblins explore and hunt for treasures by nature, though some become true adventurers in their own rights, often after being separated from their group or tribe." };
            yield return new TextBlock { Id = Guid.Parse("4c6aa3e8-9c1f-4145-8835-34e76855d2d8"), Type = TextBlockType.Text, Text = "Goblins often have theacrobat,criminal,entertainer,gladiator,hunter, andstreet urchinbackgrounds. Consider playing analchemist, since many goblins love fire, or abard, since many goblins love songs. As scrappy survivors, goblins are oftenrogueswho dart about the shadows, though their inherently charismatic nature also draws them to the pursuit of magical classes such assorcerer." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("1bcba6ff-9acb-4adf-b215-09544d1ca424"), Type = TextBlockType.Text, Text = "Goblins keep their names simple. A good name should be easy to pronounce, short enough to shout without getting winded, and taste good to say. The namer often picks a word that rhymes with something they like so that writing songs is easier. Since there aren’t any real traditions regarding naming in goblin culture, children often name themselves once they’re old enough to do something resembling talking." };
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
            yield return Traits.Instances.Goblin.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("62d6749b-5c0c-4618-ba68-713de4ab1226"), ModifierType.Add, modifier: 6);
            builder.ModifySpecificSpeed(Guid.Parse("0072d7d1-d062-4535-b194-0a309e76b450"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("10289eae-588e-446b-97d0-53b6dc4a992c"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("5412c702-4219-45d6-bb0d-fb1cce43a307"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("def0b493-504e-4934-83cb-9adbc95b45a9"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("5d730456-1745-42b4-b829-efdc2d32db24"), Stats.Instances.Wisdom.ID);
            builder.GainSpecificLanguage(Guid.Parse("e078ea8d-6ce8-4151-b576-623e5131e171"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("f93c4b6c-c6e4-4ece-a2d9-21c4772a7116"), Languages.Instances.Goblin.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1eaeb1a1-2818-47a4-a672-717c1d90100b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 47
            };
        }
    }
}
