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
    public class Demonic : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Demonic",
                BloodMagic = "The corruption of sin weakens a target’s defenses or makes you more imposing. Either a target takes a –1 status penalty to AC for 1 round, or you gain a +1 status bonus to Intimidation checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.GluttonsJaw.ID,
                AdvancedBloodlineSpellId = Spells.Instances.SwampOfSloth.ID,
                GreaterBloodlineSpellId = Spells.Instances.AbyssalWrath.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Demons debase all they touch. One of your ancestors fell victim to their corruption, and you are burdened by that sin." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GluttonsJaw.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AcidSplash.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Fear.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Slow.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineWrath.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AbyssalPlague.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Implosion.ID);
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
                Page = 195
            };
        }
    }
}
