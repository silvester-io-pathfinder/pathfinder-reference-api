using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Intimidation.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Religion.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.UndeathsBlessing.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ChillTouch.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Harm.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.FalseLife.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.BindUndead.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TalkingCorpse.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Cloudkill.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.VampiricExsanguination.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.FingerOfDeath.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.HorridWilting.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.WailOfTheBanshee.ID };
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
