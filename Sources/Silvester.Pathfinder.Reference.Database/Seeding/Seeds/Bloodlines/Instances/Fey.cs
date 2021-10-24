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
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Fey",
                BloodMagic = "Colorful fey glamours dance around you or one target, causing them to be concealed for 1 round. Such obvious concealment can’t be used to Hide.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.FaerieDust.ID,
                AdvancedBloodlineSpellId = Spells.Instances.FeyDisappearance.ID,
                GreaterBloodlineSpellId = Spells.Instances.FeyGlamour.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Fey whimsy or a tryst in a moonlit grove put the bewitching magic of the First World into your family’s bloodline." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FaerieDust.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GhostSound.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.HideousLaughter.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CloakOfColors.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Mislead.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VisionsOfDanger.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UncontrollableDance.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 197
            };
        }
    }
}
