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
    public class Diabolic : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Diabolic",
                BloodMagic = "Hellfire scorches a target or fills your tongue with lies. Either a target takes 1 fire damage per spell level (if the spell already deals initial fire damage, combine this with the spell’s initial damage before determining weaknesses and resistances), or you gain a +1 status bonus to Deception checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DiabolicEdict.ID,
                AdvancedBloodlineSpellId = Spells.Instances.EmbraceThePit.ID,
                GreaterBloodlineSpellId = Spells.Instances.HellfirePlume.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Devils are evil with a silver tongue, and one of your ancestors dallied in darkness or made an infernal pact." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DiabolicEdict.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ProduceFlame.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FlamingSphere.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MeteorSwarm.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 196
            };
        }
    }
}
