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
    public class Fate : Template
    {
        public static readonly Guid ID = Guid.Parse("a168cacd-dd50-4114-9c5f-1ce9f6e8702a");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Fate",
                Description = "Through your patron, you gain glimpses of the future and insight into the ever-woven tapestry of time.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Occultism.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.TrueStrike.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("cc840f97-cab8-4bb9-a857-2c40669116af"), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("970a7ebb-78f2-4231-9e2d-6dc41bd02181"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSpell(Guid.Parse("7c2cef0f-202f-4151-971e-f3807c4f4d6b"), Spells.Instances.NudgeFate.ID);
            builder.GainSpecificSpell(Guid.Parse("68462f9e-d34c-4c18-8f2c-5d0e75ecaa19"), Spells.Instances.TrueStrike.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f89c4f40-dd41-49cb-bb6d-d637681d0f4a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
