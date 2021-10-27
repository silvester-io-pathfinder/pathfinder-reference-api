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
    public class Angelic : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Angelic",
                BloodMagic = "An angelic aura protects you or one target, granting a +1 status bonus to saving throws for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.AngelicHalo.ID,
                AdvancedBloodlineSpellId = Spells.Instances.AngelicWings.ID,
                GreaterBloodlineSpellId = Spells.Instances.CelestialBrand.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One of your forebears hailed from a celestial realm, or your ancestors’ devotion led to their lineage being blessed." };
        }
        
        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AngelicHalo.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Light.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Heal.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiritualWeapon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SearingLight.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineWrath.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FlameStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BladeBarrier.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Foresight.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
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
