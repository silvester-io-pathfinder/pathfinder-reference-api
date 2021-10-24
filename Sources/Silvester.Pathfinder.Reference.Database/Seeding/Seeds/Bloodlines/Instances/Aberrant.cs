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
    public class Aberrant : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Aberrant",
                BloodMagic = "Aberrant whispers shield one target’s mind or your own, granting a +2 status bonus to Will saving throws for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.TentacularLimbs.ID,
                AdvancedBloodlineSpellId = Spells.Instances.AberrantWhispers.ID,
                GreaterBloodlineSpellId = Spells.Instances.UnusualAnatomy.ID,
                SpellListTraditionId = MagicTraditions.Instances.Occult.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Something speaks to you from beyond the stars or below the earth. Ancient and unknowable, this alien influence presses against your mind." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TentacularLimbs.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Daze.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpiderSting.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TouchOfIdiocy.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VampiricTouch.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Confusion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BlackTentacles.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Feeblemind.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpMind.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UncontrollableDance.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UnfathomableSong.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Occultism.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 195
            };
        }
    }
}
