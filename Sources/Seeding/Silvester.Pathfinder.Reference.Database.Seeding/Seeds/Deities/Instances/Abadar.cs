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
    public class Abadar : Template
    {
        public static readonly Guid ID = Guid.Parse("d601be6e-ca99-4622-b730-4e6bccc9ad7d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Abadar",
                Edicts = "Bring civilization to the frontiers, earn wealth through hard work and trade, follow the rule of law.",
                Anathema = "Engage in banditry or piracy, steal, undermine a law-abiding court.",
                Title = "Master of the First Vault",
                AreasOfConcern = "Cities, law, merchants, and wealth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("500ef87f-f699-4b17-b4ef-d55ed9c08a1c"), Type = TextBlockType.Text, Text = "Abadar is worshipped as the god of cities, law, merchants, and wealth. Abadar's cathedral-banks are found in many cities and places where order thrives or is gaining a foothold. Aristocrats, city guards, merchants, and those working in legal practice or who have the well-being of their community on their mind are common worshippers of the god of cities, along with dwarves in general. Abadaran priests living in cities often serve as judges, lawyers, and clerks, while those who live on the frontier work as roving magistrates, acting as judge, jury, and executioners in the name of order." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("052e8485-3630-4190-ad39-25a928b7ce46"), Spells.Instances.IllusoryObject.ID);
            builder.GainSpecificSpell(Guid.Parse("ec6c211a-ef09-44c7-8a9a-06843cb7f6b4"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("8385f597-b0a2-4715-a8f5-05a139a1516e"), Spells.Instances.MagnificentMansion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Crossbow.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("80c35e11-a431-42f0-9d18-3a42bfe8af09"),
                Description = "Abadar’s gifts take the form of riches, while his ire tends to cause offenders to lose wealth.",
                MinorBoon = "Abadar warns his favored against those who might unfairly take advantage. Once, when someone rolls a success on a Deception check to Lie maliciously to you and you alone, they get a critical failure instead. Abadar typically chooses to grant this boon in response to an extremely consequential lie.",
                ModerateBoon = "Abadar blesses all your enterprises, leading to financial success as all your ventures always seems to work out. If you roll a critical failure at a check to Earn Income, you get a failure instead. If you roll a success on a check to Earn Income, you earn twice the usual amount of income.",
                MajorBoon = "Your silver tongue is infallible, allowing you to reach a compromise if one is even remotely possible. Once per day, you know just what to offer to make a deal or broker a negotiation, and if you offer your divinely inspired deal, you can automatically receive a result of 20 + your Diplomacy modifier on your Diplomacy check instead of rolling. This does not increase your degree of success like rolling a 20 would. If there is legitimately nothing you could offer to reach an agreement, you learn that, and you don't expend your daily use of the boon.",
                MinorCurse = "Any time you steal, illegally harm or kill another creature, or undermine a law-abiding officer or court, a symbol or word describing your crime appears on a visible spot on your skin. This symbol cannot be removed or hidden with makeup (though it can be covered with clothing) and it doesn't vanish until you make legal restitution for the crime, such as by serving your sentence.",
                ModerateCurse = "Abadar curses all your enterprises, leading to financial disaster as all your ventures always seem to fail. The result of your check to Earn Income is always one degree of success worse than the one you rolled.",
                MajorCurse = "You become honest to a fault. You constantly suffer the critical failure effect of zone of truth. Additionally, you are always offered the worst possible option in a bargain.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("3eeb8cc5-787b-4412-bcc0-e8988a558409"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 13
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("947ec817-2af1-401f-bfb8-307c9a14284f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
