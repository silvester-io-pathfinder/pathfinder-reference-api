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
    public class Undead : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Undead",
                BloodMagic = "Necromantic energy flows through you or one target. Either you gain temporary Hit Points equal to the spell’s level for 1 round, or a target takes 1 negative damage per spell level (if the spell already deals initial negative damage, combine this with the spell’s initial damage before determining weaknesses and resistances).",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.UndeathsBlessing.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DrainLife.ID,
                GreaterBloodlineSpellId = Spells.Instances.GraspingGrave.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The touch of undeath runs through your blood. Your family tree might contain powerful undead, like a vampire, or perhaps you died and returned a bit different." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UndeathsBlessing.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ChillTouch.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Harm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BindUndead.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TalkingCorpse.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Cloudkill.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VampiricExsanguination.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FingerOfDeath.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.HorridWilting.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WailOfTheBanshee.ID);
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
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
