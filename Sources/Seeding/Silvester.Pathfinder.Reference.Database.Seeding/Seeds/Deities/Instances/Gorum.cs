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
    public class Gorum : Template
    {
        public static readonly Guid ID = Guid.Parse("c0fe2914-29ca-4399-bb87-797fd6d04f26");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Gorum",
                Edicts = "Attain victory in fair combat, push your limits, wear armor in combat.",
                Anathema = "Kill prisoners or surrendering foes, prevent conflict through negotiation, win a battle through underhanded tactics or indirect magic.",
                Title = "Our Lord in Iron",
                AreasOfConcern = "Battle, strength, and weapons.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("705c46fe-bfb7-490c-b862-062606cb0436"), Type = TextBlockType.Text, Text = "The clash of steel, the cry of victory, the gasping denial of death: these are the sound of prayers to Our Lord in Iron, for to follow Gorum is to fight. Gorum does not care the reason for battle—a village's desperate stand against raiders is no less worthwhile to him than a crusader army marching against demons in the Sarkoris Scar—nor does he choose sides in such clashes. Good or evil, law or chaos, the reason for the fight is irrelevant. It is the thrill of battle that finds his favor, the crucible of struggle in which victory is there for the taking." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c387dfc5-3772-4d98-bf37-c8f634af2ee6"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("f819a869-ede0-48e1-9c72-92a65eb4b046"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("e1df50cb-f7d6-44a6-af2d-30f1835ca01b"), Spells.Instances.WeaponStorm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greatsword.ID;
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
                Id = Guid.Parse("803ab50a-d389-48e7-8201-bd51f24b6d87"),
                Description = "Gorum views things very simply: one either fights and earns his favor, or one is a coward and receives only scorn.",
                MinorBoon = "Gorum grants you a weapon whenever you need one. You can use an Interact action to draw a 0-level non-magical iron weapon, even if you have no weapons on your person. Such a weapon lasts only as long as you continue using it to attack, and it can't be sold, given away, melted for scrap iron, or the like.",
                ModerateBoon = "Your blows become unstoppable, carrying the momentum of Gorum's thrill for battle. Your greatsword Strikes gain the forceful trait.",
                MajorBoon = "Gorum feeds you the zeal of his undying warriors, allowing you to draw upon your own life force to fight on and on without falling. Whenever you would be reduced to 0 Hit Points, you are instead healed to half your maximum Hit Points and become doomed 1 (or increase your doomed condition by 1).",
                MinorCurse = "Gorum rewards cowardice with frailty. Any armor you wear and shield you wield reduces its item bonus to AC by 2 (minimum 0) and its Hardness, Hit Points, and Break Threshold by half.",
                ModerateCurse = "You've lost the glory of slaying a worthy opponent. All of your weapon and unarmed attacks decrease their damage dice by one step, and all your attacks are nonlethal.",
                MajorCurse = "You are unable to keep up with the rigors of combat. The moment a combat breaks out, you become fatigued and slowed 1. At the end of each of your turns, your slowed condition increases by 1. These conditions end only when you are no longer in combat.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("1145e327-09dd-411e-9b89-fd741b96a0e1"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 25
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("024cf20e-58ff-44f7-8a70-580253887618"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
