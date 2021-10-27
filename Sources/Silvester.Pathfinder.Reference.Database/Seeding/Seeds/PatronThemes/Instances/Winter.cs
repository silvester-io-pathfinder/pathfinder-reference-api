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
    public class Winter : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Winter",
                Description = "Your patron reflects the frozen reaches of the world, bitterly cruel to those who underestimate that power.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Nature.ID,
                MagicTraditionId = MagicTraditions.Instances.Primal.ID,
                HexCantripId = Spells.Instances.ClingingIce.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.GustOfWind.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ClingingIce.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GustOfWind.ID);
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
