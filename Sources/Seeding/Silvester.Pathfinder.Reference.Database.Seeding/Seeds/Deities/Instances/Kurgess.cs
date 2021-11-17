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
    public class Kurgess : Template
    {
        public static readonly Guid ID = Guid.Parse("b11ea2ca-b9ec-4c9a-84f1-19e332f03eaf");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Kurgess",
                Edicts = "Compete to your full potential, claim victory or accept defeat with grace, seek always to better yourself, encourage others to strive toward their own potential for greatness.",
                Anathema = "Cheat at honorable contests, dishonor those who have lost or failed (including defeated or slain enemies), engage in reckless or needless destruction or bloodshed.",
                Title = "The Strong Man",
                AreasOfConcern = "Healthy competition, sport, and physical development.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("716999b9-00d1-467d-b859-de2fb6afbe11"), Type = TextBlockType.Text, Text = "Once a mortal farm boy from Taldor who had superhuman strength from youth, Kurgess's selfless sacrifice on the field of competition heralded his rise to godhood. Known as the Strong Man, Kurgess stands as both champion and shining example to those who seek athletic achievement and to give their all in competition, regardless of whether they are victorious or not." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("88766a9a-c07b-4874-b399-2960666ebcd8"), Spells.Instances.AntHaul.ID);
            builder.GainSpecificSpell(Guid.Parse("b0342ce1-3cde-4063-939f-dec8187d14bc"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("27b6cb37-a978-4b21-8045-c06c525365e5"), Spells.Instances.Haste.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Javelin.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("507b9ded-96ae-4296-b5f1-7503a503d438"),
                Description = "The Strong Man’s gifts reflect his mastery of might.",
                MinorBoon = "The Strong Man blesses you with a measure of his strength. Increase your maximum and encumbered Bulk limits by 2.",
                ModerateBoon = "You fear no exertion. You can employ exploration tactics normally while fatigued.",
                MajorBoon = "You possess a true champion's might. When you roll a critical failure on an Athletics check, you get a failure instead, and when you roll a success, you instead get a critical success.",
                MinorCurse = "Difficulty lifting burdens is a sign of divine disapproval. Your maximum and encumbered Bulk limits decrease by 2.",
                ModerateCurse = "Kurgess's displeasure breaks your competitive edge, causing you to fail at the cusp of success. If your check result exactly equals the DC, you fail instead of succeeding.",
                MajorCurse = "The wrath of Kurgess withers you almost to nothing. You are permanently drained 2 and enfeebled 4.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("1cc27f52-4ea7-4280-85b4-43336aef388c"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 7
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
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Truth.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("10c76d9e-3202-4fef-9a7b-0488730c8517"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 65
            };
        }
    }
}
