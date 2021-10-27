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
    public class Fervor : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Fervor",
                Description = "Your patron represents a grand ideal or goal, granting you magic to further their mission and bring others to the cause.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Religion.ID,
                MagicTraditionId = MagicTraditions.Instances.Divine.ID,
                HexCantripId = Spells.Instances.StrokeTheHeart.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.Command.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.StrokeTheHeart.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Command.ID);
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
