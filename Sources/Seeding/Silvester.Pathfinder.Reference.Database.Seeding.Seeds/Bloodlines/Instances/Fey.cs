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
    public class Fey : Template
    {
        public static readonly Guid ID = Guid.Parse("f7eccbc0-5137-4419-80bf-4e4a8440354c");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Fey",
                BloodMagic = "Colorful fey glamours dance around you or one target, causing them to be concealed for 1 round. Such obvious concealment can't be used to Hide.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.FaerieDust.ID,
                AdvancedBloodlineSpellId = Spells.Instances.FeyDisappearance.ID,
                GreaterBloodlineSpellId = Spells.Instances.FeyGlamour.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("11d7a9df-313e-418d-a521-0721ac512575"), Type = TextBlockType.Text, Text = "Fey whimsy or a tryst in a moonlit grove put the bewitching magic of the First World into your family's bloodline." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("aa733de2-c5ab-4a8e-bad2-28ea968c6447"), MagicTraditions.Instances.Primal.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse("3406bd68-e841-494e-a0e4-192c4882beb5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("eca31795-c448-4d5a-abc8-fb114d2e62d7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse("97cda040-7506-4375-bcc1-31716b5e2aca"), Spells.Instances.FaerieDust.ID);
            builder.GainSpecificSpell(Guid.Parse("7d020795-bc60-48e1-b76c-2b7c361a9b39"), Spells.Instances.GhostSound.ID);
            builder.GainSpecificSpell(Guid.Parse("16d1b72c-9059-499c-83f4-8a1eea99e009"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("9f9ab9cd-d8ae-4ab3-ab8e-1e022ab216d3"), Spells.Instances.HideousLaughter.ID);
            builder.GainSpecificSpell(Guid.Parse("7d5ff30d-227f-45af-9f0c-d2c0d40b50d9"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("b46a502e-d395-4195-95ae-2e0068869451"), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("5ffc238c-682a-4664-b949-b188e672d460"), Spells.Instances.CloakOfColors.ID);
            builder.GainSpecificSpell(Guid.Parse("591beb26-220a-4705-8ac2-2d51e48f6699"), Spells.Instances.Mislead.ID);
            builder.GainSpecificSpell(Guid.Parse("48b7a9e5-d469-4f62-a712-f1c1c941c7c3"), Spells.Instances.VisionsOfDanger.ID);
            builder.GainSpecificSpell(Guid.Parse("9ecb8ae6-b122-4f5c-b4ca-7f8174a28355"), Spells.Instances.UncontrollableDance.ID);
            builder.GainSpecificSpell(Guid.Parse("20c36078-adef-4305-b697-dc9e60b553b6"), Spells.Instances.ResplendentMansion.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f1a138e-bea8-4a8d-82bb-739b5bb959ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 197
            };
        }
    }
}
