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
    public class NiviRhombodazzle : Template
    {
        public static readonly Guid ID = Guid.Parse("e7f4ce7c-2da9-4825-acc0-a6ffa0108838");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Nivi Rhombodazzle",
                Edicts = "Take risks and savor the consequences whether good or ill, use stealth and guile over violence when dealing with the fallout from your risk-taking, learn the rules and strategies of games of chance played wherever you travel.",
                Anathema = "Break the established rules or terms of a wager, use violence to avoid the consequences of a wager.",
                Title = "The Grey Polychrome",
                AreasOfConcern = "Gambling, gems, gnomes, stealth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("14b790d1-7187-4755-98cc-d5c8f906a6dd"), Type = TextBlockType.Text, Text = "Goddess of gems, stealth, and gambling, Nivi Rhombodazzle is the ultimate high roller, said to have won her divinity from the dwarven god Torag in exchange for a gemstone. She was once a mortal gnome who loved the thrill of an exciting wager, up to and including the moment when the dice turned against her. Eventually, Nivi's debts grew too great for her to remain in her surface home, and she fled into the depths of the Darklands to evade the wrath of her creditors. Most of her adventures in the lightless lands are lost to time and history, but she ultimately emerged reborn as a goddess, hailed as the first of the svirfneblin—uncanny underground gnomes with unique magical abilities and immunity to the dread Bleaching, a wasting curse that claims the lives of gnomes who succumb to boredom and ennui." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e120c432-1d0d-4228-b47f-f42fc24b00a0"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("1126b4d1-9ceb-4ad3-a06a-42344511d77c"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("c9897c24-b25d-470b-bfbf-d940343d580d"), Spells.Instances.PrivateSanctum.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.LightHammer.ID;
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
                Id = Guid.Parse("0992192c-d30c-4b99-a708-75f0e99800ba"),
                Description = "The Grey Polychrome is a carefree and self-indulgent deity who detests using violence where wits will serve. She rewards cunning in her followers and punishes crudeness.",
                MinorBoon = "Those who have earned Nivi's trust are blessed with wild turns of luck in the worst of circumstances. Once, instead of attempting the check you would normally roll, you attempt a DC 11 flat check with the same results. Nivi always grants this boon when the odds are stacked against you (though this same effect is an alternate to her minor curse if she uses it for a check when you would have been very likely to succeed).",
                ModerateBoon = "Nivi bestows a fraction of her skill at pushing consequences down the road. Once per day, after attempting a check, you can roll a second time. You must use the result of the second roll, even if it is worse. This is a fortune effect. At any point after you use this boon, the GM can replace one of your check results with the first result of the check you attempted when using this boon; this delayed result can't be further delayed, prevented, or affected in any way, even by other divine intercessions.",
                MajorBoon = "Those who have done much to please Nivi find themselves slipping from sight when needed. Any time you attempt a Stealth check to Hide or Sneak, you also gain the effects of 2nd-level invisibility and fleet step spells to help you elude your enemies. These effects last until the end of your next turn or until you stop Hiding or Sneaking, whichever comes first (you can continue to Hide or Sneak, turn after turn, to extend these effects).",
                MinorCurse = "Those who betray Nivi's trust find defeat where there was sure to be victory. Once, when you roll a natural 20 on a die, the result becomes a natural 1 instead. Nivi typically uses this curse for maximum poetic justice.",
                ModerateCurse = "Those who arouse Nivi's wrath find themselves bound to the earth with no place to hide. You are wreathed in constant faerie fire and constantly affected by earthbind, and any effect that grants invisibility doesn't work on you.",
                MajorCurse = "Nivi curses unworthy adherents with recklessness. Any time you are presented with a wager, you are compelled to accept, no matter the odds. If you succeed at a DC 40 Will save, you can at least attempt to alter the stakes of that wager in your favor, but you must still accept.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("a15c36e9-ba22-4c21-b63b-57d0991a4539"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 8
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Luck.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("eafb75d5-fe09-4277-a72c-69640fda78e5"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 67
            };
        }
    }
}
