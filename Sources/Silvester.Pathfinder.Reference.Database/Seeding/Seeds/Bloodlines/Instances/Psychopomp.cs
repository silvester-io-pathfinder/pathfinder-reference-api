using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SepulchralMask.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DisruptUndead.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Heal.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CalmEmotions.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SearingLight.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimensionalAnchor.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DeathWard.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiritBlast.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FingerOfDeath.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiritSong.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Massacre.ID);
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
