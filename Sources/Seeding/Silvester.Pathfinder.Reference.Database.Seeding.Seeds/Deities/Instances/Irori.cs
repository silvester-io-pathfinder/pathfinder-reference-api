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
    public class Irori : Template
    {
        public static readonly Guid ID = Guid.Parse("6c2f848e-8747-4178-beba-a2b35367bdb3");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Irori",
                Edicts = "Be humble; help others perfect themselves; hone your body, mind, and spirit to a more perfect state; practice discipline.",
                Anathema = "Become addicted to a substance, destroy an important historical text, repeatedly fail to maintain self-control.",
                Title = "Master of Masters",
                AreasOfConcern = "History, knowledge, and self-perfection.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c5431993-6f68-4d79-a9e1-6b9ec12330fe"), Type = TextBlockType.Text, Text = "Irori exemplifies the concepts of self-perfection. His dogma states that he was a mortal who gained godhood through achieving a physical and mental state that surpassed mortal limitations. His followers seek to emulate their god's divine state by perfecting themselves using the words of theUnbinding of Fetters, Irori's sacred text. The illuminated pages of the tome detail numerous physical, spiritual, and mental exercises, as well as methods of learning and remembering." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("dfa4feaf-66ea-45b7-9325-c856626f5d37"), Spells.Instances.Jump.ID);
            builder.GainSpecificSpell(Guid.Parse("a9f5d24c-9007-4306-8404-5af3251b907b"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("05885f2f-1067-4048-8a60-1183926b9682"), Spells.Instances.Stoneskin.ID);
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
                Id = Guid.Parse("daed50f5-b144-47f1-a4be-40ad1612e9c2"),
                Description = "Irori grants his boons to those making progress on their paths toward perfection. He avoids bestowing misfortune as punishment, preferring to do so only to give an individual a challenging obstacle to overcome to help them progress in their quest for self-perfection.",
                MinorBoon = "Irori grants you great insight and knowledge. Once, when you roll a failure at a check to Recall Knowledge, you get a critical success instead. Furthermore, the check loses the secret trait, so you know for sure that the result was a critical success. Irori typically grants this boon for an extremely consequential check to Recall Knowledge.",
                ModerateBoon = "Your body rebuilds after adversity, becoming stronger. You can cast wholeness of body as an occult ki spell. If you didn't have one already, you gain a focus pool with 1 Focus Point and are trained in occult spell attack rolls and spell DCs (the sidebar on the monk class page has full information on what happens when you gain your first ki spell).Major Boon: You can temporarily ascend to a greater form. You can cast 8th-level righteous might once per day as an occult innate spell. When you do, your form appears unremarkable, rather than clad in powerful armaments.Minor Curse: Irori challenges you to seek another path, rather than treat every problem as a nail just because you have a hammer. If you select a check for which you have a higher bonus when another method would have been more appropriate for the situation, such as using Deception to lie through life because it's your highest modifier, even if it would be better to reach a compromise through Diplomacy, you must roll twice and take the lower result.Moderate Curse: Irori challenges you to adapt to adversity in order to perfect yourself. You become weighed down as if under heavy weights, becoming clumsy 2 and encumbered until you accomplish a challenging task of Irori's choosing.Major Curse: Irori makes all living creatures forget your existence. This can be further compounded by raising Irori's ire, resulting in your name being obliterated from all written records. In both cases, memories and writings rearrange themselves to omit you smoothly, rather than leaving obvious gaps.",
                MajorBoon = "You can temporarily ascend to a greater form. You can cast 8th-level righteous might once per day as an occult innate spell. When you do, your form appears unremarkable, rather than clad in powerful armaments.",
                MinorCurse = "Irori challenges you to seek another path, rather than treat every problem as a nail just because you have a hammer. If you select a check for which you have a higher bonus when another method would have been more appropriate for the situation, such as using Deception to lie through life because it's your highest modifier, even if it would be better to reach a compromise through Diplomacy, you must roll twice and take the lower result.",
                ModerateCurse = "Irori challenges you to adapt to adversity in order to perfect yourself. You become weighed down as if under heavy weights, becoming clumsy 2 and encumbered until you accomplish a challenging task of Irori's choosing.",
                MajorCurse = "Irori makes all living creatures forget your existence. This can be further compounded by raising Irori's ire, resulting in your name being obliterated from all written records. In both cases, memories and writings rearrange themselves to omit you smoothly, rather than leaving obvious gaps.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("bcfac2fa-b205-4e34-bbdf-f4a04be18a9f"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 31
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Perfection.ID;
            yield return Domains.Instances.Truth.ID;
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
                Id = Guid.Parse("3e473c32-b3cd-4299-aa47-3c2e4a059191"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}