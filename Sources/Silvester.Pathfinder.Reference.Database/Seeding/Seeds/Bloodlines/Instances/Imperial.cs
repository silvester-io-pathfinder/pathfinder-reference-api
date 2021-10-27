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
    public class Imperial : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Imperial",
                BloodMagic = "A surge of ancestral memories grants you or one target a +1 status bonus to skill checks for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.AncestralMemories.ID,
                AdvancedBloodlineSpellId = Spells.Instances.ExtendSpell.ID,
                GreaterBloodlineSpellId = Spells.Instances.ArcaneCountermeasure.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One of your ancestors was a mortal who mastered magic. Such magical blood can remain latent for generations, but in you it manifested in full." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AncestralMemories.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicMissile.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DispelMagic.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimensionDoor.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PryingEye.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disintegrate.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PrismaticSpray.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Maze.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PrismaticSphere.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Society.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
