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
    public class Phoenix : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Phoenix",
                BloodMagic = "The primal fire of life and death flows through you or one target. Choose to have either you or a target of the spell gain temporary Hit Points equal to the spell's level for 1 round, or to have a target of the spell take fire damage equal to the spell's level (if the spell already deals initial fire damage, combine this with the spell's initial damage before determining weaknesses and resistances).",
                RarityId = Rarities.Instances.Uncommon.ID,
                InitialBloodlineSpellId = Spells.Instances.RejuvenatingFlames.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ShroudOfFlame.ID,
                GreaterBloodlineSpellId = Spells.Instances.CleansingFlames.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have been blessed by a phoenix, perhaps via some magical interaction with a similarly blessed individual." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Grant this new sorcerer bloodline to players who finish the Fists of the Ruby Phoenix Adventure Path. Players can then choose this bloodline for any new sorcerer characters they create for future campaigns." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.RejuvenatingFlames.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SeeInvisibility.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.RemoveCurse.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BreathOfLife.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Contingency.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MomentOfRenewal.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MeteorSwarm.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Pathfinder168.ID,
                Page = 74
            };
        }
    }
}
