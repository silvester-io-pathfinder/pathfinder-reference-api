using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Shizuru : Template
    {
        public static readonly Guid ID = Guid.Parse("8d46a341-1fb3-4635-983d-27cb71aac1d0");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.TianGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Shizuru",
                Edicts = "Practice with a weapon every day, honor your ancestors, protect nature and society from corruption and destruction.",
                Anathema = "Abandon a companion in need, dishonor yourself, parlay with truce breakers, separate lovers.",
                Title = "The Empress of Heaven",
                AreasOfConcern = "Ancestors, honor, the sun, and swordplay.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("9c823601-1f6d-413f-a0c7-15a34890dc7d"), Type = TextBlockType.Text, Text = "The Empress of Heaven is worshipped across all of Tian Xia by people of all walks of life, from commoner to lord, farmer to samurai, human to dragon. She is revered as the ruler of the Tian pantheon, respected as the finest samurai in Heaven or Golarion, and honored as the patron of nature and emperors alike. Perhaps the most famous tale about her is that of Shizuru and her loverTsukiyo, the moon god. After Tsukiyo was slain by his brotherFumeiyoshiin a fit of jealousy, Shizuru brought the moon god back to life with the aid ofQi Zhong, the god of medicine. Sadly, Tsukiyo was deeply affected by his experience with death, and though he and Shizuru still love each other, the event created a rift between them. Even so, on the days of an eclipse, they embrace as one." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("335908c5-8556-4282-8767-3375291e1a2c"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("467dede0-becc-48a9-9ef2-d358666601c1"), Spells.Instances.ReflectiveScales.ID);
            builder.GainSpecificSpell(Guid.Parse("4dd29e21-0b92-452a-96f6-9139fce7a1e3"), Spells.Instances.SummonDragon.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Katana.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("2bd1de3c-b9de-459c-b49d-c98c3cac8f70"),
                Description = "The Empress of Heaven wastes little time acting coy about her favor. Her boons are often accompanied by beams of sunlight or calligraphic symbols, while her wrath is often signaled by the cracking of precious items and armor.",
                MinorBoon = "Your attacks help eradicate darkness. When you successfully Strike a foe, your weapon glows with bright light out to 60 feet for 1 minute. This is a light effect with a counteract level equal to half your level rounded up.",
                ModerateBoon = "Shizuru's light flows through your blade. Your weapons and unarmed attacks deal an additional 1d6 fire damage or 1d6 good damage; you choose each time you make an attack.",
                MajorBoon = "Shizuru bestows upon you a golden suit of armor made from sunlight, or transforms your favorite armor to gain that aspect. Once per hour while you are wearing the armor, if an attack would reduce your Hit Points to 0, the attack is instead completely negated.",
                MinorCurse = "Your equipment turns on you for a disgraceful act. The next time you make an attack, your weapon or armor gains the broken condition.",
                ModerateCurse = "Shizuru decrees that her light is no longer your ally. You gain light blindness.",
                MajorCurse = "Those who incite Shizuru's personal wrath earn the hatred of all of her subjects. All imperial dragons and animals you encounter are automatically hostile to you, and you gain weakness 15 to draconic breath weapons.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("86c0295e-e447-4028-ad1b-e1545e77ce03"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 9
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Perfection.ID;
            yield return Domains.Instances.Sun.ID;
            yield return Domains.Instances.Vigil.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("5acb353d-8820-406f-b4b4-2dd186cceb79"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 70
            };
        }
    }
}
