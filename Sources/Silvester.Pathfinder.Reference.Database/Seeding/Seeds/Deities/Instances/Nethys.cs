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
    public class Nethys : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Nethys",
                Edicts = "Seek out magical power and use it.",
                Anathema = "Pursue mundane paths over magical ones.",
                Title = "The All-Seeing Eye",
                AreasOfConcern = "Magic.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "To some, magic is a powerful weapon. To others, it's a malleable tool. And to a few, it's a source of purpose. With an understanding of spellcasting, creatures can cause fire to erupt from their hands, call otherworldly beings to aid them, bewitch the senses, and even bring the dead back to life. The ability to reshape reality to better suit one's needs and desires is a powerful call that most only dream of being able to answer, and few are ever able to truly master such might." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One such master was Nethys, who was revered as a god-king in ancient Osirion. Having sought to unlock all of the secrets and potential held within the planes and beyond, Nethys shattered his own mind from the sheer overload of knowledge to which he was exposed. Witnessing all of creation, the secrets of the universe, and the vast expanse of what has been seen and will be seen rent his mind in the same moment he elevated to the status of a god. Nethys gained unlimited power and the skill to utilize it, but at the cost of his core self and mental security. This resulted in a split soul, two sides warring within the same body. One seeks to destroy the world, to purge it through fire and ruin, and to conquer all that exists. The other attempts to protect the world, to elevate and educate, and to release it from its limits." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicMissile.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicMouth.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Levitate.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Blink.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PryingEye.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfForce.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpMind.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Maze.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disjunction.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Staff.ID;
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
                Description = "Nethys is often impartial to his followers and their wishes, so it is rare to gain a heightened favor from the god of magic. However, blatant disregard and stifling of magic will certainly earn his ire.",
                MinorBoon = "Nethys casts a powerful spell to help you in a pinch. Once, Nethys casts a spell 1 level higher than the highest-level spell you can cast. If you can't cast spells, Nethys casts a 1st-level spell to help you.",
                ModerateBoon = "Nethys grants you insight into the secrets of magic. Add one spell from a different tradition of magic to your spell list. You still must learn it or add it to your repertoire normally.",
                MajorBoon = "You are granted supreme magical knowledge and mastery. If you are a prepared spellcaster, you can switch one of your prepared spells for another spell you could have prepared in that slot; if you are a spontaneous spellcaster, you can switch one of the spells in your spell repertoire for another spell you could have chosen for your repertoire instead. In either case, you make this switch by using a single action, which has the concentrate trait. (If you are neither a prepared nor a spontaneous spellcaster, Nethys won't grant you his major boon.)",
                MinorCurse = "The secrets of magic become mentally taxing. You are permanently stupefied 1.",
                ModerateCurse = "Your magic wars against itself like Nethys's dueling halves. Whenever you cast a spell, attempt a DC 11 flat check. On a failure, if your spell was harmful, you instead cast a beneficial spell of the same level on your intended targets, and if it was beneficial, you instead cast a harmful spell of the same level on your intended targets. If the spell benefited some targets and harmed others, you cast a spell of the same level that switches who benefited (for instance, changing a heal spell that harmed undead and healed the living to a harm spell that healed undead and harmed the living). You still lose the spell slot for the spell you were trying to cast.",
                MajorCurse = "Nethys severs your connection to magic. You lose all your spellcasting abilities and cannot gain any future spellcasting.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 35
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Protection.ID;
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
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
