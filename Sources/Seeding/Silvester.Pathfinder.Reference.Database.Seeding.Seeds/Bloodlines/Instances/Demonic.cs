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
        public static readonly Guid ID = Guid.Parse("671edcf8-d72f-483b-812a-c149c15e9635");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Demonic",
                BloodMagic = "The corruption of sin weakens a target's defenses or makes you more imposing. Either a target takes a -1 status penalty to AC for 1 round, or you gain a +1 status bonus to Intimidation checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.GluttonsJaw.ID,
                AdvancedBloodlineSpellId = Spells.Instances.SwampOfSloth.ID,
                GreaterBloodlineSpellId = Spells.Instances.AbyssalWrath.ID,
                SpellListTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3dab9f0f-bff3-4a4d-826b-2a7598bfd7c0"), Type = TextBlockType.Text, Text = "Demons debase all they touch. One of your ancestors fell victim to their corruption, and you are burdened by that sin." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("732db44f-d090-4020-a107-ef677a35c190"), MagicTraditions.Instances.Divine.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("6e530c4f-019a-4ac6-bcb6-bd2412be9574"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("108400ae-58a5-4d40-980b-9fb4538a74ca"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);

            builder.GainSpecificSpell(Guid.Parse("a40f707b-f993-4fba-bee8-d839537ed91e"), Spells.Instances.GluttonsJaw.ID);
            builder.GainSpecificSpell(Guid.Parse("6652d5a4-e48b-4abf-a572-16f39bfd0c65"), Spells.Instances.AcidSplash.ID);
            builder.GainSpecificSpell(Guid.Parse("e44e66aa-0713-4a2e-9e09-0b693e6b750f"), Spells.Instances.Fear.ID);
            builder.GainSpecificSpell(Guid.Parse("9ff29924-a36f-4b20-b69b-677abdccbac0"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("7b481eec-3eec-4de9-b7df-e75bfe84f9cc"), Spells.Instances.Slow.ID);
            builder.GainSpecificSpell(Guid.Parse("2e03ca0d-a9e3-411f-a3dc-f1fb881f9820"), Spells.Instances.DivineWrath.ID);
            builder.GainSpecificSpell(Guid.Parse("254d176a-faaf-4b97-a687-4a24b6dd3305"), Spells.Instances.AbyssalPlague.ID);
            builder.GainSpecificSpell(Guid.Parse("b567aa60-ec05-41d1-b64b-5bfc54629d16"), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse("2438cf54-9564-47b8-9728-4fdb4115600b"), Spells.Instances.DivineDecree.ID);
            builder.GainSpecificSpell(Guid.Parse("75db984b-71b6-45ca-a7af-a78a7c725219"), Spells.Instances.DivineAura.ID);
            builder.GainSpecificSpell(Guid.Parse("921782fc-8213-4d50-b2c0-9f086524a4fa"), Spells.Instances.Implosion.ID);
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
                Id = Guid.Parse("ea4e4292-3b9b-4972-ba0a-1057beb2f2db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 195
            };
        }
    }
}
