using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes.Instances
{
    public class Night : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Night",
                Description = "Your patron speaks from the shadows, granting you power over darkness and dreams.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Occultism.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
                HexCantripId = Spells.Instances.ShroudOfNight.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.Sleep.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShroudOfNight.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Sleep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
