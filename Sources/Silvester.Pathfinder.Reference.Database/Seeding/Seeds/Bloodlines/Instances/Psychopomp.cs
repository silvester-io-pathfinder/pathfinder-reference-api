using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Psychopomp : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Psychopomp",
                BloodMagic = "The border between life and death becomes blurred to you. Either you gain a +2 status bonus to Fortitude saving throws for 1 round, or a target takes 1 damage per spell level. The damage is negative if the target is living or positive if the target is undead. If the spell already deals that type of damage, combine it with the spell's initial damage before determining weaknesses and resistances.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.SepulchralMask.ID,
                AdvancedBloodlineSpellId = Spells.Instances.SpiritVeil.ID,
                GreaterBloodlineSpellId = Spells.Instances.ShepherdOfSouls.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "For good or ill, your ancestors' deeds drew the attention of psychopomps, or you might somehow count one in your family tree. The presence of these shepherds of souls and enemies of undeath has left an indelible mark on you." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Intimidation.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Religion.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.SepulchralMask.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DisruptUndead.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Heal.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CalmEmotions.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.SearingLight.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DimensionalAnchor.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DeathWard.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.SpiritBlast.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.FingerOfDeath.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.SpiritSong.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Massacre.ID };
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
