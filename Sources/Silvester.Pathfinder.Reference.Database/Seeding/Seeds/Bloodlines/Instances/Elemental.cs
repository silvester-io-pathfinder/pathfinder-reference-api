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
    public class Elemental : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Elemental",
                BloodMagic = "Elemental energy surrounds you or a target. Either you gain a +1 status bonus to Intimidation checks for 1 round, or a target takes 1 damage per spell level. The damage is bludgeoning or fire, according to your elemental type (see below). If the spell already deals that type of damage, combine it with the spell’s initial damage before determining weaknesses and resistances.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.ElementalToss.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ElementalMotion.ID,
                GreaterBloodlineSpellId = Spells.Instances.ElementalBlast.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A genie ancestor or some other elemental influence has imbued your blood with primal fury, affecting how the bloodline spells and granted spells, as well as your blood magic, function." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose the type of elemental that influenced your bloodline: air, earth, fire, or water. If your element is air, you buffet your foes with powerful winds; if it's earth, you toss huge chunks of rock; if it's fire, you incinerate your foes with flame; and if it's water, you inundate your foes with torrents of water. For fire, all marked spells deal fire damage. For other elements, they deal bludgeoning damage. You replace any existing elemental traits with the trait of the element you chose." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ElementalToss.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ProduceFlame.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResistEnergy.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FreedomOfMovement.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ElementalForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Repulsion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.StormOfVengeance.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Nature.ID;
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
