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
        public static readonly Guid ID = Guid.Parse("2e18541e-811c-43d9-bd43-a6847b17cfe1");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Wyrmblessed",
                BloodMagic = "",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DragonClaws.ID,
                AdvancedBloodlineSpellId = Spells.Instances.DragonBreath.ID,
                GreaterBloodlineSpellId = Spells.Instances.DragonWings.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("417db202-3c9b-47ae-bc6b-23b09a688e3e"), Type = TextBlockType.Text, Text = "Draconic might carries in your voice. Either you gain a +1 status bonus to Intimidation checks for 1 round, or a target takes a �1 status penalty to Will saves for 1 round." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("63c1d34f-ee1c-4239-8c59-47f4ca7c874b"), Type = TextBlockType.Text, Text = "At 1st level, choose the type of dragon that influenced your bloodline. You can't change your dragon type later. This choice affects how some of your bloodline spells function. The good metallic dragons and their damage types are brass (fire), bronze (electricity), copper (acid), gold (fire), and silver (cold). The evil chromatic dragons and their damage types are black (acid), blue (electricity), green (poison), red (fire), and white (cold). The primal dragons of planar origin and their damage types are brine (acid), cloud (electricity), crystal (piercing), magma (fire), and umbral (negative). The imperial dragons and their damage types are forest (piercing), sea (bludgeoning), sky (electricity), sovereign (mental), and underworld (fire). For the dragon breath focus spell, the area is a 60-foot line for a brine dragon; a 30-foot cone for a cloud, crystal, forest, magma, sovereign, or umbral dragon; and a 10-foot burst within 30 feet for a sea, sky, or underworld dragon." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("2c7c4424-3fd3-4961-a10c-9a4e1d076839"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("78f9337e-0e8b-450a-83b1-86c842c970a9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("7c147ae6-e977-4542-9db2-d5343c6ee479"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("db443eb0-2752-410d-b63d-0910608ff2eb"), Spells.Instances.DragonClaws.ID);
            builder.GainSpecificSpell(Guid.Parse("b11dc532-e1e9-4300-a2c5-c49908567c45"), Spells.Instances.ChillTouch.ID);
            builder.GainSpecificSpell(Guid.Parse("f6c84a71-ec54-442e-9a54-a1702aeb5f10"), Spells.Instances.Harm.ID);
            builder.GainSpecificSpell(Guid.Parse("16ee10ab-a38e-4463-8db1-1112c24c322a"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("96c2b95a-022c-4933-ac42-4ff761739cef"), Spells.Instances.BindUndead.ID);
            builder.GainSpecificSpell(Guid.Parse("1afb64dd-0975-4485-82dd-68da4bc17949"), Spells.Instances.TalkingCorpse.ID);
            builder.GainSpecificSpell(Guid.Parse("86277805-f7c6-4c25-896f-209fdc47e5b2"), Spells.Instances.Cloudkill.ID);
            builder.GainSpecificSpell(Guid.Parse("3335845d-5e29-411d-a122-c05251d6cfa0"), Spells.Instances.VampiricExsanguination.ID);
            builder.GainSpecificSpell(Guid.Parse("4c3bb26e-ee45-4d1b-8c6d-23c0d8284708"), Spells.Instances.FingerOfDeath.ID);
            builder.GainSpecificSpell(Guid.Parse("15857a26-4f22-4a4a-94fa-e7539e9d3f52"), Spells.Instances.HorridWilting.ID);
            builder.GainSpecificSpell(Guid.Parse("28167160-6f7c-42b8-99f5-2bfeef43f8e0"), Spells.Instances.WailOfTheBanshee.ID);
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
                Id = Guid.Parse("805db7ef-d0bd-4dc8-b9b3-24020903b633"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 75
            };
        }
    }
}
