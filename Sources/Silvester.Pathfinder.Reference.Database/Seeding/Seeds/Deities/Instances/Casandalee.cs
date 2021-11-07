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
    public class Casandalee : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Casandalee",
                Edicts = "Advance the development of artificial intelligence, encourage understanding between artificial and organic life.",
                Anathema = "Treat artificial life as lesser than organic life, foment distrust between artificial and organic life.",
                Title = "The Iron Goddess",
                AreasOfConcern = "Artificial life, free thinking, intellectual apotheosis.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Casandalee is an unusual god, one who achieved divinity through a merging of advanced science and faith. Formerly an artificial intelligence cloned from the mind of an android from outer space, Casandalee gained her godhood in the heart of Numeria within the computer core of a crashed spaceship, becoming the patron of artificial life, free thinking, and intellectual apotheosis." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though she is sometimes referred to as the Iron Goddess, Casandalee is much more than simple metal. She sometimes appears as a holographic reconstruction of her android form: a female humanoid with purple hair, blue lips, and pale skin traced with glowing circuitry, but upon close inspection, this image seems to consist of millions of complex algorithms of pure light. Casandalee and her followers seek to promote the advancement of Golarion's technology so that the world's inhabitants can better understand— and not fear—the complex mechanisms of so-called artificial life, including androids and free-willed artificial intelligences. Many androids consider themselves the chosen people of Casandalee and depict her as an obvious android with more circuitry or exposed components." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FloatingDisk.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Hypercognition.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfForce.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Polytool.ID;
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
                Id = Guid.Parse(""),
                Description = "Seeing her android devotees and other followers of a constructed nature as her children, the Iron Goddess is most likely to bestow her boons and curses on these individuals.",
                MinorBoon = "Casandalee frees your thinking from dangerous control. Once, when you fail a Will save against an effect that would control your actions, you critically succeed instead. Casandalee typically grants this boon for particularly consequential violations of autonomy and agency.",
                ModerateBoon = "Your organs are partially transformed into mechanical counterparts. You gain resistance 10 to negative damage, and the DC of your flat check to remove persistent bleed damage is only 5.",
                MajorBoon = "Casandalee backs up your memory and soul within her divine data flow. After you die, she casts your consciousness into a new artificial body. While Casandalee constructed your new body artificially, it is otherwise similar to the old, with the same effects as a critical success on a resurrection ritual. Casandalee is instead willing to provide different bodies to those who request them.",
                MinorCurse = "Your joints stiffen, and your mind becomes clouded. You take a –2 status penalty to all rolls for initiative.",
                ModerateCurse = "Casandalee attempts to bring you unwanted intellectual advancement to help you become something better. Each day, at some point during the day, Casandalee bestows a strange insight upon you that you find uncomfortable. If you embrace it, you aren't otherwise affected, but if you don't, you become confused for 10 minutes.",
                MajorCurse = "The code of your soul is constantly being rewritten, and not for the better. You are never temporarily immune against a harmful effect.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 4
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
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Perfection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 57
            };
        }
    }
}
