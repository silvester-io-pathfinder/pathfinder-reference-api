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
    public class Wyrmblessed : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Wyrmblessed",
                BloodMagic = "",
                RarityId = Rarities.Instances.Common.ID,
                RelatedBloodlineId = Bloodlines.Instances.Draconic.ID,
                InitialBloodlineSpellId = Spells.Instances.DragonClaws.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DragonBreath.ID,
                GreaterBloodlineSpellId = Spells.Instances.DragonWings.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Draconic might carries in your voice. Either you gain a +1 status bonus to Intimidation checks for 1 round, or a target takes a –1 status penalty to Will saves for 1 round." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, choose the type of dragon that influenced your bloodline. You can't change your dragon type later. This choice affects how some of your bloodline spells function. The good metallic dragons and their damage types are brass (fire), bronze (electricity), copper (acid), gold (fire), and silver (cold). The evil chromatic dragons and their damage types are black (acid), blue (electricity), green (poison), red (fire), and white (cold). The primal dragons of planar origin and their damage types are brine (acid), cloud (electricity), crystal (piercing), magma (fire), and umbral (negative). The imperial dragons and their damage types are forest (piercing), sea (bludgeoning), sky (electricity), sovereign (mental), and underworld (fire). For the dragon breath focus spell, the area is a 60-foot line for a brine dragon; a 30-foot cone for a cloud, crystal, forest, magma, sovereign, or umbral dragon; and a 10-foot burst within 30 feet for a sea, sky, or underworld dragon." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DragonClaws.ID);
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
                SourceId = Sources.Instances.TheMwangiExpanse.ID,
                Page = 75
            };
        }
    }
}
