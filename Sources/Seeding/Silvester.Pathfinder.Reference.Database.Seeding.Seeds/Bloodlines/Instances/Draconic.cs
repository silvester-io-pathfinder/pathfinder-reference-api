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
        public static readonly Guid ID = Guid.Parse("45d74f0f-acc1-4638-9c67-b1212f53facb");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Draconic",
                BloodMagic = "Draconic scales grow briefly on you or one target, granting a +1 status bonus to AC for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DragonClaws.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DragonBreath.ID,
                GreaterBloodlineSpellId = Spells.Instances.DragonWings.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("12360968-82ad-4c0c-b7cc-b210683e4de6"), Type = TextBlockType.Text, Text = "The blood of dragons flows through your veins. These beasts are both fearsome in combat and skilled at magic." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("992ea0c9-34b3-4783-822d-fbd0c6de89dd"), Type = TextBlockType.Text, Text = "At 1st level, choose the type of dragon that influenced your bloodline. You can't change your dragon type later. This choice affects how some of your bloodline spells function. The good metallic dragons and their damage types are brass (fire), bronze (electricity), copper (acid), gold (fire), and silver (cold). The evil chromatic dragons and their damage types are black (acid), blue (electricity), green (poison), red (fire), and white (cold)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("3f2ee1fe-760e-45c3-9a89-48bbc52cf3c4"), MagicTraditions.Instances.Arcane.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("9002197d-7fab-424b-b7a2-19402b00175b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("ff5fe385-053c-45ff-9e96-418907959ec2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);

            builder.GainSpecificSpell(Guid.Parse("044c4b50-09e3-4010-9b88-4cc3973a8530"), Spells.Instances.DragonClaws.ID);
            builder.GainSpecificSpell(Guid.Parse("156ac083-c307-4eca-ad17-4b7a0c8e8396"), Spells.Instances.Shield.ID);
            builder.GainSpecificSpell(Guid.Parse("41bba40b-f1d8-4bb1-a4ff-d77d57121e40"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("8a318b81-66e0-42d5-9332-45972a7fe7bd"), Spells.Instances.ResistEnergy.ID);
            builder.GainSpecificSpell(Guid.Parse("6a84aca4-768f-4aed-88be-d2428c1484b0"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("bd682ac0-bdba-4359-95cd-9ecebb626514"), Spells.Instances.SpellImmunity.ID);
            builder.GainSpecificSpell(Guid.Parse("7b91ebda-19b6-4f52-8ca4-aab86ca7a491"), Spells.Instances.ChromaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse("201aa280-f463-41ca-8ff9-cdd1829ff124"), Spells.Instances.DragonForm.ID);
            builder.GainSpecificSpell(Guid.Parse("f5b53725-0177-4b86-bc08-a8c863862f92"), Spells.Instances.MaskOfTerror.ID);
            builder.GainSpecificSpell(Guid.Parse("7acbab0a-daef-4bfd-92cd-532697c72971"), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse("9a333caf-606f-4de5-8ce2-71595dd306ec"), Spells.Instances.OverwhelmingPresence.ID);
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
                Id = Guid.Parse("e502889a-7d25-4c91-93fd-926937b753d9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 196
            };
        }
    }
}
