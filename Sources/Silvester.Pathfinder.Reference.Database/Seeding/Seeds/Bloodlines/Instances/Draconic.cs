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
    public class Draconic : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Draconic",
                BloodMagic = "Draconic scales grow briefly on you or one target, granting a +1 status bonus to AC for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                RelatedBloodlineId = Bloodlines.Instances.Wyrmblessed.ID,
                InitialBloodlineSpellId = Spells.Instances.DragonClaws.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DragonBreath.ID,
                GreaterBloodlineSpellId = Spells.Instances.DragonWings.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The blood of dragons flows through your veins. These beasts are both fearsome in combat and skilled at magic." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, choose the type of dragon that influenced your bloodline. You can't change your dragon type later. This choice affects how some of your bloodline spells function. The good metallic dragons and their damage types are brass (fire), bronze (electricity), copper (acid), gold (fire), and silver (cold). The evil chromatic dragons and their damage types are black (acid), blue (electricity), green (poison), red (fire), and white (cold)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DragonClaws.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Shield.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResistEnergy.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpellImmunity.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ChromaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DragonForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MaskOfTerror.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.OverwhelmingPresence.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Intimidation.ID;
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
